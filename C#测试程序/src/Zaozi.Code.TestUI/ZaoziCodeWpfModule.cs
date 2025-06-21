using Synyi.Framework.Wpf.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTest.ViewModels;
using WebApiTest.Views;
using Zaozi.Code.TestUI.Crypto.ViewModels;
using Zaozi.Code.TestUI.Crypto.Views;
using Zaozi.Code.TestUI.FrameworkFunction.ViewModels;
using Zaozi.Code.TestUI.FrameworkFunction.Views;
using Zaozi.Code.TestUI.GetIPS.ViewModels;
using Zaozi.Code.TestUI.GetIPS.Views;
using Zaozi.Code.TestUI.TestAllSingle.ViewModels;
using Zaozi.Code.TestUI.TestAllSingle.Views;
using Zaozi.Code.TestUI.Workstation.ViewModels;
using Zaozi.Code.TestUI.Workstation.Views;
using Zaozi.Code.TestUI.XmlToObj.ViewModels;
using Zaozi.Code.TestUI.XmlToObj.Views;
using Zaozi.Code.TestUI.YBEncryptionSign.ViewModels;
using Zaozi.Code.TestUI.YBEncryptionSign.Views;

namespace Zaozi.Code.TestUI;
public class ZaoziCodeWpfModule : WpfModuleBase
{
    protected override void RegisterPluginViewModel(PluginRegistrar registrar)
    {
        registrar.Register<WorkstationView, WorkstationViewModel>();
        registrar.Register<GetIPView, GetIPViewModel>();
        registrar.Register<YBESginView, YBESginViewModel>();
        registrar.Register<XmlToObjView, XmlToObjViewModel>();
        registrar.Register<CryptoView, CryptoViewModel>();
        registrar.Register<FrameworkFunctionView, FrameworkFunctionViewModel>();
        registrar.Register<TestAllSingleView, TestAllSingleViewModel>();
        registrar.Register<WebApiTestView, WebApiTestViewModel>();
    }
}
