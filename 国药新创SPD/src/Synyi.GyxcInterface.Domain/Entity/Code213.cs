namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 单位
/// </summary>
[Table("code213")]
[PrimaryKey(nameof(Code))]
public sealed class Code213 : EqualObject
{
    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("code", Order = 100)]
    public string Code { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(10)]
    [Column("remark", Order = 101)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置热键
    /// </summary>
    [MaxLength(3)]
    [Column("hotkey", Order = 102)]
    public string Hotkey { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 103)]
    public string Hoscode { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }
}