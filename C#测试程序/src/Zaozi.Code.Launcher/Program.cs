using Microsoft.Extensions.Hosting;
using Synyi.Framework.Kernel.Modularity;
using Synyi.Framework.Wpf.Hosting;
using Synyi.Framework.Wpf.Security;
using Zaozi.Code.TestUI;

namespace Zaozi.Code.Launcher
{
    /// <summary>
    /// ���������
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// ���������
        /// </summary>
        /// <param name="args">����</param>
        public static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(p => p.AddBootPluginId(ZaoziConst.Plugins.Workstation).AddBootUserSystem(new UserSystem("APP_TEST", "���Գ���", "���Գ���")))
                .ConfigureWpf<ModuleCatalog>()
                .Build();
            host.Run();
        }
    }
}