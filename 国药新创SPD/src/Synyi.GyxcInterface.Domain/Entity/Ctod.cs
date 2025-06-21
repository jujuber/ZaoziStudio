namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 临床科室与发药药房关系对照表
/// </summary>
[Table("ctod")]
[PrimaryKey(nameof(Rdn))]
public sealed class Ctod : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 100)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置临床科室
    /// </summary>
    [MaxLength(20)]
    [Column("clinic", Order = 101)]
    public string Clinic { get; set; }
    /// <summary>
    /// 获取或者设置药房
    /// </summary>
    [MaxLength(20)]
    [Column("pharmdept", Order = 102)]
    public string Pharmdept { get; set; }
    /// <summary>
    /// 获取或者设置发放类型
    /// </summary>
    [MaxLength(4)]
    [Column("dtype", Order = 103)]
    public string Dtype { get; set; }
    /// <summary>
    /// 获取或者设置急诊药房
    /// </summary>
    [MaxLength(20)]
    [Column("epharmdept", Order = 104)]
    public string Epharmdept { get; set; }
    /// <summary>
    /// 获取或者设置门诊药房
    /// </summary>
    [MaxLength(20)]
    [Column("cpharmdept", Order = 105)]
    public string Cpharmdept { get; set; }
    /// <summary>
    /// 获取或者设置排序
    /// </summary>
    [Column("sort", Order = 106)]
    public int? Sort { get; set; }
    /// <summary>
    /// 获取或者设置开始时间
    /// </summary>
    [Column("stdate", Order = 107)]
    public DateTime? Stdate { get; set; }
    /// <summary>
    /// 获取或者设置结束时间
    /// </summary>
    [Column("eddate", Order = 108)]
    public DateTime? Eddate { get; set; }
    /// <summary>
    /// 获取或者设置机构代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 109)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置备用药药房
    /// </summary>
    [MaxLength(20)]
    [Column("BBBpharm", Order = 110)]
    public string BBBpharm { get; set; }
    /// <summary>
    /// 获取或者设置晚间药房
    /// </summary>
    [MaxLength(20)]
    [Column("nightpharm", Order = 111)]
    public string Nightpharm { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 112)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("isuse", Order = 113)]
    public string Isuse { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}