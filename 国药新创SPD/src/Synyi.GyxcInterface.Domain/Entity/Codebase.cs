namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 基础资料表
/// </summary>
[Table("codebase")]
[PrimaryKey(nameof(Rdn))]
public class Codebase : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("rdn", Order = 100)]
    public string Rdn { get; set; }
    /// <summary>
    /// 获取或者设置1字符参数
    /// </summary>
    [MaxLength(200)]
    [Column("code1", Order = 101)]
    public string Code1 { get; set; }
    /// <summary>
    /// 获取或者设置2字符参数
    /// </summary>
    [MaxLength(1200)]
    [Column("code2", Order = 102)]
    public string Code2 { get; set; }
    /// <summary>
    /// 获取或者设置3字符参数
    /// </summary>
    [MaxLength(200)]
    [Column("code3", Order = 103)]
    public string Code3 { get; set; }
    /// <summary>
    /// 获取或者设置4字符参数
    /// </summary>
    [MaxLength(200)]
    [Column("code4", Order = 104)]
    public string Code4 { get; set; }
    /// <summary>
    /// 获取或者设置分类
    /// </summary>
    [MaxLength(8)]
    [Column("ctcode", Order = 105)]
    public string Ctcode { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(100)]
    [Column("remark", Order = 106)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(50)]
    [Column("py", Order = 107)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置标准字段
    /// </summary>
    [MaxLength(30)]
    [Column("standfield", Order = 108)]
    public string Standfield { get; set; }
    /// <summary>
    /// 获取或者设置结算标志
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 109)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("code18", Order = 110)]
    public string Code18 { get; set; }
    /// <summary>
    /// 获取或者设置备注1
    /// </summary>
    [MaxLength(100)]
    [Column("remarkc", Order = 111)]
    public string Remarkc { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 112)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}