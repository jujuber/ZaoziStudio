namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 
/// </summary>
[Table("ReportResult_LIS_Xj")]
public sealed class ReportResultLISXj : EqualObject
{
    /// <summary>
    /// 获取或者设置样本号
    /// </summary>
    [MaxLength(50)]
    [Column("ybh", Order = 100)]
    public string Ybh { get; set; }
    /// <summary>
    /// 获取或者设置细菌ID
    /// </summary>
    [MaxLength(50)]
    [Column("jgdm", Order = 101)]
    public string Jgdm { get; set; }
    /// <summary>
    /// 获取或者设置细菌名称
    /// </summary>
    [MaxLength(100)]
    [Column("jgmc", Order = 102)]
    public string Jgmc { get; set; }
    /// <summary>
    /// 获取或者设置 微生物类型0：细菌 1：衣原体 2：支原体
    /// </summary>
    [MaxLength(20)]
    [Column("wswlx", Order = 103)]
    public string Wswlx { get; set; }
    /// <summary>
    /// 获取或者设置细菌数量
    /// </summary>
    [MaxLength(30)]
    [Column("jyjg", Order = 104)]
    public string Jyjg { get; set; }
    /// <summary>
    /// 获取或者设置专家提示
    /// </summary>
    [MaxLength(200)]
    [Column("zjts", Order = 105)]
    public string Zjts { get; set; }
    /// <summary>
    /// 获取或者设置检测日期
    /// </summary>
    [Column("jcsj", Order = 106)]
    public DateTime? Jcsj { get; set; }
    /// <summary>
    /// 获取或者设置微生物评语
    /// </summary>
    [MaxLength(200)]
    [Column("wswpy", Order = 107)]
    public string Wswpy { get; set; }
    /// <summary>
    /// 获取或者设置打印次序
    /// </summary>
    [MaxLength(20)]
    [Column("cx", Order = 108)]
    public string Cx { get; set; }
    /// <summary>
    /// 获取或者设置使用标记 1 使用 0 无效
    /// </summary>
    [MaxLength(2)]
    [Column("useflag", Order = 109)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置申请单号
    /// </summary>
    [MaxLength(100)]
    [Column("sqdh", Order = 110)]
    public string Sqdh { get; set; }
    /// <summary>
    /// 获取或者设置报告单号
    /// </summary>
    [MaxLength(50)]
    [Column("bgdh", Order = 111)]
    public string Bgdh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("ID", Order = 112)]
    public int ID { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield break;
    }
}