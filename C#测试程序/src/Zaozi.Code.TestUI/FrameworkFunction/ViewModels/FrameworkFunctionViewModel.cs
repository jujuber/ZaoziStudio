
using Synyi.Framework.Wpf.Mvvm;

namespace Zaozi.Code.TestUI.FrameworkFunction.ViewModels;

[Plugin(ZaoziConst.Plugins.FrameworkFunctionView, "框架方法", "框架方法")]
public class FrameworkFunctionViewModel : PluginViewModelBase
{
    protected override Task DoOnNavigatedTo(NavigationContext context)
    {
        return Task.CompletedTask;
    }
    public FrameworkFunctionViewModel()
    {
        this.GetIpCommand = new ActionCommand(this.ExecuteGetIpCommand);
        this.GetMacCommand = new ActionCommand(this.ExecuteGetMacCommand);
    }
    public string InputText { get; set; }
    public string OutputText { get; set; }
    public ActionCommand GetIpCommand { get; }
    private void ExecuteGetIpCommand()
    { 
        this.OutputText = $"ip地址：{WpfFacade.Computer.IpAddress}";
    }
    public ActionCommand GetMacCommand { get; }
    private void ExecuteGetMacCommand()
    {
        this.OutputText = $"mac地址：{WpfFacade.Computer.MacAddress}";

    }
}
