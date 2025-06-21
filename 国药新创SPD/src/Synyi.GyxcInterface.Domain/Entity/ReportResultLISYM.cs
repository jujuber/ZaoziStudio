namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 
/// </summary>
[Table("ReportResult_LIS_YM")]
public sealed class ReportResultLISYM : EqualObject
{
    /// <summary>
    /// 获取或者设置样本号
    /// </summary>
    [MaxLength(50)]
    [Column("ybh", Order = 100)]
    public string Ybh { get; set; }
    /// <summary>
    /// 获取或者设置药敏ID
    /// </summary>
    [MaxLength(20)]
    [Column("jgdm", Order = 101)]
    public string Jgdm { get; set; }
    /// <summary>
    /// 获取或者设置药敏名称
    /// </summary>
    [MaxLength(50)]
    [Column("jgmc", Order = 102)]
    public string Jgmc { get; set; }
    /// <summary>
    /// 获取或者设置细菌ID
    /// </summary>
    [MaxLength(20)]
    [Column("xjid", Order = 103)]
    public string Xjid { get; set; }
    /// <summary>
    /// 获取或者设置细菌名称
    /// </summary>
    [MaxLength(50)]
    [Column("xjmc", Order = 104)]
    public string Xjmc { get; set; }
    /// <summary>
    /// 获取或者设置微生物类型 0：细菌 1：衣原体 2：支原体 3：真菌
    /// </summary>
    [MaxLength(10)]
    [Column("wswlx", Order = 105)]
    public string Wswlx { get; set; }
    /// <summary>
    /// 获取或者设置KB结果
    /// </summary>
    [MaxLength(200)]
    [Column("kb", Order = 106)]
    public string Kb { get; set; }
    /// <summary>
    /// 获取或者设置MIC结果
    /// </summary>
    [MaxLength(200)]
    [Column("mic", Order = 107)]
    public string Mic { get; set; }
    /// <summary>
    /// 获取或者设置ETEST结果
    /// </summary>
    [MaxLength(200)]
    [Column("etest", Order = 108)]
    public string Etest { get; set; }
    /// <summary>
    /// 获取或者设置耐药性结果 R：耐药S：敏感 I：中敏+：阳性-：阴性
    /// </summary>
    [MaxLength(2)]
    [Column("nyx", Order = 109)]
    public string Nyx { get; set; }
    /// <summary>
    /// 获取或者设置检测方法 1：mic法 2：kb法3 ：etest
    /// </summary>
    [MaxLength(10)]
    [Column("jcff", Order = 110)]
    public string Jcff { get; set; }
    /// <summary>
    /// 获取或者设置检测日期
    /// </summary>
    [Column("jcsj", Order = 111)]
    public DateTime? Jcsj { get; set; }
    /// <summary>
    /// 获取或者设置打印次序
    /// </summary>
    [MaxLength(2)]
    [Column("cx", Order = 112)]
    public string Cx { get; set; }
    /// <summary>
    /// 获取或者设置使用标记 1 使用 0 无效
    /// </summary>
    [MaxLength(2)]
    [Column("useflag", Order = 113)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置申请单号
    /// </summary>
    [MaxLength(100)]
    [Column("sqdh", Order = 114)]
    public string Sqdh { get; set; }
    /// <summary>
    /// 获取或者设置报告单号
    /// </summary>
    [MaxLength(50)]
    [Column("bgdh", Order = 115)]
    public string Bgdh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("ID", Order = 116)]
    public int ID { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("jyjg", Order = 117)]
    public string Jyjg { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("zjts", Order = 118)]
    public byte[] Zjts { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield break;
    }
}