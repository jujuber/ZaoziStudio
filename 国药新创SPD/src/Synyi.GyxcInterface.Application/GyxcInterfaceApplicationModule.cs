using Synyi.Framework.Application.Modularity;
using Synyi.Framework.Kernel.Modularity;
using Synyi.GyxcInterface.Application.Abstractions.Basics;
using Synyi.GyxcInterface.Application.Abstractions.Catalog;
using Synyi.GyxcInterface.Application.Basics;
using Synyi.GyxcInterface.Application.Catalog;
using Synyi.GyxcInterface.Domain.EntityFramework;

namespace Synyi.GyxcInterface.Application;
/// <summary>
/// 应用层模块
/// </summary>
[ModuleDependency(typeof(GyxcInterfaceEfModule))]
public class GyxcInterfaceApplicationModule : ApplicationModuleBase
{
    protected override void RegisterApplicationService(ApplicationRegistrar registrar)
    {
        registrar.Register<IBasicService, BasicService>();
        registrar.Register<ISynIncscDataService, SynIncscDataService>();
        registrar.Register<ISaveVendorDataService, SaveVendorDataService>();
        registrar.Register<ISaveManfDataService, SaveManfDataService>();
        registrar.Register<IMaterialCatalogService, MaterialCatalogService>();
    }
}
