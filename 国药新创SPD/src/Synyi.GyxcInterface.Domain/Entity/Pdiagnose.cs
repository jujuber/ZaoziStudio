namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 诊断表
/// </summary>
[Table("pdiagnose")]
[PrimaryKey(nameof(Rdn))]
public sealed class Pdiagnose : EqualObject
{
    /// <summary>
    /// 获取或者设置医保就诊类型
    /// </summary>
    [MaxLength(10)]
    [Column("stayinsu", Order = 100)]
    public string Stayinsu { get; set; }
    /// <summary>
    /// 获取或者设置来源唯一编码
    /// </summary>
    [MaxLength(32)]
    [Column("sourcekey", Order = 101)]
    public string Sourcekey { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 102)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Required]
    [Column("mrn", Order = 103)]
    public int Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 104)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 105)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置诊断描述
    /// </summary>
    [MaxLength(200)]
    [Column("diagnose", Order = 106)]
    public string Diagnose { get; set; }
    /// <summary>
    /// 获取或者设置主诊断（ICD码）
    /// </summary>
    [MaxLength(50)]
    [Column("diagnosecodep", Order = 107)]
    public string Diagnosecodep { get; set; }
    /// <summary>
    /// 获取或者设置次诊断（ICD码）
    /// </summary>
    [MaxLength(50)]
    [Column("diagnosecodes", Order = 108)]
    public string Diagnosecodes { get; set; }
    /// <summary>
    /// 获取或者设置主诊断标志
    /// </summary>
    [MaxLength(1)]
    [Column("primaryflag", Order = 109)]
    public string Primaryflag { get; set; }
    /// <summary>
    /// 获取或者设置医生工号
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 110)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置录入日期
    /// </summary>
    [Column("dodate", Order = 111)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 112)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置严重程度
    /// </summary>
    [MaxLength(1)]
    [Column("dcondi", Order = 113)]
    public string Dcondi { get; set; }
    /// <summary>
    /// 获取或者设置感染标志
    /// </summary>
    [MaxLength(1)]
    [Column("infectflag", Order = 114)]
    public string Infectflag { get; set; }
    /// <summary>
    /// 获取或者设置门诊标志
    /// </summary>
    [MaxLength(1)]
    [Column("stayflag", Order = 115)]
    public string Stayflag { get; set; }
    /// <summary>
    /// 获取或者设置入院标志
    /// </summary>
    [MaxLength(1)]
    [Column("inflag", Order = 116)]
    public string Inflag { get; set; }
    /// <summary>
    /// 获取或者设置ICD9诊断码
    /// </summary>
    [MaxLength(50)]
    [Column("diagnosecid9", Order = 117)]
    public string Diagnosecid9 { get; set; }
    /// <summary>
    /// 获取或者设置医疗组
    /// </summary>
    [Column("bygroup", Order = 118)]
    public int? Bygroup { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("mcode", Order = 119)]
    public string Mcode { get; set; }
    /// <summary>
    /// 获取或者设置标志
    /// </summary>
    [MaxLength(1)]
    [Column("flag", Order = 120)]
    public string Flag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("mdiagnose", Order = 121)]
    public string Mdiagnose { get; set; }
    /// <summary>
    /// 获取或者设置部位
    /// </summary>
    [MaxLength(18)]
    [Column("part", Order = 122)]
    public string Part { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 123)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置关联序号
    /// </summary>
    [Column("relardn", Order = 124)]
    public int? Relardn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("sflag", Order = 125)]
    public string Sflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("severity", Order = 126)]
    public string Severity { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("zfflag", Order = 127)]
    public int? Zfflag { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 128)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置首诊标志
    /// </summary>
    [MaxLength(1)]
    [Column("firstflag", Order = 129)]
    public string Firstflag { get; set; }
    /// <summary>
    /// 获取或者设置首诊诊断
    /// </summary>
    [MaxLength(50)]
    [Column("firstdiag", Order = 130)]
    public string Firstdiag { get; set; }
    /// <summary>
    /// 获取或者设置诊断前缀
    /// </summary>
    [MaxLength(200)]
    [Column("diagnoseqz", Order = 131)]
    public string Diagnoseqz { get; set; }
    /// <summary>
    /// 获取或者设置诊断后缀
    /// </summary>
    [MaxLength(201)]
    [Column("diagnosehz", Order = 132)]
    public string Diagnosehz { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}