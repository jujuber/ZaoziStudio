using Mapster;
using Microsoft.EntityFrameworkCore;
using Synyi.Framework.Application.Edit;
using Synyi.Framework.Data;
using Synyi.Framework.Kernel;
using Synyi.GyxcInterface.Application.Abstractions.Catalog;
using Synyi.GyxcInterface.Application.Abstractions.Catalog.DTO;
using Synyi.Hrp.Third.His.HisV1.Domain.Entity;

namespace Synyi.GyxcInterface.Application.Catalog;
internal class MaterialCatalogService : EditApplicationServiceBase, IMaterialCatalogService
{
    public MaterialCatalogService()
    {
        var dataManager = KernelFacade.IocResolver.Resolve<IDataManager>();
        MedicalInsuranceDataContext = dataManager.GetDataContext("Hill_MedicalInsurance");
    }
    /// <summary>
    /// 医保数据上下文
    /// </summary>
    public IDataContext MedicalInsuranceDataContext { get; }
    public async Task<ResultCataLog> SyncData(List<CatalogDTO> values)
    {
        //材料
        var adds = new List<Assetcode>();
        var modifies = new List<Assetcode>();
        //临床项目
        var addOrderItems = new List<Orderitem>();
        var addOrderToCharges = new List<Ordertocharge>();
        //关联
        var addBasesubs = new List<SysBasesub>();

        var thirdIds = values.Select(p => p.InciCode).ToList();

        var oldThirds = await EfContext.Query<Assetcode>(p => thirdIds.Contains(p.Acode)).ToListAsync();
        var thirdOrderItemCodes = thirdIds.Select(p => p).ToList();
        var oldOrderItems = await EfContext.Query<Orderitem>(p => thirdOrderItemCodes.Contains(p.Ordercode)).ToListAsync();
        var oldOrderToCharges = await EfContext.Query<Ordertocharge>(p => thirdOrderItemCodes.Contains(p.Ordercode)).ToListAsync();
        var oldOrderItemBasesubs = await EfContext.Query<SysBasesub>(p => p.Tablename == "orderitem" && thirdOrderItemCodes.Contains(p.Itemcode)).ToListAsync();
        var oldAssetBasesubs = await EfContext.Query<SysBasesub>(p => p.Tablename == "assetcode" && thirdIds.Contains(p.Itemcode)).ToListAsync();

        //所有耗材库房
        var wzDepts = await EfContext.Query<Dept>(p => p.Sflag == "L" && p.Useflag == "1").ToListAsync();
        var deptStr = string.Join(",", wzDepts.Select(p => p.Deptid.Trim()));

        foreach (var value in values)
        {
            Assetcode old = oldThirds.FirstOrDefault(p => p.Acode == value.InciCode);
            var orgInput = "HHG00101";// value.Orgs?.FirstOrDefault();
            if (old == null)
            {
                var add = new Assetcode
                {
                    Acode = value.InciCode,
                    Ccname = value.InciDesc,
                    Ccgg = value.Spec,
                    Unit = value.BUomDesc,
                    Py = KernelFacade.PyWb.GetPy(value.InciDesc),
                    Wb = KernelFacade.PyWb.GetWb(value.InciDesc),
                    Cctype = "27",
                    Tt = null,
                    Inprice = KernelFacade.TypeConvert.ToDecimalOrZero(value.Rp),
                    Outprice = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Charge = value.ChargeFlag == "Y" ? "1" : "0",
                    Zf = null,
                    Gf = null,
                    Packunit = value.PUomDesc,
                    Pack = 1,
                    Opendoor = null,
                    Jp = "spd",
                    Updatetime = CurrentTime,
                    Mf = 0m,
                    Mfz = 0m,
                    Many = 0m,
                    Hotkey = null,
                    Feein = "1",
                    Insucode1 = "",//医保码
                    Acountcode = "27",
                    Batype = null,
                    Allowupdatenpl = "1",
                    CertificateNo = value.RegCertNo,
                    HighValue = value.HVFlag=="Y" ? "1" : "2",
                    Hoscode = "HHG00101",
                    //ThirdId = value.Id,
                    Wzlb = 1,
                    BzdwId = "",//orgInput?.BzdwId,
                    Bzdw = "",//orgInput?.Bzdw,
                    Bzxs = 1,//orgInput?.Bzxs,
                    MzdwId = "",//orgInput?.MzdwId,
                    Mzdw = "",//orgInput?.Mzdw,
                    Mzxs = 1,//orgInput?.Mzxs,
                    ZydwId = "",//orgInput?.ZydwId,
                    Zydw = "",//orgInput?.Zydw,
                    Zyxs = 1,//orgInput?.Zyxs,
                };
                EfContext.Add(add);
                adds.Add(add);

                //新增医嘱项目
                var addOrderItem = new Orderitem
                {
                    Ordercode = value.InciCode,
                    Ordername = $"{value.InciDesc}【{value.Spec}】",
                    Ordertype = "NSC",
                    Py = KernelFacade.PyWb.GetPy(value.InciDesc),
                    Wb = KernelFacade.PyWb.GetWb(value.InciDesc),
                    Ot = "M",
                    Code1 = "CL",
                    Sheetflag = "1",
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Charge = "1",
                    Autocharge = "0",
                    Suitableflag = "0",
                    Hostrandt = CurrentTime,
                    Duration = 0,
                    Hoscode = "HHG00101",
                    Gg = value.Spec,
                };
                EfContext.Add(addOrderItem);
                addOrderItems.Add(addOrderItem);

                //新增医嘱对应收费项目
                var addOrderToCharge = new Ordertocharge
                {
                    Ordercode = addOrderItem.Ordercode,
                    Ordername = value.InciDesc,
                    Orderflag = "M",
                    Deptid = "ALL",
                    Drcode = add.Acode,
                    Abc = 1,
                    Dosageday = 1,
                    Drunit = value.BUomDesc,
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Onlyflag = "1",
                    Ftype = "27",
                    Jp = "spd",
                };
                EfContext.Add(addOrderToCharge);
                addOrderToCharges.Add(addOrderToCharge);

                //新增材料关联
                var addAssetBasesub = new SysBasesub
                {
                    Tablename = "assetcode",
                    Itemcode = add.Acode,
                    Itemname = value.InciDesc,
                    Hoscode = "HHG00101",
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Createdate = CurrentTime,
                    Createuser = "spd",
                    Defaultdept = null,
                    Npl = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Childnpl = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Punits = KernelFacade.TypeConvert.ToDecimalOrZero(value.Rp),
                };
                EfContext.Add(addAssetBasesub);
                addBasesubs.Add(addAssetBasesub);

                //新增医嘱项目关联
                var addOrderItemBasesub = new SysBasesub
                {
                    Tablename = "orderitem",
                    Itemcode = addOrderItem.Ordercode,
                    Itemname = addOrderItem.Ordername,
                    Hoscode = "HHG00101",
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Createdate = CurrentTime,
                    Createuser = "spd",
                    Defaultdept = null,
                    Npl = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Childnpl = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Punits = KernelFacade.TypeConvert.ToDecimalOrZero(value.Rp),
                    Zxksdeptlist = deptStr,
                };
                EfContext.Add(addOrderItemBasesub);
                addBasesubs.Add(addOrderItemBasesub);
            }
            else
            {
                var modify = old.Adapt<Assetcode>();
                modify.Ccname = value.InciDesc;
                modify.Ccgg = value.Spec;
                modify.Unit = value.BUomDesc;
                modify.Py = KernelFacade.PyWb.GetPy(value.InciDesc);
                modify.Wb = KernelFacade.PyWb.GetWb(value.InciDesc);
                modify.Cctype = "27";
                modify.Inprice = KernelFacade.TypeConvert.ToDecimalOrZero(value.Rp);
                modify.Outprice = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp);
                modify.Useflag = value.UseFlag == "N" ? "0" : "1";
                modify.Jp = "spd";
                modify.Updatetime = this.CurrentTime;
                modify.Insucode1 = "";//医保码
                modify.Acountcode = "27";
                modify.CertificateNo = value.RegCertNo;
                modify.HighValue = value.HVFlag == "Y" ? "1" : "2";
                modify.Hoscode = "HHG00101";
                modify.Wzlb = 1;
                //modify.BzdwId = orgInput?.BzdwId;
                //modify.Bzdw = orgInput?.Bzdw;
                //modify.Bzxs = orgInput?.Bzxs;
                //modify.MzdwId = orgInput?.MzdwId;
                //modify.Mzdw = orgInput?.Mzdw;
                //modify.Mzxs = orgInput?.Mzxs;
                //modify.ZydwId = orgInput?.ZydwId;
                //modify.Zydw = orgInput?.Zydw;
                //modify.Zyxs = orgInput?.Zyxs;
                this.EfContext.Modify(modify);

                var orderItemCode = value.InciCode;// await GetOrderItemCode(value.Id);
                //删除老的orderitem,ordertocharge,basesub(orderitem和assetcode)
                var oldOrderItem = oldOrderItems.Where(p => p.Ordercode == orderItemCode).ToList();
                if (oldOrderItem.Count > 0)
                {
                    EfContext.Delete(oldOrderItem);
                }
                var oldOrderToCharge = oldOrderToCharges.Where(p => p.Ordercode == orderItemCode).ToList();
                if (oldOrderToCharge.Count > 0)
                {
                    EfContext.Delete(oldOrderToCharge);
                }
                var oldOrderItemBaseSub = oldOrderItemBasesubs.Where(p => p.Itemcode == orderItemCode).ToList();
                if (oldOrderItemBaseSub.Count > 0)
                {
                    EfContext.Delete(oldOrderItemBaseSub);
                }
                var oldAssetBasesub = oldAssetBasesubs.Where(p => p.Itemcode == value.InciCode).ToList();
                if (oldAssetBasesub.Count > 0)
                {
                    EfContext.Delete(oldAssetBasesub);
                }

                //新增医嘱项目
                var addOrderItem = new Orderitem
                {
                    Ordercode = value.InciCode, //await GetOrderItemCode(value.Id),
                    Ordername = $"{value.InciDesc}【{value.Spec}】",
                    Ordertype = "NSC",
                    Py = KernelFacade.PyWb.GetPy(value.InciDesc),
                    Wb = KernelFacade.PyWb.GetWb(value.InciDesc),
                    Ot = "M",
                    Code1 = "CL",
                    Sheetflag = "1",
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Charge = "1",
                    Autocharge = "0",
                    Suitableflag = "0",
                    Hostrandt = CurrentTime,
                    Duration = 0,
                    Hoscode = "HHG00101",
                    Gg = value.Spec,
                };
                EfContext.Add(addOrderItem);
                addOrderItems.Add(addOrderItem);

                //新增医嘱对应收费项目
                var addOrderToCharge = new Ordertocharge
                {
                    Ordercode = addOrderItem.Ordercode,
                    Ordername = value.InciDesc,
                    Orderflag = "M",
                    Deptid = "ALL",
                    Drcode = addOrderItem.Ordercode,
                    Abc = 1,
                    Dosageday = 1,
                    Drunit = value.BUomDesc,
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Onlyflag = "1",
                    Ftype = "27",
                    Jp = "spd",
                };
                EfContext.Add(addOrderToCharge);
                addOrderToCharges.Add(addOrderToCharge);

                //新增材料关联
                var addAssetBasesub = new SysBasesub
                {
                    Tablename = "assetcode",
                    Itemcode = value.InciCode,
                    Itemname = value.InciDesc,
                    Hoscode = "HHG00101",
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Createdate = CurrentTime,
                    Createuser = "spd",
                    Defaultdept = null,
                    Npl = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Childnpl = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Punits = KernelFacade.TypeConvert.ToDecimalOrZero(value.Rp),
                };
                EfContext.Add(addAssetBasesub);
                addBasesubs.Add(addAssetBasesub);

                //新增医嘱项目关联
                var addOrderItemBasesub = new SysBasesub
                {
                    Tablename = "orderitem",
                    Itemcode = addOrderItem.Ordercode,
                    Itemname = addOrderItem.Ordername,
                    Hoscode = "HHG00101",
                    Useflag = value.UseFlag == "N" ? "0" : "1",
                    Createdate = CurrentTime,
                    Createuser = "spd",
                    Defaultdept = null,
                    Npl = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Childnpl = KernelFacade.TypeConvert.ToDecimalOrZero(value.Sp),
                    Punits = KernelFacade.TypeConvert.ToDecimalOrZero(value.Rp),
                    Zxksdeptlist = deptStr,
                };
                EfContext.Add(addOrderItemBasesub);
                addBasesubs.Add(addOrderItemBasesub);
            }

            //处理医保信息
            SyncYbMatch();
        }

        await EfContext.CommitAsync();

        return new ResultCataLog { Response = new SPC101Response { ReturnCode = 1, ResultContent = "成功" } };

        //TODO：同步门诊 
    }

    public async Task<bool> SyncYbMatch()
    {
        var sql = "usp_yb_match_cl_sync";
        var rtn = await MedicalInsuranceDataContext.ExecuteNonQueryAsync(sql);
        return true;
    }

    /// <summary>
    /// 保存医保信息
    /// </summary>
    /// <param name="code">代码</param>
    /// <param name="name">名称</param>
    /// <param name="ybdm">医保代码</param>
    /// <returns>返回可等待的任务</returns>
    private async Task SaveMedicalInsuranceData(string code, string name, string ybdm)
    {
        //是否回写医保信息
        //是否存在
        var sql = @"
select ID as Id,accessID as AccessId,hiscode as HisCode,hisname as HisName,ybcode as YbCode,ybname as YbName,ypzllb as YpZllb,mzzfbl as MzZfbl,zyzfbl as ZyZfbl,sfdj as Sfdj,shzt as Shzt,
startedate as StarteDate,enddate as EndDate,matchdate as MatchDate,empid as EmpId,sflb as Sflb,histype as HisType,useflag as HisType,istrans as IsTrans 
from YB_Match_Item with(nolock) where histype='M' and accessId=1 and hiscode=@code";
        var ybItems = MedicalInsuranceDataContext.Query<YbMatchItem>(sql, new { code }).ToList();
        bool isFind = false;
        isFind = ybItems.IsNullOrEmpty() == false;
        if (isFind)
        {
            var sqlUpdate = @"
update YB_Match_Item set hisname=@HisName,ybcode=@YbCode,ybname=@YbName
where ID=@Id";
            MedicalInsuranceDataContext.ExecuteNonQuery(sqlUpdate, ybItems);
        }
        else
        {
            var ybData = new YbMatchItem
            {
                Id = 0,
                AccessId = 1,
                HisCode = code,
                HisName = name,
                YbCode = ybdm,
                YbName = name,
                YpZllb = "301",
                MzZfbl = 0,
                ZyZfbl = 0,
                Sfdj = "",
                Shzt = "",
                StarteDate = new DateTime(CurrentTime.AddYears(-1).Year, 1, 1),
                EndDate = new DateTime(CurrentTime.AddYears(2).Year, 12, 31),
                MatchDate = CurrentTime,
                EmpId = Account.Id,
                Sflb = "",
                HisType = "M",
                UseFlag = "1",
                IsTrans = 1,
            };
            var sqlAdd = @"
insert into YB_Match_Item(accessID,hiscode,hisname,ybcode,ybname,ypzllb,mzzfbl,zyzfbl,sfdj,shzt,
startedate,enddate,matchdate,empid,sflb,histype,useflag,istrans)
values(@AccessId,@HisCode,@HisName,@YbCode,@YbName,@YpZllb,@MzZfbl,@ZyZfbl,@Sfdj,@Shzt,
@StarteDate,@EndDate,@MatchDate,@EmpId,@Sflb,@HisType,@UseFlag,@IsTrans)";
            MedicalInsuranceDataContext.ExecuteNonQuery(sqlAdd, ybData);
        }
    }
}
