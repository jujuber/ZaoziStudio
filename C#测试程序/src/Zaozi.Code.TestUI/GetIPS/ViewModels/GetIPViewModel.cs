using Synyi.Framework.Wpf.Mvvm;
using Synyi.Framework.Wpf.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Zaozi.Code.TestUI.GetIPS.ViewModels;

[Plugin(ZaoziConst.Plugins.AppGetIP, "获取IP", "获取IP")]
public class GetIPViewModel : PluginViewModelBase
{
    protected override Task DoOnNavigatedTo(NavigationContext context)
    {
        return Task.CompletedTask;
    }
    public GetIPViewModel()
    {
        this.GetIp1Command = new ActionCommand(this.ExecuteGetIp1Command);
    }
    public string TxtIp1 { get; set; }

    public ActionCommand GetIp1Command { get; set; }

    private void ExecuteGetIp1Command()
    {
        string hostName = Dns.GetHostName();
        IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
        IPAddress[] addr = ipEntry.AddressList;
        var data = addr.Where(r=>r.AddressFamily==System.Net.Sockets.AddressFamily.InterNetwork).ToList();

        foreach (var item in data)
        {
            TxtIp1 += item.ToString() + " ; ";
        }
    }
}

