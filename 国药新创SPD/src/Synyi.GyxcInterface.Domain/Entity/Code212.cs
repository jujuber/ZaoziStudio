namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 频度
/// </summary>
[Table("code212")]
[PrimaryKey(nameof(Code))]
public sealed class Code212 : EqualObject
{
    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [MaxLength(8)]
    [Required]
    [Column("code", Order = 100)]
    public string Code { get; set; }
    /// <summary>
    /// 获取或者设置频度
    /// </summary>
    [MaxLength(100)]
    [Column("remark", Order = 101)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置周期
    /// </summary>
    [Column("peried", Order = 102)]
    public int? Peried { get; set; }
    /// <summary>
    /// 获取或者设置执行次数
    /// </summary>
    [Column("many", Order = 103)]
    public int? Many { get; set; }
    /// <summary>
    /// 获取或者设置时间点
    /// </summary>
    [MaxLength(250)]
    [Column("attime", Order = 104)]
    public string Attime { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 105)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置药品用
    /// </summary>
    [MaxLength(1)]
    [Column("drugflag", Order = 106)]
    public string Drugflag { get; set; }
    /// <summary>
    /// 获取或者设置每日执行次数
    /// </summary>
    [Precision(10, 2)]
    [Column("daycount", Order = 107)]
    public decimal? Daycount { get; set; }
    /// <summary>
    /// 获取或者设置药房间隔
    /// </summary>
    [Precision(10, 2)]
    [Column("pharmDistance", Order = 108)]
    public decimal? PharmDistance { get; set; }
    /// <summary>
    /// 获取或者设置药房每日执行次数
    /// </summary>
    [Precision(10, 2)]
    [Column("pharmDayCount", Order = 109)]
    public decimal? PharmDayCount { get; set; }
    /// <summary>
    /// 获取或者设置护士执行时间点
    /// </summary>
    [MaxLength(200)]
    [Column("NurseDoTimeList", Order = 110)]
    public string NurseDoTimeList { get; set; }
    /// <summary>
    /// 获取或者设置药房执行时间点（TAB）
    /// </summary>
    [MaxLength(200)]
    [Column("pharmTABDoTimeList", Order = 111)]
    public string PharmTABDoTimeList { get; set; }
    /// <summary>
    /// 获取或者设置药房时间点
    /// </summary>
    [MaxLength(200)]
    [Column("pharmPoint", Order = 112)]
    public string PharmPoint { get; set; }
    /// <summary>
    /// 获取或者设置药房执行时间点（IVG）
    /// </summary>
    [MaxLength(200)]
    [Column("pharmIVGDoTimelist", Order = 113)]
    public string PharmIVGDoTimelist { get; set; }
    /// <summary>
    /// 获取或者设置药房执行时间点（INJ）
    /// </summary>
    [MaxLength(200)]
    [Column("pharmINJDoTimelist", Order = 114)]
    public string PharmINJDoTimelist { get; set; }
    /// <summary>
    /// 获取或者设置护士执行时间点（TAB）
    /// </summary>
    [MaxLength(200)]
    [Column("nurseTABDoTimeList", Order = 115)]
    public string NurseTABDoTimeList { get; set; }
    /// <summary>
    /// 获取或者设置药房时间点（IV）
    /// </summary>
    [MaxLength(200)]
    [Column("pharmIVPoint", Order = 116)]
    public string PharmIVPoint { get; set; }
    /// <summary>
    /// 获取或者设置护士执行时间点（IV）
    /// </summary>
    [MaxLength(200)]
    [Column("NurseIVDoTimeList", Order = 117)]
    public string NurseIVDoTimeList { get; set; }
    /// <summary>
    /// 获取或者设置是否按周为单位
    /// </summary>
    [MaxLength(1)]
    [Column("ISWeek", Order = 118)]
    public string ISWeek { get; set; }
    /// <summary>
    /// 获取或者设置每周执行日期点
    /// </summary>
    [MaxLength(200)]
    [Column("atday", Order = 119)]
    public string Atday { get; set; }
    /// <summary>
    /// 获取或者设置适用用法
    /// </summary>
    [MaxLength(200)]
    [Column("code211", Order = 120)]
    public string Code211 { get; set; }
    /// <summary>
    /// 获取或者设置用法时间
    /// </summary>
    [MaxLength(200)]
    [Column("code211time", Order = 121)]
    public string Code211time { get; set; }
    /// <summary>
    /// 获取或者设置转化名称
    /// </summary>
    [MaxLength(50)]
    [Column("convertname", Order = 122)]
    public string Convertname { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 123)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(20)]
    [Column("py", Order = 124)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置排序
    /// </summary>
    [Column("sort", Order = 125)]
    public int? Sort { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }
}