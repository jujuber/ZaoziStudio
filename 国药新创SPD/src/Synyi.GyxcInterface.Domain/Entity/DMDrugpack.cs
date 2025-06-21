namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 药品规格/换算系数表
/// </summary>
[Table("DM_drugpack")]
[PrimaryKey(nameof(Rdn))]
public sealed class DMDrugpack : EqualObject
{
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Required]
    [Column("drcode", Order = 100)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("packunit", Order = 101)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("pack", Order = 102)]
    public int Pack { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("dralarma", Order = 103)]
    public decimal? Dralarma { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("dralarmb", Order = 104)]
    public decimal? Dralarmb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("dralarmo", Order = 105)]
    public decimal? Dralarmo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("dralarmi", Order = 106)]
    public decimal? Dralarmi { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("dralarme", Order = 107)]
    public decimal? Dralarme { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inhanda", Order = 108)]
    public string Inhanda { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inhandb", Order = 109)]
    public string Inhandb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inhando", Order = 110)]
    public string Inhando { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inhandi", Order = 111)]
    public string Inhandi { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inhande", Order = 112)]
    public string Inhande { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 113)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inhandc", Order = 114)]
    public string Inhandc { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("dralarmc", Order = 115)]
    public decimal? Dralarmc { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("oppackunit", Order = 116)]
    public string Oppackunit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("oppack", Order = 117)]
    public decimal? Oppack { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("drunit", Order = 118)]
    public string Drunit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("inpackunit", Order = 119)]
    public string Inpackunit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("inpack", Order = 120)]
    public decimal? Inpack { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("hoscode", Order = 121)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("hostrandt", Order = 122)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 123)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("hydrcode", Order = 124)]
    public string Hydrcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("eppackunit", Order = 125)]
    public string Eppackunit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("eppack", Order = 126)]
    public decimal? Eppack { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("rdn", Order = 127)]
    public int Rdn { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}