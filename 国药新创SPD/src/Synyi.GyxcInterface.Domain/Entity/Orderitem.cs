namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医嘱项目表
/// </summary>
[Table("orderitem")]
[PrimaryKey(nameof(Ordercode))]
public sealed class Orderitem : EqualObject
{
    /// <summary>
    /// 获取或者设置医嘱代码
    /// </summary>
    [MaxLength(200)]
    [Required]
    [Column("ordercode", Order = 100)]
    public string Ordercode { get; set; }
    /// <summary>
    /// 获取或者设置医嘱名称
    /// </summary>
    [MaxLength(200)]
    [Column("ordername", Order = 101)]
    public string Ordername { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(3)]
    [Column("ordertype", Order = 102)]
    public string Ordertype { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(250)]
    [Column("py", Order = 103)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 104)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置归类/部位
    /// </summary>
    [MaxLength(10)]
    [Column("code1", Order = 105)]
    public string Code1 { get; set; }
    /// <summary>
    /// 获取或者设置大分类
    /// </summary>
    [MaxLength(3)]
    [Column("ot", Order = 106)]
    public string Ot { get; set; }
    /// <summary>
    /// 获取或者设置收费
    /// </summary>
    [MaxLength(1)]
    [Column("charge", Order = 107)]
    public string Charge { get; set; }
    /// <summary>
    /// 获取或者设置自动收费
    /// </summary>
    [MaxLength(1)]
    [Column("autocharge", Order = 108)]
    public string Autocharge { get; set; }
    /// <summary>
    /// 获取或者设置主类标志
    /// </summary>
    [MaxLength(1)]
    [Column("sheetflag", Order = 109)]
    public string Sheetflag { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(200)]
    [Column("remark", Order = 110)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置公共关联
    /// </summary>
    [MaxLength(1)]
    [Column("comflag", Order = 111)]
    public string Comflag { get; set; }
    /// <summary>
    /// 获取或者设置默认部门
    /// </summary>
    [MaxLength(20)]
    [Column("defaultdept", Order = 112)]
    public string Defaultdept { get; set; }
    /// <summary>
    /// 获取或者设置项目增加
    /// </summary>
    [MaxLength(40)]
    [Column("itemplus", Order = 113)]
    public string Itemplus { get; set; }
    /// <summary>
    /// 获取或者设置申请归类
    /// </summary>
    [MaxLength(20)]
    [Column("sheetonly", Order = 114)]
    public string Sheetonly { get; set; }
    /// <summary>
    /// 获取或者设置关联代码
    /// </summary>
    [MaxLength(18)]
    [Column("relacode", Order = 115)]
    public string Relacode { get; set; }
    /// <summary>
    /// 获取或者设置打印归类
    /// </summary>
    [MaxLength(4)]
    [Column("printgroup", Order = 116)]
    public string Printgroup { get; set; }
    /// <summary>
    /// 获取或者设置显示顺序
    /// </summary>
    [Column("showseries", Order = 117)]
    public int? Showseries { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("labprofileflag", Order = 118)]
    public string Labprofileflag { get; set; }
    /// <summary>
    /// 获取或者设置消息
    /// </summary>
    [MaxLength(40)]
    [Column("messagestring", Order = 119)]
    public string Messagestring { get; set; }
    /// <summary>
    /// 获取或者设置医嘱名称1
    /// </summary>
    [MaxLength(100)]
    [Column("ordernamef", Order = 120)]
    public string Ordernamef { get; set; }
    /// <summary>
    /// 获取或者设置唯一标志
    /// </summary>
    [MaxLength(1)]
    [Column("onlyflag", Order = 121)]
    public string Onlyflag { get; set; }
    /// <summary>
    /// 获取或者设置频次
    /// </summary>
    [MaxLength(8)]
    [Column("frequency", Order = 122)]
    public string Frequency { get; set; }
    /// <summary>
    /// 获取或者设置医嘱诊断码
    /// </summary>
    [MaxLength(18)]
    [Column("pcode", Order = 123)]
    public string Pcode { get; set; }
    /// <summary>
    /// 获取或者设置组号
    /// </summary>
    [MaxLength(18)]
    [Column("teamid", Order = 124)]
    public string Teamid { get; set; }
    /// <summary>
    /// 获取或者设置默认效期
    /// </summary>
    [Column("duration", Order = 125)]
    public int? Duration { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(10)]
    [Column("unit", Order = 126)]
    public string Unit { get; set; }
    /// <summary>
    /// 获取或者设置连接标志
    /// </summary>
    [MaxLength(1)]
    [Column("internationFlag", Order = 127)]
    public string InternationFlag { get; set; }
    /// <summary>
    /// 获取或者设置cad标志
    /// </summary>
    [MaxLength(1)]
    [Column("cadflag", Order = 128)]
    public string Cadflag { get; set; }
    /// <summary>
    /// 获取或者设置增加标志
    /// </summary>
    [MaxLength(1)]
    [Column("additionflag", Order = 129)]
    public string Additionflag { get; set; }
    /// <summary>
    /// 获取或者设置设备代码
    /// </summary>
    [MaxLength(10)]
    [Column("devicecode", Order = 130)]
    public string Devicecode { get; set; }
    /// <summary>
    /// 获取或者设置执行院区
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 131)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置同步日期
    /// </summary>
    [Column("hostrandt", Order = 132)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置同步标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 133)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 134)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置收集标志
    /// </summary>
    [MaxLength(1)]
    [Column("collectflag", Order = 135)]
    public string Collectflag { get; set; }
    /// <summary>
    /// 获取或者设置适配标志
    /// </summary>
    [MaxLength(1)]
    [Column("suitableflag", Order = 136)]
    public string Suitableflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("pstime", Order = 137)]
    public int? Pstime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("wb", Order = 138)]
    public string Wb { get; set; }
    /// <summary>
    /// 获取或者设置自由收费标志
    /// </summary>
    [MaxLength(1)]
    [Column("freeflag", Order = 139)]
    public string Freeflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("CentrumNum", Order = 140)]
    public int? CentrumNum { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("code2", Order = 141)]
    public string Code2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("freecode", Order = 142)]
    public string Freecode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("sunit", Order = 143)]
    public string Sunit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("partoperations", Order = 144)]
    public string Partoperations { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("advicesex", Order = 145)]
    public string Advicesex { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("lockflag", Order = 146)]
    public string Lockflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("zfflag", Order = 147)]
    public string Zfflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("bacterialculture", Order = 148)]
    public string Bacterialculture { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [String256]
    [Column("gg", Order = 149)]
    public string Gg { get; set; }
    /// <summary>
    /// 获取或者设置单位系数
    /// </summary>
    [Precision(10, 2)]
    [Column("unitxs", Order = 150)]
    public decimal? Unitxs { get; set; }
    /// <summary>
    /// 获取或者设置血制品代码
    /// </summary>
    [String32]
    [Column("xzpdm", Order = 151)]
    public string Xzpdm { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Ordercode;
    }
}