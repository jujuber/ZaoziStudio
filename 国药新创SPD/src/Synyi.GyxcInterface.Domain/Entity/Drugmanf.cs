namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 药品规格产地信息
/// </summary>
[Table("drugmanf")]
[PrimaryKey(nameof(Rdn))]
public sealed class Drugmanf : EqualObject
{
    /// <summary>
    /// 获取或者设置农保
    /// </summary>
    [MaxLength(50)]
    [Column("insucode1", Order = 100)]
    public string Insucode1 { get; set; }
    /// <summary>
    /// 获取或者设置医保编码1
    /// </summary>
    [MaxLength(18)]
    [Column("insudcode", Order = 101)]
    public string Insudcode { get; set; }
    /// <summary>
    /// 获取或者设置医保编码2
    /// </summary>
    [MaxLength(50)]
    [Column("insucode2", Order = 102)]
    public string Insucode2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("trade_name", Order = 103)]
    public string TradeName { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("trade_name_py", Order = 104)]
    public string TradeNamePy { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 105)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置药品代码
    /// </summary>
    [MaxLength(18)]
    [Required]
    [Column("drcode", Order = 106)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("packunit", Order = 107)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装规格
    /// </summary>
    [Required]
    [Column("pack", Order = 108)]
    public int Pack { get; set; }
    /// <summary>
    /// 获取或者设置产地代码
    /// </summary>
    [Required]
    [Column("drmanfcode", Order = 109)]
    public int Drmanfcode { get; set; }
    /// <summary>
    /// 获取或者设置零售价
    /// </summary>
    [Precision(16, 4)]
    [Column("npl", Order = 110)]
    public decimal? Npl { get; set; }
    /// <summary>
    /// 获取或者设置是否进口
    /// </summary>
    [MaxLength(1)]
    [Column("importflag", Order = 111)]
    public string Importflag { get; set; }
    /// <summary>
    /// 获取或者设置使用标记
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 112)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置住院控制
    /// </summary>
    [MaxLength(1)]
    [Column("inhandi", Order = 113)]
    public string Inhandi { get; set; }
    /// <summary>
    /// 获取或者设置门诊控制
    /// </summary>
    [MaxLength(1)]
    [Column("inhando", Order = 114)]
    public string Inhando { get; set; }
    /// <summary>
    /// 获取或者设置急诊控制
    /// </summary>
    [MaxLength(1)]
    [Column("inhande", Order = 115)]
    public string Inhande { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inhanda", Order = 116)]
    public string Inhanda { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inhandb", Order = 117)]
    public string Inhandb { get; set; }
    /// <summary>
    /// 获取或者设置批发价
    /// </summary>
    [Precision(16, 4)]
    [Column("npp", Order = 118)]
    public decimal? Npp { get; set; }
    /// <summary>
    /// 获取或者设置最新进价
    /// </summary>
    [Precision(16, 4)]
    [Column("punits", Order = 119)]
    public decimal? Punits { get; set; }
    /// <summary>
    /// 获取或者设置批准文号
    /// </summary>
    [MaxLength(60)]
    [Column("allow", Order = 120)]
    public string Allow { get; set; }
    /// <summary>
    /// 获取或者设置药品控制
    /// </summary>
    [MaxLength(60)]
    [Column("drugcontrol", Order = 121)]
    public string Drugcontrol { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("ipb_dicomp", Order = 122)]
    public int? IpbDicomp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("ipb_ppricein", Order = 123)]
    public decimal? IpbPpricein { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("ipb_pless", Order = 124)]
    public decimal? IpbPless { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ipb", Order = 125)]
    public string Ipb { get; set; }
    /// <summary>
    /// 获取或者设置gmp认证码
    /// </summary>
    [MaxLength(1)]
    [Column("gmp", Order = 126)]
    public string Gmp { get; set; }
    /// <summary>
    /// 获取或者设置匹配
    /// </summary>
    [MaxLength(20)]
    [Column("match", Order = 127)]
    public string Match { get; set; }
    /// <summary>
    /// 获取或者设置医保等级
    /// </summary>
    [MaxLength(1)]
    [Column("drtt", Order = 128)]
    public string Drtt { get; set; }
    /// <summary>
    /// 获取或者设置中心名称
    /// </summary>
    [MaxLength(18)]
    [Column("centername", Order = 129)]
    public string Centername { get; set; }
    /// <summary>
    /// 获取或者设置支付比例
    /// </summary>
    [Precision(19, 4)]
    [Column("zfbl", Order = 130)]
    public decimal? Zfbl { get; set; }
    /// <summary>
    /// 获取或者设置gmp失效期
    /// </summary>
    [Column("gmpexpiredate", Order = 131)]
    public DateTime? Gmpexpiredate { get; set; }
    /// <summary>
    /// 获取或者设置零售效期
    /// </summary>
    [Column("nplexpiredate", Order = 132)]
    public DateTime? Nplexpiredate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("gmpzs", Order = 133)]
    public string Gmpzs { get; set; }
    /// <summary>
    /// 获取或者设置医保编码3
    /// </summary>
    [MaxLength(50)]
    [Column("insucode3", Order = 134)]
    public string Insucode3 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("oldrdn", Order = 135)]
    public int? Oldrdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("match1", Order = 136)]
    public string Match1 { get; set; }
    /// <summary>
    /// 获取或者设置医保单位
    /// </summary>
    [MaxLength(3)]
    [Column("binsupack", Order = 137)]
    public string Binsupack { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("insucode84", Order = 138)]
    public string Insucode84 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("insucode85", Order = 139)]
    public string Insucode85 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("insucode86", Order = 140)]
    public string Insucode86 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("insucode87", Order = 141)]
    public string Insucode87 { get; set; }
    /// <summary>
    /// 获取或者设置是否带量
    /// </summary>
    [MaxLength(1)]
    [Column("capacity", Order = 142)]
    public string Capacity { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("freecode", Order = 143)]
    public string Freecode { get; set; }
    /// <summary>
    /// 本位码
    /// </summary>
    [MaxLength(32)]
    [Column("bwm", Order = 144)]
    public string Bwm { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}