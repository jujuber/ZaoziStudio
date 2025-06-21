using Synyi.GyxcInterface.Application;

namespace Synyi.GyxcInterface.WebApi.Launcher;

/// <summary>
/// 模块目录
/// </summary>
public class ModuleCatalog : ModuleCatalogBase
{
    /// <summary>
    /// 创建目录信息集合
    /// </summary>
    /// <returns>返回目录信息集合</returns>
    protected override IEnumerable<ModuleInfo> CreateModules()
    { 
        yield return this.CreateModule<GyxcInterfaceApplicationModule>();
    }
}