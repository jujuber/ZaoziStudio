namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 门诊结算账单
/// </summary>
[Table("k_pafpaid")]
[PrimaryKey(nameof(Fbid), nameof(Registerflag))]
public sealed class KPafpaid : EqualObject
{
    /// <summary>
    /// 获取或者设置医保交易流水号
    /// </summary>
    [MaxLength(50)]
    [Column("dealid", Order = 100)]
    public string Dealid { get; set; }
    /// <summary>
    /// 获取或者设置发票流水号
    /// </summary>
    [Required]
    [Column("fbid", Order = 101)]
    public int Fbid { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Required]
    [Column("mrn", Order = 102)]
    public int Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Required]
    [Column("series", Order = 103)]
    public int Series { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 104)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置病人类别
    /// </summary>
    [MaxLength(2)]
    [Required]
    [Column("service", Order = 105)]
    public string Service { get; set; }
    /// <summary>
    /// 获取或者设置总金额
    /// </summary>
    [Precision(16, 4)]
    [Column("patotal", Order = 106)]
    public decimal? Patotal { get; set; }
    /// <summary>
    /// 获取或者设置自付金额
    /// </summary>
    [Precision(16, 4)]
    [Column("pjtotal", Order = 107)]
    public decimal? Pjtotal { get; set; }
    /// <summary>
    /// 获取或者设置预缴款
    /// </summary>
    [Precision(16, 4)]
    [Column("papref", Order = 108)]
    public decimal? Papref { get; set; }
    /// <summary>
    /// 获取或者设置现金支付
    /// </summary>
    [Precision(16, 4)]
    [Column("pacash", Order = 109)]
    public decimal? Pacash { get; set; }
    /// <summary>
    /// 获取或者设置支票支付
    /// </summary>
    [Precision(16, 4)]
    [Column("pacheck", Order = 110)]
    public decimal? Pacheck { get; set; }
    /// <summary>
    /// 获取或者设置信用卡支付
    /// </summary>
    [Precision(16, 4)]
    [Column("pdcredit", Order = 111)]
    public decimal? Pdcredit { get; set; }
    /// <summary>
    /// 获取或者设置其他支付
    /// </summary>
    [Precision(16, 4)]
    [Column("paother", Order = 112)]
    public decimal? Paother { get; set; }
    /// <summary>
    /// 获取或者设置统筹金额
    /// </summary>
    [Precision(16, 4)]
    [Column("paregia", Order = 113)]
    public decimal? Paregia { get; set; }
    /// <summary>
    /// 获取或者设置大病救助
    /// </summary>
    [Precision(16, 4)]
    [Column("paregib", Order = 114)]
    public decimal? Paregib { get; set; }
    /// <summary>
    /// 获取或者设置公务员
    /// </summary>
    [Precision(16, 4)]
    [Column("paregic", Order = 115)]
    public decimal? Paregic { get; set; }
    /// <summary>
    /// 获取或者设置医保支付
    /// </summary>
    [Precision(16, 4)]
    [Column("painsu", Order = 116)]
    public decimal? Painsu { get; set; }
    /// <summary>
    /// 获取或者设置欠费
    /// </summary>
    [Precision(16, 4)]
    [Column("pacf", Order = 117)]
    public decimal? Pacf { get; set; }
    /// <summary>
    /// 获取或者设置补交
    /// </summary>
    [Precision(16, 4)]
    [Column("papf", Order = 118)]
    public decimal? Papf { get; set; }
    /// <summary>
    /// 获取或者设置结算人
    /// </summary>
    [MaxLength(20)]
    [Column("pajp", Order = 119)]
    public string Pajp { get; set; }
    /// <summary>
    /// 获取或者设置出院日期
    /// </summary>
    [Column("padd", Order = 120)]
    public DateTime? Padd { get; set; }
    /// <summary>
    /// 获取或者设置登记日期
    /// </summary>
    [Column("pard", Order = 121)]
    public DateTime? Pard { get; set; }
    /// <summary>
    /// 获取或者设置结账日期
    /// </summary>
    [Column("padate", Order = 122)]
    public DateTime? Padate { get; set; }
    /// <summary>
    /// 获取或者设置结算标记
    /// </summary>
    [MaxLength(1)]
    [Column("jzflag", Order = 123)]
    public string Jzflag { get; set; }
    /// <summary>
    /// 获取或者设置明细顺序
    /// </summary>
    [Column("abc", Order = 124)]
    public int? Abc { get; set; }
    /// <summary>
    /// 获取或者设置退支号
    /// </summary>
    [Column("returncheck", Order = 125)]
    public int? Returncheck { get; set; }
    /// <summary>
    /// 获取或者设置是否已作报表
    /// </summary>
    [MaxLength(1)]
    [Column("reportflag", Order = 126)]
    public string Reportflag { get; set; }
    /// <summary>
    /// 获取或者设置报表号
    /// </summary>
    [Column("reportno", Order = 127)]
    public int? Reportno { get; set; }
    /// <summary>
    /// 获取或者设置就诊科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 128)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置医保卡号
    /// </summary>
    [MaxLength(30)]
    [Column("insucode", Order = 129)]
    public string Insucode { get; set; }
    /// <summary>
    /// 获取或者设置单位编码
    /// </summary>
    [MaxLength(15)]
    [Column("unitid", Order = 130)]
    public string Unitid { get; set; }
    /// <summary>
    /// 获取或者设置病人姓名
    /// </summary>
    [MaxLength(100)]
    [Column("pname", Order = 131)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置本年支付
    /// </summary>
    [Precision(16, 4)]
    [Column("paty", Order = 132)]
    public decimal? Paty { get; set; }
    /// <summary>
    /// 获取或者设置历年支付
    /// </summary>
    [Precision(16, 4)]
    [Column("paly", Order = 133)]
    public decimal? Paly { get; set; }
    /// <summary>
    /// 获取或者设置账户余额
    /// </summary>
    [Precision(16, 4)]
    [Column("pakye", Order = 134)]
    public decimal? Pakye { get; set; }
    /// <summary>
    /// 获取或者设置人员类别
    /// </summary>
    [MaxLength(10)]
    [Column("insukind", Order = 135)]
    public string Insukind { get; set; }
    /// <summary>
    /// 获取或者设置就诊类型
    /// </summary>
    [MaxLength(10)]
    [Column("stayinsu", Order = 136)]
    public string Stayinsu { get; set; }
    /// <summary>
    /// 获取或者设置医保单位类别
    /// </summary>
    [MaxLength(10)]
    [Column("unittype", Order = 137)]
    public string Unittype { get; set; }
    /// <summary>
    /// 获取或者设置医保交易号
    /// </summary>
    [MaxLength(30)]
    [Column("flowid", Order = 138)]
    public string Flowid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("tfbid", Order = 139)]
    public int? Tfbid { get; set; }
    /// <summary>
    /// 获取或者设置单位名称
    /// </summary>
    [MaxLength(50)]
    [Column("unit", Order = 140)]
    public string Unit { get; set; }
    /// <summary>
    /// 获取或者设置上传标志
    /// </summary>
    [MaxLength(1)]
    [Column("transflag", Order = 141)]
    public string Transflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(16)]
    [Column("pacashm", Order = 142)]
    public string Pacashm { get; set; }
    /// <summary>
    /// 获取或者设置离休
    /// </summary>
    [Precision(4, 0)]
    [Column("lixiu", Order = 143)]
    public decimal? Lixiu { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("pagecount", Order = 144)]
    public int? Pagecount { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 2)]
    [Column("knbzjj", Order = 145)]
    public decimal? Knbzjj { get; set; }
    /// <summary>
    /// 获取或者设置挂号R收费C标志
    /// </summary>
    [MaxLength(1)]
    [Required]
    [Column("registerflag", Order = 146)]
    public string Registerflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("refmsgid", Order = 147)]
    public string Refmsgid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("clinicnum", Order = 148)]
    public string Clinicnum { get; set; }
    /// <summary>
    /// 获取或者设置发票号码
    /// </summary>
    [Precision(18, 0)]
    [Column("invoiceno", Order = 149)]
    public decimal? Invoiceno { get; set; }
    /// <summary>
    /// 获取或者设置发票张数
    /// </summary>
    [Precision(18, 0)]
    [Column("invoicecount", Order = 150)]
    public decimal? Invoicecount { get; set; }
    /// <summary>
    /// 获取或者设置医保结算主键
    /// </summary>
    [MaxLength(50)]
    [Column("ybid", Order = 151)]
    public string Ybid { get; set; }
    /// <summary>
    /// 获取或者设置地区编码
    /// </summary>
    [MaxLength(10)]
    [Column("dqbm", Order = 152)]
    public string Dqbm { get; set; }
    /// <summary>
    /// 获取或者设置是否打印
    /// </summary>
    [MaxLength(1)]
    [Column("isPrint", Order = 153)]
    public string IsPrint { get; set; }
    /// <summary>
    /// 获取或者设置打印编码
    /// </summary>
    [MaxLength(50)]
    [Column("isPrintCode", Order = 154)]
    public string IsPrintCode { get; set; }
    /// <summary>
    /// 获取或者设置银行刘说好
    /// </summary>
    [Column("bankrdn", Order = 155)]
    public int? Bankrdn { get; set; }
    /// <summary>
    /// 获取或者设置医保自付更新标志
    /// </summary>
    [MaxLength(1)]
    [Column("ybzfupflag", Order = 156)]
    public string Ybzfupflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("xz", Order = 157)]
    public string Xz { get; set; }
    /// <summary>
    /// 获取或者设置渠道
    /// </summary>
    [MaxLength(30)]
    [Column("platform", Order = 158)]
    public string Platform { get; set; }
    /// <summary>
    /// 获取或者设置交易编码
    /// </summary>
    [MaxLength(30)]
    [Column("tradeNo", Order = 159)]
    public string TradeNo { get; set; }
    /// <summary>
    /// 获取或者设置支付时间
    /// </summary>
    [MaxLength(30)]
    [Column("payTime", Order = 160)]
    public string PayTime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("account", Order = 161)]
    public string Account { get; set; }
    /// <summary>
    /// 获取或者设置支付渠道
    /// </summary>
    [MaxLength(30)]
    [Column("payChannel", Order = 162)]
    public string PayChannel { get; set; }
    /// <summary>
    /// 获取或者设置结算来源
    /// </summary>
    [MaxLength(2)]
    [Column("jsWay", Order = 163)]
    public string JsWay { get; set; }
    /// <summary>
    /// 获取或者设置银行交易流水号
    /// </summary>
    [MaxLength(100)]
    [Column("bankTradeid", Order = 164)]
    public string BankTradeid { get; set; }
    /// <summary>
    /// 获取或者设置交易流水号
    /// </summary>
    [MaxLength(50)]
    [Column("tradeid", Order = 165)]
    public string Tradeid { get; set; }
    /// <summary>
    /// 获取或者设置院区
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 166)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置序列号
    /// </summary>
    [MaxLength(50)]
    [Column("requestserialid", Order = 167)]
    public string Requestserialid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("zfscflag", Order = 168)]
    public string Zfscflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isneedtrans", Order = 169)]
    public string Isneedtrans { get; set; }
    /// <summary>
    /// 获取或者设置减免金额
    /// </summary>
    [Precision(18, 2)]
    [Column("jmje", Order = 170)]
    public decimal? Jmje { get; set; }
    /// <summary>
    /// 获取或者设置his医保结算流水号
    /// </summary>
    [MaxLength(30)]
    [Column("payID", Order = 171)]
    public string PayID { get; set; }
    /// <summary>
    /// 获取或者设置支付类型2
    /// </summary>
    [MaxLength(3)]
    [Column("refmsgid2", Order = 172)]
    public string Refmsgid2 { get; set; }
    /// <summary>
    /// 获取或者设置电子发票上传标记
    /// </summary>
    [MaxLength(20)]
    [Column("isDzfp_Success", Order = 173)]
    public string IsDzfpSuccess { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("oldInterid", Order = 174)]
    public string OldInterid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isdzfp", Order = 175)]
    public string Isdzfp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("TraceNo", Order = 176)]
    public string TraceNo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("isdzpz", Order = 177)]
    public int? Isdzpz { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("freedrugsflag", Order = 178)]
    public string Freedrugsflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("freedrugsflagMsg", Order = 179)]
    public string FreedrugsflagMsg { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("chargeunit", Order = 180)]
    public string Chargeunit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("chargeremark", Order = 181)]
    public string Chargeremark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("TJUpLoadFlag", Order = 182)]
    public string TJUpLoadFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(255)]
    [Column("ChargeremarkDutyParagraph", Order = 183)]
    public string ChargeremarkDutyParagraph { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("jmtype", Order = 184)]
    public string Jmtype { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("InvoiceRemark", Order = 185)]
    public string InvoiceRemark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("orgTraceNo", Order = 186)]
    public string OrgTraceNo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(40)]
    [Column("traceId", Order = 187)]
    public string TraceId { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(40)]
    [Column("ampTraceId", Order = 188)]
    public string AmpTraceId { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("YbYdzfFlag", Order = 189)]
    public string YbYdzfFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("payChnlRefundsn", Order = 190)]
    public string PayChnlRefundsn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("payChnlOrdsn", Order = 191)]
    public string PayChnlOrdsn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("refundTraceId", Order = 192)]
    public string RefundTraceId { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("payOrdId", Order = 193)]
    public string PayOrdId { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Fbid;
        yield return Registerflag;
    }
}