namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 出院申请表
/// </summary>
[Table("IP_cytable")]
[PrimaryKey(nameof(Lsh))]
public sealed class IPCytable : EqualObject
{
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("lsh", Order = 100)]
    public int Lsh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("dr", Order = 101)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("indate", Order = 102)]
    public DateTime Indate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("checkflag", Order = 103)]
    public string Checkflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("checkjp", Order = 104)]
    public string Checkjp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("checkdate", Order = 105)]
    public DateTime? Checkdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("phflag", Order = 106)]
    public string Phflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("phjp", Order = 107)]
    public string Phjp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("phdate", Order = 108)]
    public DateTime? Phdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("jsflag", Order = 109)]
    public string Jsflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("jsdate", Order = 110)]
    public DateTime? Jsdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("jsjp", Order = 111)]
    public string Jsjp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("discd", Order = 112)]
    public DateTime? Discd { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("mrn", Order = 113)]
    public string Mrn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("series", Order = 114)]
    public int Series { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("doflag", Order = 115)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("checker", Order = 116)]
    public string Checker { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("checknurer", Order = 117)]
    public string Checknurer { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("outdiscd", Order = 118)]
    public DateTime? Outdiscd { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Lsh;
    }
}