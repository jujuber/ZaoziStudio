using Synyi.Framework.Application;
using Synyi.Framework.Application.Edit;
using Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;

namespace Synyi.GyxcInterface.Application.Abstractions.Basics;
public interface IBasicService: IEditApplicationService<string, Code217DTO>
{
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    Task<List<Code217DTO>> GetDicts(GetInputDTO value);
}
