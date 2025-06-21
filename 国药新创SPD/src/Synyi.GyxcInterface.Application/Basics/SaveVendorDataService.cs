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
public class SaveVendorDataService : EditApplicationServiceBase, ISaveVendorDataService
{
    /// <summary>
    /// 数据访问上下文
    /// </summary>
    private IDataContext dataContext;
    /// <summary>
    /// 构造函数
    /// </summary>
    public SaveVendorDataService()
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
    public async Task<bool> SaveVendorData(List<VendorDTO> data)
    {
        var thirdIds = data.Select(p => p.VenCode).ToList();

        var olds = await this.EfContext.Query<Code216>(p => thirdIds.Contains(p.ThirdId)).ToListAsync();

        foreach (var value in data)
        {
            var old = olds.FirstOrDefault(p => p.ThirdId == value.VenCode);
            if (old == null)
            {
                var add = new Code216();
                add.Rtn = this.GenerateMinId(4, 1);
                add.Company = value.VenDesc;
                add.Py = KernelFacade.PyWb.GetPy(value.VenDesc);
                add.Lxdh = value.Tel;
                add.Dz = value.Address;
                add.Bz = value.Abbrev;
                add.Useflag = value.UseFlag == "Y" ? "1" : "0"; 
                add.Hoscode = "0";
                add.ThirdId = value.VenCode;
                add.Lb = 2; 

                this.EfContext.Add(add);
            }
            else
            {
                var modify = old;
                modify.Company = value.VenDesc;
                modify.Py = KernelFacade.PyWb.GetPy(value.VenDesc); ;
                modify.Lxdh = value.Tel;
                modify.Dz = value.Address;
                modify.Bz = value.Abbrev;
                modify.Useflag = value.UseFlag == "Y" ? "1" : "0";
                modify.Lb = 2; 
                this.EfContext.Modify(modify);
            }
        }
        await this.EfContext.CommitAsync();

        return true;
    }
}
