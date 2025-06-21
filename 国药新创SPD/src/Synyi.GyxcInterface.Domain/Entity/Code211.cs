namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 用法
/// </summary>
[Table("code211")]
[PrimaryKey(nameof(Code))]
public sealed class Code211 : EqualObject
{
    /// <summary>
    /// 获取或者设置药品用
    /// </summary>
    [MaxLength(1)]
    [Column("drugflag", Order = 100)]
    public string Drugflag { get; set; }
    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [MaxLength(6)]
    [Required]
    [Column("code", Order = 101)]
    public string Code { get; set; }
    /// <summary>
    /// 获取或者设置用法
    /// </summary>
    [MaxLength(50)]
    [Column("remark", Order = 102)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置收费码
    /// </summary>
    [MaxLength(8)]
    [Column("fcode", Order = 103)]
    public string Fcode { get; set; }
    /// <summary>
    /// 获取或者设置医嘱码
    /// </summary>
    [MaxLength(10)]
    [Column("pcode", Order = 104)]
    public string Pcode { get; set; }
    /// <summary>
    /// 获取或者设置西药用
    /// </summary>
    [MaxLength(1)]
    [Column("flage", Order = 105)]
    public string Flage { get; set; }
    /// <summary>
    /// 获取或者设置中药用
    /// </summary>
    [MaxLength(1)]
    [Column("flagc", Order = 106)]
    public string Flagc { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("gflag", Order = 107)]
    public string Gflag { get; set; }
    /// <summary>
    /// 获取或者设置项目类型
    /// </summary>
    [MaxLength(1)]
    [Column("itemtype", Order = 108)]
    public string Itemtype { get; set; }
    /// <summary>
    /// 获取或者设置用法绑定处置
    /// </summary>
    [MaxLength(100)]
    [Column("opcode", Order = 109)]
    public string Opcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("zsfflag", Order = 110)]
    public string Zsfflag { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 111)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(20)]
    [Column("py", Order = 112)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置排序
    /// </summary>
    [Column("sort", Order = 113)]
    public int? Sort { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(32)]
    [Column("UsageType", Order = 114)]
    public string UsageType { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(32)]
    [Column("LabelType", Order = 115)]
    public string LabelType { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("useflag", Order = 116)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ExeUsageFlag", Order = 117)]
    public string ExeUsageFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("InfusionUsageFlag", Order = 118)]
    public string InfusionUsageFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("OralUsageFlag", Order = 119)]
    public string OralUsageFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("DroppingVelocity", Order = 120)]
    public string DroppingVelocity { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }
}