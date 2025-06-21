namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 药品功能分类
/// </summary>
[Table("code210")]
[PrimaryKey(nameof(Code))]
public sealed class Code210 : EqualObject
{
    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [MaxLength(4)]
    [Required]
    [Column("code", Order = 100)]
    public string Code { get; set; }
    /// <summary>
    /// 获取或者设置说明
    /// </summary>
    [MaxLength(60)]
    [Column("remark", Order = 101)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置说明（英语）
    /// </summary>
    [MaxLength(60)]
    [Column("remarke", Order = 102)]
    public string Remarke { get; set; }
    /// <summary>
    /// 获取或者设置上级代码
    /// </summary>
    [MaxLength(4)]
    [Column("lstcode", Order = 103)]
    public string Lstcode { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("flag", Order = 104)]
    public string Flag { get; set; }
    /// <summary>
    /// 获取或者设置旧
    /// </summary>
    [MaxLength(4)]
    [Column("old", Order = 105)]
    public string Old { get; set; }
    /// <summary>
    /// 获取或者设置/
    /// </summary>
    [MaxLength(1)]
    [Column("flag1", Order = 106)]
    public string Flag1 { get; set; }
    /// <summary>
    /// 获取或者设置//
    /// </summary>
    [MaxLength(1)]
    [Column("flag2", Order = 107)]
    public string Flag2 { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }
}