namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 过敏源字典
/// </summary>
[Table("gmywdm")]
[PrimaryKey(nameof(BZBM))]
public sealed class Gmywdm : EqualObject
{
    /// <summary>
    /// 获取或者设置过敏代码
    /// </summary>
    [Precision(4, 0)]
    [Column("YPXH", Order = 100)]
    public decimal? YPXH { get; set; }
    /// <summary>
    /// 获取或者设置名称
    /// </summary>
    [MaxLength(40)]
    [Column("YPMC", Order = 101)]
    public string YPMC { get; set; }
    /// <summary>
    /// 获取或者设置归类码
    /// </summary>
    [MaxLength(10)]
    [Required]
    [Column("BZBM", Order = 102)]
    public string BZBM { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("ZFPB", Order = 103)]
    public int? ZFPB { get; set; }
    /// <summary>
    /// 获取或者设置拼音码
    /// </summary>
    [MaxLength(6)]
    [Column("SRM1", Order = 104)]
    public string SRM1 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(6)]
    [Column("SRM2", Order = 105)]
    public string SRM2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(6)]
    [Column("SRM3", Order = 106)]
    public string SRM3 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("OLDCODE", Order = 107)]
    public string OLDCODE { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("TYPE", Order = 108)]
    public int TYPE { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return BZBM;
    }
}