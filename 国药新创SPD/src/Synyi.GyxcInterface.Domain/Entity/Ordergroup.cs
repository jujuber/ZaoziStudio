namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 项目部位
/// </summary>
[Table("ordergroup")]
[PrimaryKey(nameof(Code))]
public sealed class Ordergroup : EqualObject
{
    /// <summary>
    /// 获取或者设置部位代码
    /// </summary>
    [MaxLength(10)]
    [Required]
    [Column("code", Order = 100)]
    public string Code { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(10)]
    [Column("orderflag", Order = 101)]
    public string Orderflag { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(60)]
    [Column("remark", Order = 102)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 103)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }
}