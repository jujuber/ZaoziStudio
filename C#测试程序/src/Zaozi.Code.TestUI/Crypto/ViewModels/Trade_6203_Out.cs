using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaozi.Code.TestUI.Crypto.ViewModels;
/// <summary>
/// 移动医保退费出参
/// </summary>
public class Trade_6203_Out
{
    /// <summary>
    /// 医保退费出参
    /// </summary>
    public Trade6203OutData data { get; set; }
}
/// <summary>
/// 医保退费出参实体
/// </summary>

public class Trade6203OutData
{
    /// <summary>
    /// 1.结算中心流水号
    /// </summary>
    public string refdSn { get; set; }
    /// <summary>
    /// 2.医保退费流水号  现金退费不返回
    /// </summary>
    public string hiFefdSn { get; set; }
    /// <summary>
    /// 3.医保退费日期   现金退费不返回 
    /// </summary>
    public string hiTrnsDate { get; set; }
    /// <summary>
    /// 4.医保退费时间  现金退费不返回
    /// </summary>
    public string hiTrnsTime { get; set; }
    /// <summary>
    /// 5.退费状态  SUCC:成功  FAIL:失败  EXP:异常，存在退医保及自费时有可能出现这个状态
    /// </summary>
    public string refStatus { get; set; }
    /// <summary>
    /// 6.医保扩展数据  根据各地方医保要求传不同数据内容 
    /// </summary>
    public object extData { get; set; }
}
