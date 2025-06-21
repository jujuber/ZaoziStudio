namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 财务核算类别
/// </summary>
[Table("accountcodezy")]
[PrimaryKey(nameof(Acode), nameof(Stay))]
public sealed class Accountcodezy : EqualObject
{
    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [MaxLength(10)]
    [Required]
    [Column("acode", Order = 100)]
    public string Acode { get; set; }
    /// <summary>
    /// 获取或者设置名称
    /// </summary>
    [MaxLength(60)]
    [Column("aname", Order = 101)]
    public string Aname { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 102)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(80)]
    [Column("py", Order = 103)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置排序
    /// </summary>
    [Column("asort", Order = 104)]
    public int? Asort { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Required]
    [Column("stay", Order = 105)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置五笔
    /// </summary>
    [MaxLength(50)]
    [Column("FiveStrokes", Order = 106)]
    public string FiveStrokes { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Acode;
        yield return Stay;
    }
}