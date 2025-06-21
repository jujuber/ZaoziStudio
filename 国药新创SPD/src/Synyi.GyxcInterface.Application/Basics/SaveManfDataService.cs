using Microsoft.EntityFrameworkCore;
using Synyi.Framework.Application.Edit;
using Synyi.Framework.Data;
using Synyi.Framework.Kernel;
using Synyi.GyxcInterface.Application.Abstractions.Basics;
using Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;
using Synyi.GyxcInterface.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Application.Basics;
public class SaveManfDataService : EditApplicationServiceBase, ISaveManfDataService
{
    /// <summary>
    /// 数据访问上下文
    /// </summary>
    private IDataContext dataContext;
    /// <summary>
    /// 构造函数
    /// </summary>
    public SaveManfDataService()
    {
        this.dataContext = KernelFacade.IocResolver.Resolve<IDataManager>().GetDataContext("Hill");
    }
    /// <summary>
    /// 生成键
    /// </summary>
    /// <param name="rdn">键代码</param>
    /// <param name="count">数量</param>
    /// <returns>返回生成的最小的主键值</returns>
    protected int GenerateMinId(int rdn, int count)
    {

        if (count < 1) throw new ArgumentException("数量不能小于1！");

        int minValue = 0;

        DataParameter output_id = new DataParameter("@id", minValue, DataParameterType.Int32, System.Data.ParameterDirection.Output);
        DataParameter output_flag = new DataParameter("@flag", minValue, DataParameterType.Int32, System.Data.ParameterDirection.Output);

        this.dataContext.ExecuteNonQuery("hissysrdn_getRdnMany", new List<DataParameter>
        {
                        new DataParameter("@rdn",rdn, DataParameterType.String),
                        new DataParameter("@count",count, DataParameterType.Int32),
                        output_id,
                        output_flag
                    }, System.Data.CommandType.StoredProcedure);
        minValue = (int)output_id.Value;

        return minValue;
    }
    public async Task<bool> SaveManfData(List<ManfDTO> data)
    {
        var thirdIds = data.Select(p => p.ManfCode).ToList();
        var olds = await this.EfContext.Query<Code217>(p => thirdIds.Contains(p.ThirdId)).ToListAsync();
        foreach (var value in data)
        {
            var old = olds.FirstOrDefault(p => p.ThirdId == value.ManfCode);
            if (old == null)
            {
                var add = new Code217();
                add.Manfcode = this.GenerateMinId(3, 1);
                add.Manf = value.ManfDesc;
                add.Py = KernelFacade.PyWb.GetPy(value.ManfCode);
                add.Useflag = value.UseFlag == "Y" ? "1" : "0";
                add.Area = value.Address;
                add.Mark = value.Tel;
                add.Importflag = "0";
                add.Hoscode = "0";
                add.ThirdId = value.ManfCode;
                add.DrugFlag = "0";
                add.AssetcodeFlag = "1";

                this.EfContext.Add(add);
            }
            else
            {
                var modify = old;
                modify.Manf = value.ManfDesc;
                modify.Py = KernelFacade.PyWb.GetPy(value.ManfCode);
                modify.Useflag = value.UseFlag == "Y" ? "1" : "0";
                modify.Area = value.Address;
                modify.Mark = value.Tel;
                modify.DrugFlag = "0";
                modify.AssetcodeFlag = "1";
                this.EfContext.Modify(modify);
            }
        }
        await this.EfContext.CommitAsync();
        return true;
    }
}
