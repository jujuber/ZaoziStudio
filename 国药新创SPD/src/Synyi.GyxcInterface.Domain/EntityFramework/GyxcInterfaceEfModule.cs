using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Domain.EntityFramework;
/// <summary>
/// EF模块
/// </summary>
public sealed class GyxcInterfaceEfModule : EfModuleBase
{
    /// <summary>
    /// 注册实体框架提供程序
    /// </summary>
    /// <param name="registrar">实体框架提供程序注册器</param>
    protected override void RegisterEfProvider(EfProviderRegistrar registrar)
    {
        registrar.Register<EfProvider>(HisV1Const.ModuleName);
    }
}
