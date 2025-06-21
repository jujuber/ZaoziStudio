namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 诊断ICD基础表
/// </summary>
[Table("icd")]
[PrimaryKey(nameof(Rdn))]
public sealed class Icd : EqualObject
{
    /// <summary>
    /// 获取或者设置特病标记
    /// </summary>
    [MaxLength(1)]
    [Column("onflag", Order = 100)]
    public string Onflag { get; set; }
    /// <summary>
    /// 获取或者设置慢病标记
    /// </summary>
    [MaxLength(1)]
    [Column("odflag", Order = 101)]
    public string Odflag { get; set; }
    /// <summary>
    /// 获取或者设置普通病标记
    /// </summary>
    [MaxLength(1)]
    [Column("opflag", Order = 102)]
    public string Opflag { get; set; }
    /// <summary>
    /// 获取或者设置住院诊断标记
    /// </summary>
    [MaxLength(1)]
    [Column("inflag", Order = 103)]
    public string Inflag { get; set; }
    /// <summary>
    /// 获取或者设置ICD诊断编码
    /// </summary>
    [MaxLength(50)]
    [Column("icdcode", Order = 104)]
    public string Icdcode { get; set; }
    /// <summary>
    /// 获取或者设置ICD诊断名称
    /// </summary>
    [MaxLength(100)]
    [Column("icdname", Order = 105)]
    public string Icdname { get; set; }
    /// <summary>
    /// 获取或者设置icd英文名称
    /// </summary>
    [MaxLength(50)]
    [Column("icdnamee", Order = 106)]
    public string Icdnamee { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(70)]
    [Column("py", Order = 107)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("cflag", Order = 108)]
    public string Cflag { get; set; }
    /// <summary>
    /// 获取或者设置特殊病种
    /// </summary>
    [MaxLength(1)]
    [Column("sflag", Order = 109)]
    public string Sflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ycflag", Order = 110)]
    public string Ycflag { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 111)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置ICD10诊断编码
    /// </summary>
    [MaxLength(18)]
    [Column("icdcode10", Order = 112)]
    public string Icdcode10 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("jbtjm", Order = 113)]
    public int? Jbtjm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("jbtjm10", Order = 114)]
    public int? Jbtjm10 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("xzbz", Order = 115)]
    public int? Xzbz { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("zfpb", Order = 116)]
    public int? Zfpb { get; set; }
    /// <summary>
    /// 获取或者设置旧ICD编码
    /// </summary>
    [MaxLength(18)]
    [Column("oldicdcode", Order = 117)]
    public string Oldicdcode { get; set; }
    /// <summary>
    /// 获取或者设置卡类型
    /// </summary>
    [MaxLength(30)]
    [Column("cardtype", Order = 118)]
    public string Cardtype { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 119)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("cpcode", Order = 120)]
    public string Cpcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("service", Order = 121)]
    public string Service { get; set; }
    /// <summary>
    /// 获取或者设置医保诊断ICD
    /// </summary>
    [MaxLength(50)]
    [Column("insucode_icd", Order = 122)]
    public string InsucodeIcd { get; set; }
    /// <summary>
    /// 获取或者设置医保诊断ICD（省医保）
    /// </summary>
    [MaxLength(50)]
    [Column("insucode_icd_syb", Order = 123)]
    public string InsucodeIcdSyb { get; set; }
    /// <summary>
    /// 获取或者设置医保诊断ICD（农保）
    /// </summary>
    [MaxLength(50)]
    [Column("insucode_icd_nb", Order = 124)]
    public string InsucodeIcdNb { get; set; }
    /// <summary>
    /// 获取或者设置疾病保卡
    /// </summary>
    [MaxLength(10)]
    [Column("DiseaseReport", Order = 125)]
    public string DiseaseReport { get; set; }
    /// <summary>
    /// 获取或者设置作废
    /// </summary>
    [Column("zfflag", Order = 126)]
    public int? Zfflag { get; set; }
    /// <summary>
    /// 获取或者设置版本
    /// </summary>
    [MaxLength(20)]
    [Column("version", Order = 127)]
    public string Version { get; set; }
    /// <summary>
    /// 获取或者设置icd分类
    /// </summary>
    [MaxLength(2)]
    [Column("icdtype", Order = 128)]
    public string Icdtype { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 129)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("oxflag", Order = 130)]
    public string Oxflag { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}