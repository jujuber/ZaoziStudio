namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 药品权限配置表
/// </summary>
[Table("parmdept")]
[PrimaryKey(nameof(Id))]
public sealed class Parmdept : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("id", Order = 100)]
    public long Id { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 101)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类型
    /// </summary>
    [MaxLength(20)]
    [Column("ordertype", Order = 102)]
    public string Ordertype { get; set; }
    /// <summary>
    /// 获取或者设置药库管理类型
    /// </summary>
    [MaxLength(20)]
    [Column("cc", Order = 103)]
    public string Cc { get; set; }
    /// <summary>
    /// 获取或者设置时间
    /// </summary>
    [Column("datetime", Order = 104)]
    public DateTime? Datetime { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}