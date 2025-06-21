namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 
/// </summary>
[Table("ReportResult_LIS_WSW")]
public sealed class ReportResultLISWSW : EqualObject
{
    /// <summary>
    /// 获取或者设置样本号
    /// </summary>
    [MaxLength(50)]
    [Column("ybh", Order = 100)]
    public string Ybh { get; set; }
    /// <summary>
    /// 获取或者设置检验项目编码
    /// </summary>
    [MaxLength(50)]
    [Column("jgdm", Order = 101)]
    public string Jgdm { get; set; }
    /// <summary>
    /// 获取或者设置项目名称
    /// </summary>
    [MaxLength(50)]
    [Column("jgmc", Order = 102)]
    public string Jgmc { get; set; }
    /// <summary>
    /// 获取或者设置培养结果
    /// </summary>
    [MaxLength(200)]
    [Column("jyjg", Order = 103)]
    public string Jyjg { get; set; }
    /// <summary>
    /// 获取或者设置0：阴性 1：阳性 2：一种菌 3：两种菌 4：三种菌
    /// </summary>
    [MaxLength(20)]
    [Column("jglx", Order = 104)]
    public string Jglx { get; set; }
    /// <summary>
    /// 获取或者设置0：细菌培养 1：衣原体 2：支原体 3：真菌培养
    /// </summary>
    [MaxLength(20)]
    [Column("pylx", Order = 105)]
    public string Pylx { get; set; }
    /// <summary>
    /// 获取或者设置检测日期
    /// </summary>
    [MaxLength(20)]
    [Column("jcsj", Order = 106)]
    public string Jcsj { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(255)]
    [Column("bz", Order = 107)]
    public string Bz { get; set; }
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