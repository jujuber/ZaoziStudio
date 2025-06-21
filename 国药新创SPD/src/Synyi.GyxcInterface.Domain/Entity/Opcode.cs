namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 手术基础代码表
/// </summary>
[Table("opcode")]
[PrimaryKey(nameof(Ocode))]
public sealed class Opcode : EqualObject
{
    /// <summary>
    /// 获取或者设置手术代码
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("ocode", Order = 100)]
    public string Ocode { get; set; }
    /// <summary>
    /// 获取或者设置手术名称
    /// </summary>
    [MaxLength(200)]
    [Column("oname", Order = 101)]
    public string Oname { get; set; }
    /// <summary>
    /// 获取或者设置英文
    /// </summary>
    [MaxLength(100)]
    [Column("onamee", Order = 102)]
    public string Onamee { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(100)]
    [Column("py", Order = 103)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置统计码
    /// </summary>
    [MaxLength(10)]
    [Column("censur", Order = 104)]
    public string Censur { get; set; }
    /// <summary>
    /// 获取或者设置手术类别
    /// </summary>
    [MaxLength(2)]
    [Column("otype", Order = 105)]
    public string Otype { get; set; }
    /// <summary>
    /// 获取或者设置特殊码
    /// </summary>
    [MaxLength(2)]
    [Column("ospecial", Order = 106)]
    public string Ospecial { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("cpcode", Order = 107)]
    public string Cpcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("lbtype", Order = 108)]
    public string Lbtype { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(50)]
    [Column("bz", Order = 109)]
    public string Bz { get; set; }
    /// <summary>
    /// 获取或者设置有效指标
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 110)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置版本
    /// </summary>
    [MaxLength(20)]
    [Column("version", Order = 111)]
    public string Version { get; set; }
    /// <summary>
    /// 获取或者设置切口类型
    /// </summary>
    [MaxLength(2)]
    [Column("wound", Order = 112)]
    public string Wound { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("develop", Order = 113)]
    public string Develop { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("UseGrade", Order = 114)]
    public string UseGrade { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("UseClass", Order = 115)]
    public string UseClass { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("Daysurgery", Order = 116)]
    public string Daysurgery { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Ocode;
    }
}