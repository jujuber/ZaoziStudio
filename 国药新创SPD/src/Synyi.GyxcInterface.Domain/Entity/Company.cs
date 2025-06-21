namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 
/// </summary>
[Table("company")]
[PrimaryKey(nameof(Id))]
public sealed class Company : EqualObject
{
    /// <summary>
    /// 获取或者设置公司名称
    /// </summary>
    [MaxLength(255)]
    [Column("company_name", Order = 100)]
    public string CompanyName { get; set; }
    /// <summary>
    /// 获取或者设置税号
    /// </summary>
    [MaxLength(255)]
    [Column("duty_paragraph", Order = 101)]
    public string DutyParagraph { get; set; }
    /// <summary>
    /// 获取或者设置操作员
    /// </summary>
    [MaxLength(255)]
    [Column("jp", Order = 102)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置操作时间
    /// </summary>
    [Column("jpdate", Order = 103)]
    public DateTime? Jpdate { get; set; }
    /// <summary>
    /// 获取或者设置有效标记
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 104)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(255)]
    [Column("py", Order = 105)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置五笔
    /// </summary>
    [MaxLength(255)]
    [Column("wb", Order = 106)]
    public string Wb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("id", Order = 107)]
    public int Id { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}