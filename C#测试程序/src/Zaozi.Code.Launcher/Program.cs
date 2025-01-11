using Microsoft.Extensions.Hosting;
using Synyi.Framework.Kernel.Modularity;
using Synyi.Framework.Wpf.Hosting;
using Synyi.Framework.Wpf.Security;
using Zaozi.Code.TestUI;

namespace Zaozi.Code.Launcher
{
    /// <summary>
    /// 主程序入口
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// 主程序入口
        /// </summary>
        /// <param name="args">参数</param>
        public static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(p => p.AddBootPluginId(ZaoziConst.Plugins.Workstation).AddBootUserSystem(new UserSystem("APP_TEST", "测试程序", "测试程序")))
                .ConfigureWpf<ModuleCatalog>()
                .Build();
            host.Run();
        }
    }
}