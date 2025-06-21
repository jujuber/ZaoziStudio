using Synyi.Framework.Application.Edit;
using Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;
using Synyi.GyxcInterface.Application.Abstractions.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synyi.Framework.Application;
using Synyi.Framework.Domain;
using Synyi.GyxcInterface.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Mapster;

namespace Synyi.GyxcInterface.Application.Basics;
internal class SynIncscDataService : EditApplicationServiceBase, ISynIncscDataService
{
    public async Task<bool> SynIncscData(InputIncscsDTO data)
    {
        if (data == null)
        {
            throw new ApplicationServiceException("对象不能为空");
        }
        var ids = data.Datas.Select(r => r.IncscCode);

        var olds = await this.EfContext
            .Query<GyxcSpdIncsc>(p => ids.Contains(p.IncscCode))
            .ToListAsync();

        var datas = data.Datas;

        var add = new List<GyxcSpdIncsc>();
        var modify = new List<GyxcSpdIncsc>();
        foreach (var item in datas)
        {
            var old = olds.FirstOrDefault(p => p.IncscCode == item.IncscCode);
            if (old == null)
            {
                var dt = item.Adapt<GyxcSpdIncsc>();
                add.Add(dt); 
            }
            else
            {

                item.Adapt(old); 
                modify.Add(old); 
                olds.Remove(old);
            } 
        }

        await this.EfContext
            .Add(add)
            .Modify(modify)
            .Delete(olds)
            .CommitAsync();

        return true;
    }
}
