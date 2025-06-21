namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 
/// </summary>
[Table("o_restrict_actual_fee")]
[PrimaryKey(nameof(Id))]
public sealed class ORestrictActualFee : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("id", Order = 100)]
    public int Id { get; set; }
    /// <summary>
    /// 获取或者设置排班号
    /// </summary>
    [Column("orid", Order = 101)]
    public int? Orid { get; set; }
    /// <summary>
    /// 获取或者设置费用编码
    /// </summary>
    [MaxLength(30)]
    [Column("regfcode", Order = 102)]
    public string Regfcode { get; set; }
    /// <summary>
    /// 获取或者设置有效标记
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 103)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置最后修改时间
    /// </summary>
    [Column("UpDateTime", Order = 104)]
    public DateTime? UpDateTime { get; set; }
    /// <summary>
    /// 获取或者设置最后修改人
    /// </summary>
    [MaxLength(20)]
    [Column("pajp", Order = 105)]
    public string Pajp { get; set; }
    /// <summary>
    /// 获取或者设置排班号实际
    /// </summary>
    [Column("pbid", Order = 106)]
    public int? Pbid { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}