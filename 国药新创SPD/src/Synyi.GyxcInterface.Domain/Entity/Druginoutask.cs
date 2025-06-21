namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 药房申请单明细
/// </summary>
[Table("druginoutask")]
[PrimaryKey(nameof(Rdn))]
public sealed class Druginoutask : EqualObject
{
    /// <summary>
    /// 获取或者设置采购数量(药房采购专用：记录药房采购申请时最开始的采购申请数量，也就是第一次录入的申请数量)
    /// </summary>
    [Precision(18, 4)]
    [Column("procure_number", Order = 100)]
    public decimal? ProcureNumber { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 101)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置主表外键
    /// </summary>
    [Column("rdn1", Order = 102)]
    public int? Rdn1 { get; set; }
    /// <summary>
    /// 获取或者设置初始编码
    /// </summary>
    [Column("preno", Order = 103)]
    public int? Preno { get; set; }
    /// <summary>
    /// 获取或者设置标题
    /// </summary>
    [MaxLength(1)]
    [Column("title", Order = 104)]
    public string Title { get; set; }
    /// <summary>
    /// 获取或者设置药品代码
    /// </summary>
    [MaxLength(18)]
    [Column("drcode", Order = 105)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(3)]
    [Column("packunit", Order = 106)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装规格
    /// </summary>
    [Required]
    [Column("pack", Order = 107)]
    public int Pack { get; set; }
    /// <summary>
    /// 获取或者设置产地代码
    /// </summary>
    [Column("dimanfcode", Order = 108)]
    public int? Dimanfcode { get; set; }
    /// <summary>
    /// 获取或者设置药品名称
    /// </summary>
    [MaxLength(100)]
    [Required]
    [Column("drname", Order = 109)]
    public string Drname { get; set; }
    /// <summary>
    /// 获取或者设置药品规格
    /// </summary>
    [MaxLength(100)]
    [Column("drmodel", Order = 110)]
    public string Drmodel { get; set; }
    /// <summary>
    /// 获取或者设置药品大类
    /// </summary>
    [MaxLength(8)]
    [Column("drchina", Order = 111)]
    public string Drchina { get; set; }
    /// <summary>
    /// 获取或者设置最小单位
    /// </summary>
    [MaxLength(3)]
    [Column("drunit", Order = 112)]
    public string Drunit { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 113)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置来源部门
    /// </summary>
    [MaxLength(20)]
    [Column("fromdept", Order = 114)]
    public string Fromdept { get; set; }
    /// <summary>
    /// 获取或者设置去向部门
    /// </summary>
    [MaxLength(20)]
    [Column("todept", Order = 115)]
    public string Todept { get; set; }
    /// <summary>
    /// 获取或者设置包装数量
    /// </summary>
    [Precision(16, 4)]
    [Required]
    [Column("packnumb", Order = 116)]
    public decimal Packnumb { get; set; }
    /// <summary>
    /// 获取或者设置包装进价
    /// </summary>
    [Precision(16, 4)]
    [Column("punits", Order = 117)]
    public decimal? Punits { get; set; }
    /// <summary>
    /// 获取或者设置实发数量
    /// </summary>
    [Precision(18, 4)]
    [Column("realsent", Order = 118)]
    public decimal? Realsent { get; set; }
    /// <summary>
    /// 获取或者设置批发价
    /// </summary>
    [Precision(16, 4)]
    [Column("npp", Order = 119)]
    public decimal? Npp { get; set; }
    /// <summary>
    /// 获取或者设置零售价
    /// </summary>
    [Precision(16, 4)]
    [Column("npl", Order = 120)]
    public decimal? Npl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("npout", Order = 121)]
    public decimal? Npout { get; set; }
    /// <summary>
    /// 获取或者设置零售总价
    /// </summary>
    [Precision(16, 4)]
    [Column("tprice", Order = 122)]
    public decimal? Tprice { get; set; }
    /// <summary>
    /// 获取或者设置剩余库存
    /// </summary>
    [Precision(16, 4)]
    [Column("packremain", Order = 123)]
    public decimal? Packremain { get; set; }
    /// <summary>
    /// 获取或者设置批号
    /// </summary>
    [MaxLength(30)]
    [Column("dilotn", Order = 124)]
    public string Dilotn { get; set; }
    /// <summary>
    /// 获取或者设置gmp标志
    /// </summary>
    [MaxLength(1)]
    [Column("gmp", Order = 125)]
    public string Gmp { get; set; }
    /// <summary>
    /// 获取或者设置有效期
    /// </summary>
    [Column("expiredate", Order = 126)]
    public DateTime? Expiredate { get; set; }
    /// <summary>
    /// 获取或者设置产地名称
    /// </summary>
    [MaxLength(100)]
    [Column("dimanf", Order = 127)]
    public string Dimanf { get; set; }
    /// <summary>
    /// 获取或者设置结算标志
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 128)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("rprice", Order = 129)]
    public decimal? Rprice { get; set; }
    /// <summary>
    /// 获取或者设置发票号码
    /// </summary>
    [MaxLength(15)]
    [Column("fb", Order = 130)]
    public string Fb { get; set; }
    /// <summary>
    /// 获取或者设置支付经办
    /// </summary>
    [MaxLength(5)]
    [Column("paidjp", Order = 131)]
    public string Paidjp { get; set; }
    /// <summary>
    /// 获取或者设置支付日期
    /// </summary>
    [Column("paiddate", Order = 132)]
    public DateTime? Paiddate { get; set; }
    /// <summary>
    /// 获取或者设置支付标志
    /// </summary>
    [Precision(16, 4)]
    [Column("paid", Order = 133)]
    public decimal? Paid { get; set; }
    /// <summary>
    /// 获取或者设置申请号
    /// </summary>
    [MaxLength(15)]
    [Column("sqh", Order = 134)]
    public string Sqh { get; set; }
    /// <summary>
    /// 获取或者设置损利
    /// </summary>
    [Precision(16, 4)]
    [Column("profitloss", Order = 135)]
    public decimal? Profitloss { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(40)]
    [Column("remark", Order = 136)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("paided", Order = 137)]
    public string Paided { get; set; }
    /// <summary>
    /// 获取或者设置打印标志
    /// </summary>
    [MaxLength(1)]
    [Column("printflag", Order = 138)]
    public string Printflag { get; set; }
    /// <summary>
    /// 获取或者设置打印编号
    /// </summary>
    [MaxLength(15)]
    [Column("printno", Order = 139)]
    public string Printno { get; set; }
    /// <summary>
    /// 获取或者设置批准文号
    /// </summary>
    [MaxLength(60)]
    [Column("allow", Order = 140)]
    public string Allow { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("tmp", Order = 141)]
    public decimal? Tmp { get; set; }
    /// <summary>
    /// 获取或者设置库存影响结果（0：入；1：出）
    /// </summary>
    [MaxLength(1)]
    [Column("outflag", Order = 142)]
    public string Outflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("yans", Order = 143)]
    public decimal? Yans { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("ps", Order = 144)]
    public decimal? Ps { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("zcsb", Order = 145)]
    public string Zcsb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ccjy", Order = 146)]
    public string Ccjy { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("hgd", Order = 147)]
    public string Hgd { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("bzqk", Order = 148)]
    public string Bzqk { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("wgzl", Order = 149)]
    public string Wgzl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ysjl", Order = 150)]
    public string Ysjl { get; set; }
    /// <summary>
    /// 获取或者设置零售总价1
    /// </summary>
    [Precision(19, 4)]
    [Column("tnpl", Order = 151)]
    public decimal? Tnpl { get; set; }
    /// <summary>
    /// 获取或者设置进价总价
    /// </summary>
    [Precision(19, 4)]
    [Column("tpunits", Order = 152)]
    public decimal? Tpunits { get; set; }
    /// <summary>
    /// 获取或者设置批次库存主键
    /// </summary>
    [MaxLength(100)]
    [Column("dihtimerdn", Order = 153)]
    public string Dihtimerdn { get; set; }
    /// <summary>
    /// 获取或者设置原因
    /// </summary>
    [MaxLength(40)]
    [Column("reason", Order = 154)]
    public string Reason { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("flag", Order = 155)]
    public string Flag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("todeptnum", Order = 156)]
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