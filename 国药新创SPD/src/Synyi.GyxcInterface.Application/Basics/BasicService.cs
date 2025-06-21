using Mapster;
using Microsoft.EntityFrameworkCore;
using Synyi.Framework.Application.Edit;
using Synyi.GyxcInterface.Application.Abstractions.Basics;
using Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;
using Synyi.GyxcInterface.Domain.Entity;

namespace Synyi.GyxcInterface.Application.Basics;
internal class BasicService :  EditApplicationServiceBase<string, Code217DTO>, IBasicService
{

    public async Task<List<Code217DTO>> GetDicts(GetInputDTO value)
    {
        int id = int.Parse(value.Code);
        var data = await this.EfContext.Query<Code217>(p => p.Manfcode == id).ToListAsync();
        return data.Adapt<List<Code217DTO>>();
    }

    protected override Task<Code217DTO> DoCreate()
    {
        throw new NotImplementedException();
    }

    protected override Task<Code217DTO> DoGet(string id)
    {
        throw new NotImplementedException();
    }

    protected override Task<string> DoSave(Code217DTO value)
    {
        throw new NotImplementedException();
    }
}
