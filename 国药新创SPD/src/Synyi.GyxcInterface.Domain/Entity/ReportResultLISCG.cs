namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 
/// </summary>
[Table("ReportResult_LIS_CG")]
public sealed class ReportResultLISCG : EqualObject
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
    [MaxLength(100)]
    [Column("jgmc", Order = 102)]
    public string Jgmc { get; set; }
    /// <summary>
    /// 获取或者设置检验结果
    /// </summary>
    [MaxLength(200)]
    [Column("jyjg", Order = 103)]
    public string Jyjg { get; set; }
    /// <summary>
    /// 获取或者设置参考范围
    /// </summary>
    [MaxLength(300)]
    [Column("ckfw", Order = 104)]
    public string Ckfw { get; set; }
    /// <summary>
    /// 获取或者设置参考范围下限
    /// </summary>
    [MaxLength(50)]
    [Column("ckfwxx", Order = 105)]
    public string Ckfwxx { get; set; }
    /// <summary>
    /// 获取或者设置参考范围上限
    /// </summary>
    [MaxLength(50)]
    [Column("ckfwsx", Order = 106)]
    public string Ckfwsx { get; set; }
    /// <summary>
    /// 获取或者设置检测日期
    /// </summary>
    [Column("jcsj", Order = 107)]
    public DateTime? Jcsj { get; set; }
    /// <summary>
    /// 获取或者设置结果提示 0：正常 1：偏高 2：偏低
    /// </summary>
    [MaxLength(20)]
    [Column("jgts", Order = 108)]
    public string Jgts { get; set; }
    /// <summary>
    /// 获取或者设置结果单位
    /// </summary>
    [MaxLength(20)]
    [Column("jgdw", Order = 109)]
    public string Jgdw { get; set; }
    /// <summary>
    /// 获取或者设置打印次序
    /// </summary>
    [MaxLength(20)]
    [Column("cx", Order = 110)]
    public string Cx { get; set; }
    /// <summary>
    /// 获取或者设置使用标记 1 使用 0 无效
    /// </summary>
    [MaxLength(2)]
    [Column("useflag", Order = 111)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置申请单号
    /// </summary>
    [MaxLength(50)]
    [Column("sqdh", Order = 112)]
    public string Sqdh { get; set; }
    /// <summary>
    /// 获取或者设置报告单号
    /// </summary>
    [MaxLength(50)]
    [Column("bgdh", Order = 113)]
    public string Bgdh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("ID", Order = 114)]
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