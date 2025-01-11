using Synyi.Framework.Wpf;
using Synyi.Framework.Wpf.Mvvm;
using Synyi.Framework.Wpf.Notices;
using Synyi.Framework.Wpf.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Zaozi.Code.TestUI.Workstation.ViewModels;
/// <summary>
/// 测试程序主程序
/// </summary>
[Plugin(ZaoziConst.Plugins.Workstation, "测试程序主程序", "测试程序主程序")]
public class WorkstationViewModel : PluginViewModelBase
{
    protected override Task DoOnNavigatedTo(NavigationContext context)
    {
        if (this.ActiveCount == 1)
        {
            this.LeftMenuList = new List<Menu2ViewModel>
            {
                this.Create(ZaoziConst.Plugins.TestAllSingleView,"综合测试","&#xe7d4;"),
                this.Create(ZaoziConst.Plugins.AppGetIP,"获取ip地址","&#xe852;"),
                this.Create(ZaoziConst.Plugins.YBESign,"医保加密加签","&#xe7d4;"),
                this.Create(ZaoziConst.Plugins.XmlToObjView,"Xml转换为对象","&#xe7d4;"),
                this.Create(ZaoziConst.Plugins.CryptoView,"加解密","&#xe7d4;"),
                this.Create(ZaoziConst.Plugins.FrameworkFunctionView,"框架方法","&#xe7d4;"),
            };
        } 
        return Task.CompletedTask;
    }

    /// <summary>
    /// 在属性值更改时发生
    /// </summary>
    /// <param name="propertyName">事件数据</param>
    /// <returns>返回可等待任务</returns>
    protected override async Task ExecutePropertyChanged(string propertyName)
    {
        switch (propertyName)
        {
            case nameof(this.CurrentLeftMenu):
                if (this.CurrentLeftMenu != null)
                {
                    WpfFacade.Plugin.Navigate(ZaoziConst.MainRegion, this.CurrentLeftMenu.Url);
                }
                break;
        }

        await base.ExecutePropertyChanged(propertyName);
    }

    public WorkstationViewModel()
    {
        this.CloseCommand = new ActionCommand<DependencyObject>(this.ExecuteCloseCommand);
        this.MinimizeCommand = new ActionCommand<DependencyObject>(this.ExecuteMinimizeCommand);
        this.CaptionCommand = new ActionCommand<MouseButtonEventArgs>(this.ExecuteCaptionCommand);
    }

    /// <summary>
    /// 左侧菜单列表
    /// </summary>
    public List<Menu2ViewModel> LeftMenuList { get; set; }
    /// <summary>
    /// 当前左侧菜单
    /// </summary>
    public Menu2ViewModel CurrentLeftMenu { get; set; }
    /// <summary>
    /// 创建菜单
    /// </summary>
    /// <param name="pluginId">插件代码</param>
    /// <param name="name">名称</param>
    /// <param name="icon">图标</param>
    /// <returns>返回菜单</returns>
    private Menu2ViewModel Create(string pluginId, string name, string icon)
    {
        var result = new Menu2ViewModel
        {
            Id = pluginId,
            Name = name,
            Url = pluginId,
            IconType = MenuIconType.IconFont,
            Icon = icon,
        };

        return result;
    }

    /// <summary>
    /// 获取窗口关闭命令
    /// </summary>
    public ActionCommand<DependencyObject> CloseCommand { get; }
    /// <summary>
    /// 执行窗口关闭命令
    /// </summary>
    /// <param name="dependencyObject">依赖对象</param>
    private void ExecuteCloseCommand(DependencyObject dependencyObject)
    {
        var window = this.Context.GetWindow(dependencyObject);
        if (WpfFacade.Notice.ShowDialogBox(DialogType.Question, "确定退出系统吗？", DialogButton.OKCancel) == DialogResult.OK)
        {
            window.Close();
        }
    }

    /// <summary>
    /// 获取最小化命令
    /// </summary>
    public ActionCommand<DependencyObject> MinimizeCommand { get; }
    /// <summary>
    /// 执行最小化命令
    /// </summary>
    /// <param name="dependencyObject">依赖对象</param>
    private void ExecuteMinimizeCommand(DependencyObject dependencyObject)
    {
        var window = this.Context.GetWindow(dependencyObject);
        window.WindowState = WindowState.Minimized;
    }

    /// <summary>
    /// 获取窗口标题操作命令
    /// </summary>
    public ActionCommand<MouseButtonEventArgs> CaptionCommand { get; }
    /// <summary>
    /// 执行窗口标题操作命令
    /// </summary>
    /// <param name="e">依赖对象</param>
    private void ExecuteCaptionCommand(MouseButtonEventArgs e)
    {
        var window = this.Context.GetWindow(e.OriginalSource as DependencyObject);
        if (e.ClickCount > 1)
        {
            window.WindowState = window.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }
        else if (e.ChangedButton == MouseButton.Left)
        {
            window.DragMove();
        }
    }
}
