using DryIoc.ImTools;
using Synyi.Framework.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaozi.Code.TestUI.TestAllSingle.ViewModels;
[Plugin(ZaoziConst.Plugins.TestAllSingleView,"综合测试", "综合测试")]
public class TestAllSingleViewModel : PluginViewModelBase
{
    protected override Task DoOnNavigatedTo(NavigationContext context)
    {
        return Task.CompletedTask;
    }

    public TestAllSingleViewModel()
    {
        this.YieldCommand = new ActionCommand(this.ExecuteYieldCommand);
    }

    public string EdtValue { get; set; }
    public ActionCommand YieldCommand { get; }

    private void ExecuteYieldCommand()
    {
        var nums = GetEnumersByyield(10);

        foreach (var item in nums)
        {
            EdtValue += $"{item}{Environment.NewLine}";
        }
    }
    private IEnumerable<int> GetEnumers(int num)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < num; i++)
        {
            result.Add(i);
        }
        return result;
    }
    private IEnumerable<int> GetEnumersByyield(int num)
    {
        for (int i = 0; i < num; i++)
        {
            EdtValue += $"yield{i}{Environment.NewLine}";
            yield return i;
        }
    }
}
