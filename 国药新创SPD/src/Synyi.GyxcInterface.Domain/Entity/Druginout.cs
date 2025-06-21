namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 药品操作单据明细表
/// </summary>
[Table("druginout")]
[PrimaryKey(nameof(Rdn))]
public sealed class Druginout : EqualObject
{
    /// <summary>
    /// 获取或者设置计价代码
    /// </summary>
    [Column("drugmanfrdn", Order = 100)]
    public int? Drugmanfrdn { get; set; }
    /// <summary>
    /// 获取或者设置采购数量(药房采购专用：记录药房采购申请时最开始的采购申请数量，也就是第一次录入的申请数量)
    /// </summary>
    [Precision(18, 4)]
    [Column("procure_number", Order = 101)]
    public decimal? ProcureNumber { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 102)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置主表外键
    /// </summary>
    [Column("rdn1", Order = 103)]
    public int? Rdn1 { get; set; }
    /// <summary>
    /// 获取或者设置初始编码
    /// </summary>
    [Column("preno", Order = 104)]
    public int? Preno { get; set; }
    /// <summary>
    /// 获取或者设置标题
    /// </summary>
    [MaxLength(1)]
    [Column("title", Order = 105)]
    public string Title { get; set; }
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
    /// 获取或者设置包装系数
    /// </summary>
    [Required]
    [Column("pack", Order = 108)]
    public int Pack { get; set; }
    /// <summary>
    /// 获取或者设置药品产地
    /// </summary>
    [Required]
    [Column("dimanfcode", Order = 109)]
    public int Dimanfcode { get; set; }
    /// <summary>
    /// 获取或者设置药品名称
    /// </summary>
    [MaxLength(100)]
    [Column("drname", Order = 110)]
    public string Drname { get; set; }
    /// <summary>
    /// 获取或者设置药品规格
    /// </summary>
    [MaxLength(80)]
    [Column("drmodel", Order = 111)]
    public string Drmodel { get; set; }
    /// <summary>
    /// 获取或者设置药品大类
    /// </summary>
    [MaxLength(8)]
    [Column("drchina", Order = 112)]
    public string Drchina { get; set; }
    /// <summary>
    /// 获取或者设置最小单位
    /// </summary>
    [MaxLength(3)]
    [Column("drunit", Order = 113)]
    public string Drunit { get; set; }
    /// <summary>
    /// 获取或者设置操作科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 114)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置来源科室
    /// </summary>
    [MaxLength(20)]
    [Column("fromdept", Order = 115)]
    public string Fromdept { get; set; }
    /// <summary>
    /// 获取或者设置去向部门
    /// </summary>
    [MaxLength(20)]
    [Column("todept", Order = 116)]
    public string Todept { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(16, 4)]
    [Required]
    [Column("packnumb", Order = 117)]
    public decimal Packnumb { get; set; }
    /// <summary>
    /// 获取或者设置进价
    /// </summary>
    [Precision(16, 4)]
    [Column("punits", Order = 118)]
    public decimal? Punits { get; set; }
    /// <summary>
    /// 获取或者设置实发数量
    /// </summary>
    [Precision(18, 4)]
    [Column("realsent", Order = 119)]
    public decimal? Realsent { get; set; }
    /// <summary>
    /// 获取或者设置批发价
    /// </summary>
    [Precision(16, 4)]
    [Column("npp", Order = 120)]
    public decimal? Npp { get; set; }
    /// <summary>
    /// 获取或者设置零售价
    /// </summary>
    [Precision(16, 4)]
    [Required]
    [Column("npl", Order = 121)]
    public decimal Npl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("npout", Order = 122)]
    public decimal? Npout { get; set; }
    /// <summary>
    /// 获取或者设置零售总价
    /// </summary>
    [Precision(16, 4)]
    [Column("tprice", Order = 123)]
    public decimal? Tprice { get; set; }
    /// <summary>
    /// 获取或者设置剩余库存
    /// </summary>
    [Precision(16, 4)]
    [Column("packremain", Order = 124)]
    public decimal? Packremain { get; set; }
    /// <summary>
    /// 获取或者设置批号
    /// </summary>
    [MaxLength(30)]
    [Column("dilotn", Order = 125)]
    public string Dilotn { get; set; }
    /// <summary>
    /// 获取或者设置gmp标志
    /// </summary>
    [MaxLength(1)]
    [Column("gmp", Order = 126)]
    public string Gmp { get; set; }
    /// <summary>
    /// 获取或者设置效期
    /// </summary>
    [Column("expiredate", Order = 127)]
    public DateTime? Expiredate { get; set; }
    /// <summary>
    /// 获取或者设置产地名称
    /// </summary>
    [MaxLength(100)]
    [Column("dimanf", Order = 128)]
    public string Dimanf { get; set; }
    /// <summary>
    /// 获取或者设置0未确认 1 已确认
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 129)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置零售价1
    /// </summary>
    [Precision(16, 4)]
    [Column("rprice", Order = 130)]
    public decimal? Rprice { get; set; }
    /// <summary>
    /// 获取或者设置发票号
    /// </summary>
    [MaxLength(15)]
    [Column("fb", Order = 131)]
    public string Fb { get; set; }
    /// <summary>
    /// 获取或者设置支付经办
    /// </summary>
    [MaxLength(5)]
    [Column("paidjp", Order = 132)]
    public string Paidjp { get; set; }
    /// <summary>
    /// 获取或者设置支付日期
    /// </summary>
    [Column("paiddate", Order = 133)]
    public DateTime? Paiddate { get; set; }
    /// <summary>
    /// 获取或者设置支付标志
    /// </summary>
    [Precision(16, 4)]
    [Column("paid", Order = 134)]
    public decimal? Paid { get; set; }
    /// <summary>
    /// 获取或者设置入库编号
    /// </summary>
    [MaxLength(15)]
    [Column("sqh", Order = 135)]
    public string Sqh { get; set; }
    /// <summary>
    /// 获取或者设置损利
    /// </summary>
    [Precision(16, 4)]
    [Column("profitloss", Order = 136)]
    public decimal? Profitloss { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(40)]
    [Column("remark", Order = 137)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("paided", Order = 138)]
    public string Paided { get; set; }
    /// <summary>
    /// 获取或者设置打印标记
    /// </summary>
    [MaxLength(1)]
    [Column("printflag", Order = 139)]
    public string Printflag { get; set; }
    /// <summary>
    /// 获取或者设置打印编号
    /// </summary>
    [MaxLength(15)]
    [Column("printno", Order = 140)]
    public string Printno { get; set; }
    /// <summary>
    /// 获取或者设置批准文号
    /// </summary>
    [MaxLength(60)]
    [Column("allow", Order = 141)]
    public string Allow { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("tmp", Order = 142)]
    public decimal? Tmp { get; set; }
    /// <summary>
    /// 获取或者设置库存影响结果（0：入；1：出）
    /// </summary>
    [MaxLength(1)]
    [Column("outflag", Order = 143)]
    public string Outflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("yans", Order = 144)]
    public decimal? Yans { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("ps", Order = 145)]
    public decimal? Ps { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("zcsb", Order = 146)]
    public string Zcsb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ccjy", Order = 147)]
    public string Ccjy { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("hgd", Order = 148)]
    public string Hgd { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("bzqk", Order = 149)]
    public string Bzqk { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("wgzl", Order = 150)]
    public string Wgzl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ysjl", Order = 151)]
    public string Ysjl { get; set; }
    /// <summary>
    /// 获取或者设置gmp过期时间
    /// </summary>
    [Column("gmpexpiredate", Order = 152)]
    public DateTime? Gmpexpiredate { get; set; }
    /// <summary>
    /// 获取或者设置零售价过期时间
    /// </summary>
    [Column("nplexpiredate", Order = 153)]
    public DateTime? Nplexpiredate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("gmpzs", Order = 154)]
    public string Gmpzs { get; set; }
    /// <summary>
    /// 获取或者设置批次库存主键
    /// </summary>
    [MaxLength(100)]
    [Column("dihtimerdn", Order = 155)]
    public string Dihtimerdn { get; set; }
    /// <summary>
    /// 获取或者设置进价总价
    /// </summary>
    [Precision(19, 4)]
    [Column("tpunits", Order = 156)]
    public decimal? Tpunits { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("todeptnum", Order = 157)]
    public decimal? Todeptnum { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}