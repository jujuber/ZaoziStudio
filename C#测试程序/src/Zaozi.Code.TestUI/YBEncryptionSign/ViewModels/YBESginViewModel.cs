using Synyi.Framework.Wpf.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaozi.Code.TestUI.YBEncryptionSign.ViewModels
{
    [Plugin(ZaoziConst.Plugins.YBESign, "医保接口加密加签", "医保接口加密加签Demo")]
    public class YBESginViewModel : PluginViewModelBase
    {
        protected override Task DoOnNavigatedTo(NavigationContext context)
        {
            return Task.CompletedTask;
        }
    }
}
