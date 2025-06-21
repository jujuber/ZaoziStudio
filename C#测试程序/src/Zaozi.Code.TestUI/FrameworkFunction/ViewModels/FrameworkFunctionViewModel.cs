
using Newtonsoft.Json;
using Synyi.Framework.Kernel;
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
        this.ToIntCommand = new ActionCommand(this.ExecuteToIntCommand);
        this.JsonCommand = new ActionCommand(this.ExecuteJsonCommand);
        this.CalcAge1Command = new ActionCommand(this.ExecuteCalcAge1Command);
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

    public ActionCommand JsonCommand { get; }
    private void ExecuteJsonCommand()
    {
        var strjson = @"{
	            ""code"": -1,
	            ""data"": {
		            ""msg"": ""响应结果: 请检查科室是否维护正确或是否启用![null, null, null, null]""
	            },
	            ""msg"": ""响应结果: 请检查科室是否维护正确或是否启用!""
            }";
        string msg = string.Empty; 
        var remodel = JsonConvert.DeserializeObject<SPIOutputDto<SPI202Output>>(strjson);
        var ss = JsonConvert.SerializeObject(strjson);
        this.OutputText = $"mac地址：{WpfFacade.Computer.MacAddress}";

    }

    public ActionCommand CalcAge1Command { get; }
    private void ExecuteCalcAge1Command()
    {
        var birthdate = KernelFacade.TypeConvert.ToDateTimeOrNow(this.InputText);
        var ageinfo = WpfFacade.Age.CalcAge(birthdate,DateTime.Now);
        this.OutputText += $"year:{ageinfo.Year} month:{ageinfo.Month}  day:{ageinfo.Day}";

        this.OutputText += Environment.NewLine + GetAge1(birthdate);

        var agexx = GetAge(birthdate, DateTime.Now);
        this.OutputText += Environment.NewLine + $"year:{agexx.Year} month:{agexx.Month}  day:{agexx.Day}";



    }

    public static string GetAge1(DateTime _birthday)
    {
        string _Return = "";
        DateTime nowDate = DateTime.Now;
        DateTime birthDate = Convert.ToDateTime(_birthday);
        int totalMonths = nowDate.Month - birthDate.Month + 12 * (nowDate.Year - birthDate.Year);
        DateTime tempDate = birthDate.AddMonths(totalMonths);
        totalMonths = (tempDate > nowDate) ? totalMonths - 1 : totalMonths;
        int _Year = totalMonths / 12;
        int _Month = totalMonths % 12;
        int _Day = int.Parse(Math.Floor((nowDate - birthDate).TotalDays).ToString());
        if (_Year == 0)
        {
            if (_Month == 0)
            {
                if (_Day == 0)
                {
                    _Day = 1;
                }

                _Return = "<AGE>" + _Day.ToString() + "</AGE><AGEUNIT>D</AGEUNIT>";
            }
            else
            {
                _Return = "<AGE>" + _Month.ToString() + "</AGE><AGEUNIT>M</AGEUNIT>";
            }
        }
        else
        {
            _Return = "<AGE>" + _Year.ToString() + "</AGE><AGEUNIT>Y</AGEUNIT>";
        }
        return _Return;
    }

    public static (int Year, int Month, int Day) GetAge(DateTime _birthday, DateTime tDate)
    {
        DateTime nowDate = tDate.Date;
        DateTime birthDate = Convert.ToDateTime(_birthday).Date;
        int totalMonths = nowDate.Month - birthDate.Month + 12 * (nowDate.Year - birthDate.Year);
        DateTime tempDate = birthDate.AddMonths(totalMonths);
        totalMonths = (tempDate > nowDate) ? totalMonths - 1 : totalMonths;
        int _Year = totalMonths / 12;
        int _Month = totalMonths % 12;
        int _Day = int.Parse((nowDate - birthDate).TotalDays.ToString());
        if (_Year == 0)
        {
            if (_Month == 0)
            {
                if (_Day == 0)
                {
                    _Day = 1;
                }
            }
        }
        return (_Year, _Month, _Day);
    }

    public ActionCommand ToIntCommand { get; }
    private void ExecuteToIntCommand()
    {
        decimal _cnt = 0m;
        for (int i = 0; i < 3; i++)
        {
            string many = "2.0000";
            _cnt+= KernelFacade.TypeConvert.ToInt32OrZero(many);
        }  
        this.OutputText = $"{decimal.ToInt32(_cnt)}";
         

        var price = "2.000";
        
        int.TryParse(price, out int outInt1);

        this.OutputText += $" price={outInt1}";

        decimal? ykd200 = null;
        // decimal? ykd20 = "";
        var ykdw = ToDecimalOrZero(ykd200);
        var ykd = KernelFacade.TypeConvert.ToDecimalOrZero(ykd200);

        decimal? ykd2001 = 3232.33m;
        // decimal? ykd20 = "";
        var ykd1w = ToDecimalOrZero(ykd2001);
        var ykd1 = KernelFacade.TypeConvert.ToDecimalOrZero(ykd2001);

        decimal ykd01 = 3232.33m;
        // decimal? ykd20 = "";
        var ykd011w = ToDecimalOrZero(ykd01);
        var ykd011 = KernelFacade.TypeConvert.ToDecimalOrZero(ykd01);

        string jj = "77.01";
        var jjd = ToDecimalOrZero(jj);
    }


    #region decimal
    /// <summary>
    /// 将值转换为浮点数
    /// </summary>
    /// <param name="value">值</param>
    /// <returns>返回值的浮点数</returns>
    public decimal? ToDecimalOrNull(object value)
    {
        decimal? result;
        if (Convert.IsDBNull(value) || value == null)
        {
            result = null;
        }
        else if (value is decimal outDecimal)
        {
            result = outDecimal;
        }
        else if (decimal.TryParse(ToStringOrNull(value), out decimal outDecimal1))
        {
            result = outDecimal1;
        }
        else
        {
            result = null;
        }

        return result;
    }

    /// <summary>
    /// 将值转换为字符串
    /// </summary>
    /// <param name="value">值</param>
    /// <returns>返回值的字符串</returns>
    public static string ToStringOrNull(object value)
    {
        string result;
        if (Convert.IsDBNull(value) || value == null)
        {
            result = null;
        }
        else if (value is string outString)
        {
            result = outString;
        }
        else
        {
            result = Convert.ToString(value);
        }

        return result;
    }
    /// <summary>
    /// 将值转换为浮点数
    /// </summary>
    /// <param name="value">值</param>
    /// <returns>返回值的浮点数</returns>
    public decimal ToDecimalOrZero(object value)
    {
        return ToDecimalOrNull(value) ?? 0m;
    }
    #endregion decimal
    public decimal GetDecimal(object obj)
    {
        decimal result;
        if (obj.ToString() != "")
        {
            result = decimal.Parse(obj.ToString());
        }
        else
        {
            result = 0m;
        }
        return result;
    }
}

public class SPI202Output
{
    public string msg { get; set; }
}
public class SPIOutputDto<T>
{
    public string code { get; set; }

    public string msg { get; set; }
    public T data { get; set; }
}
