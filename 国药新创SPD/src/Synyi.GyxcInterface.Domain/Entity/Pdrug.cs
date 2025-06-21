namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医嘱明细
/// </summary>
[Table("pdrug")]
[PrimaryKey(nameof(Stay), nameof(Orderflag), nameof(Orderno))]
public sealed class Pdrug : EqualObject
{
    /// <summary>
    /// 获取或者设置发药时间
    /// </summary>
    [Column("dodate", Order = 100)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置长嘱：首日（1<=首日<=频度.many）
    /// </summary>
    [Column("FirstMany", Order = 101)]
    public int? FirstMany { get; set; }
    /// <summary>
    /// 获取或者设置预防用药切口等级
    /// </summary>
    [MaxLength(1)]
    [Column("prevention_incision", Order = 102)]
    public string PreventionIncision { get; set; }
    /// <summary>
    /// 获取或者设置就诊来源
    /// </summary>
    [MaxLength(1)]
    [Required]
    [Column("stay", Order = 103)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置医嘱分类
    /// </summary>
    [MaxLength(50)]
    [Required]
    [Column("orderflag", Order = 104)]
    public string Orderflag { get; set; }
    /// <summary>
    /// 获取或者设置医嘱号1
    /// </summary>
    [Required]
    [Column("orderno", Order = 105)]
    public int Orderno { get; set; }
    /// <summary>
    /// 获取或者设置执行次数
    /// </summary>
    [Column("domany", Order = 106)]
    public int? Domany { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 107)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊序号
    /// </summary>
    [Column("series", Order = 108)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置医嘱代码
    /// </summary>
    [MaxLength(20)]
    [Column("drcode", Order = 109)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置医嘱排列序号
    /// </summary>
    [Column("abc", Order = 110)]
    public int? Abc { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(50)]
    [Column("packunit", Order = 111)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装系数
    /// </summary>
    [Column("pack", Order = 112)]
    public int? Pack { get; set; }
    /// <summary>
    /// 获取或者设置产地
    /// </summary>
    [Column("manfcode", Order = 113)]
    public int? Manfcode { get; set; }
    /// <summary>
    /// 获取或者设置医嘱名称
    /// </summary>
    [MaxLength(100)]
    [Column("drname", Order = 114)]
    public string Drname { get; set; }
    /// <summary>
    /// 获取或者设置规格
    /// </summary>
    [MaxLength(100)]
    [Column("drmodel", Order = 115)]
    public string Drmodel { get; set; }
    /// <summary>
    /// 获取或者设置最小单位
    /// </summary>
    [MaxLength(50)]
    [Column("drunit", Order = 116)]
    public string Drunit { get; set; }
    /// <summary>
    /// 获取或者设置每次剂量
    /// </summary>
    [MaxLength(50)]
    [Column("dosage", Order = 117)]
    public string Dosage { get; set; }
    /// <summary>
    /// 获取或者设置用法
    /// </summary>
    [MaxLength(8)]
    [Column("admission", Order = 118)]
    public string Admission { get; set; }
    /// <summary>
    /// 获取或者设置频度
    /// </summary>
    [MaxLength(50)]
    [Column("frequency", Order = 119)]
    public string Frequency { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类型
    /// </summary>
    [MaxLength(1)]
    [Column("ordertype", Order = 120)]
    public string Ordertype { get; set; }
    /// <summary>
    /// 获取或者设置输入日期
    /// </summary>
    [Column("datein", Order = 121)]
    public DateTime? Datein { get; set; }
    /// <summary>
    /// 获取或者设置起始日期
    /// </summary>
    [Column("datestart", Order = 122)]
    public DateTime? Datestart { get; set; }
    /// <summary>
    /// 获取或者设置停止日期
    /// </summary>
    [Column("datestop", Order = 123)]
    public DateTime? Datestop { get; set; }
    /// <summary>
    /// 获取或者设置下次执行时间
    /// </summary>
    [Column("datenext", Order = 124)]
    public DateTime? Datenext { get; set; }
    /// <summary>
    /// 获取或者设置接收日期
    /// </summary>
    [Column("dateaccept", Order = 125)]
    public DateTime? Dateaccept { get; set; }
    /// <summary>
    /// 获取或者设置执行日期
    /// </summary>
    [Column("datedo", Order = 126)]
    public DateTime? Datedo { get; set; }
    /// <summary>
    /// 获取或者设置执行人
    /// </summary>
    [MaxLength(20)]
    [Column("dojp", Order = 127)]
    public string Dojp { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(16, 4)]
    [Column("dosageday", Order = 128)]
    public decimal? Dosageday { get; set; }
    /// <summary>
    /// 获取或者设置总数量
    /// </summary>
    [Precision(16, 4)]
    [Column("totala", Order = 129)]
    public decimal? Totala { get; set; }
    /// <summary>
    /// 获取或者设置总金额
    /// </summary>
    [Precision(16, 4)]
    [Column("totalfee", Order = 130)]
    public decimal? Totalfee { get; set; }
    /// <summary>
    /// 获取或者设置当前实发
    /// </summary>
    [Precision(16, 4)]
    [Column("realsent", Order = 131)]
    public decimal? Realsent { get; set; }
    /// <summary>
    /// 获取或者设置下医嘱部门
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 132)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置医嘱走向
    /// </summary>
    [MaxLength(20)]
    [Column("todept", Order = 133)]
    public string Todept { get; set; }
    /// <summary>
    /// 获取或者设置床号
    /// </summary>
    [MaxLength(20)]
    [Column("bedid", Order = 134)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 135)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置护士
    /// </summary>
    [MaxLength(20)]
    [Column("nsin", Order = 136)]
    public string Nsin { get; set; }
    /// <summary>
    /// 获取或者设置停方护士
    /// </summary>
    [MaxLength(20)]
    [Column("nsstop", Order = 137)]
    public string Nsstop { get; set; }
    /// <summary>
    /// 获取或者设置审定
    /// </summary>
    [MaxLength(20)]
    [Column("ph", Order = 138)]
    public string Ph { get; set; }
    /// <summary>
    /// 获取或者设置执行标志
    /// </summary>
    [MaxLength(1)]
    [Column("doflag", Order = 139)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置发药标志
    /// </summary>
    [MaxLength(1)]
    [Column("distrbute", Order = 140)]
    public string Distrbute { get; set; }
    /// <summary>
    /// 获取或者设置审核标志
    /// </summary>
    [MaxLength(1)]
    [Column("checkflag", Order = 141)]
    public string Checkflag { get; set; }
    /// <summary>
    /// 获取或者设置特殊药品标志
    /// </summary>
    [MaxLength(1)]
    [Column("specialflag", Order = 142)]
    public string Specialflag { get; set; }
    /// <summary>
    /// 获取或者设置皮试标志
    /// </summary>
    [MaxLength(1)]
    [Column("drugtest", Order = 143)]
    public string Drugtest { get; set; }
    /// <summary>
    /// 获取或者设置组方号
    /// </summary>
    [Column("setno", Order = 144)]
    public int? Setno { get; set; }
    /// <summary>
    /// 获取或者设置理由
    /// </summary>
    [MaxLength(3)]
    [Column("resean", Order = 145)]
    public string Resean { get; set; }
    /// <summary>
    /// 获取或者设置病人姓名
    /// </summary>
    [MaxLength(50)]
    [Column("pname", Order = 146)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置在院标志
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 147)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(400)]
    [Column("mark", Order = 148)]
    public string Mark { get; set; }
    /// <summary>
    /// 获取或者设置帖数
    /// </summary>
    [Column("setnumb", Order = 149)]
    public int? Setnumb { get; set; }
    /// <summary>
    /// 获取或者设置预退
    /// </summary>
    [Precision(16, 4)]
    [Column("preback", Order = 150)]
    public decimal? Preback { get; set; }
    /// <summary>
    /// 获取或者设置当前包装单位
    /// </summary>
    [MaxLength(50)]
    [Column("oppackunit", Order = 151)]
    public string Oppackunit { get; set; }
    /// <summary>
    /// 获取或者设置当前包装规格
    /// </summary>
    [Precision(16, 4)]
    [Column("oppack", Order = 152)]
    public decimal? Oppack { get; set; }
    /// <summary>
    /// 获取或者设置内部账单号
    /// </summary>
    [Column("interid", Order = 153)]
    public int? Interid { get; set; }
    /// <summary>
    /// 获取或者设置皮试护士
    /// </summary>
    [MaxLength(20)]
    [Column("testns", Order = 154)]
    public string Testns { get; set; }
    /// <summary>
    /// 获取或者设置皮试结果
    /// </summary>
    [MaxLength(1)]
    [Column("testdo", Order = 155)]
    public string Testdo { get; set; }
    /// <summary>
    /// 获取或者设置自付
    /// </summary>
    [MaxLength(5)]
    [Column("selfpaid", Order = 156)]
    public string Selfpaid { get; set; }
    /// <summary>
    /// 获取或者设置申请单号
    /// </summary>
    [Column("askno", Order = 157)]
    public int? Askno { get; set; }
    /// <summary>
    /// 获取或者设置报告单号
    /// </summary>
    [Column("reportno", Order = 158)]
    public int? Reportno { get; set; }
    /// <summary>
    /// 获取或者设置药品大分类
    /// </summary>
    [MaxLength(50)]
    [Column("drchina", Order = 159)]
    public string Drchina { get; set; }
    /// <summary>
    /// 获取或者设置处方号
    /// </summary>
    [MaxLength(50)]
    [Column("pageno", Order = 160)]
    public string Pageno { get; set; }
    /// <summary>
    /// 获取或者设置结算
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 161)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置效期
    /// </summary>
    [Column("duration", Order = 162)]
    public int? Duration { get; set; }
    /// <summary>
    /// 获取或者设置给药原因
    /// </summary>
    [MaxLength(5)]
    [Column("reason", Order = 163)]
    public string Reason { get; set; }
    /// <summary>
    /// 获取或者设置高危药品标志
    /// </summary>
    [MaxLength(3)]
    [Column("riskflag", Order = 164)]
    public string Riskflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("bdtno", Order = 165)]
    public int? Bdtno { get; set; }
    /// <summary>
    /// 获取或者设置药品计量单位
    /// </summary>
    [MaxLength(10)]
    [Column("sunit", Order = 166)]
    public string Sunit { get; set; }
    /// <summary>
    /// 获取或者设置药品最小计量
    /// </summary>
    [Precision(19, 4)]
    [Column("snumb", Order = 167)]
    public decimal? Snumb { get; set; }
    /// <summary>
    /// 获取或者设置开单院区
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 168)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置执行院区
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 169)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置同步时间
    /// </summary>
    [Column("hostrandt", Order = 170)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置同步标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 171)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("antiv", Order = 172)]
    public string Antiv { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("tflag", Order = 173)]
    public string Tflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("checkdt", Order = 174)]
    public DateTime? Checkdt { get; set; }
    /// <summary>
    /// 获取或者设置预开用药
    /// </summary>
    [MaxLength(1)]
    [Column("isfuture", Order = 175)]
    public string Isfuture { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(256)]
    [Column("cacode", Order = 176)]
    public string Cacode { get; set; }
    /// <summary>
    /// 获取或者设置药房代码
    /// </summary>
    [MaxLength(20)]
    [Column("pharmdept", Order = 177)]
    public string Pharmdept { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("BGprintflag", Order = 178)]
    public int? BGprintflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("pivcheckerdate", Order = 179)]
    public DateTime? Pivcheckerdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("pivchecker", Order = 180)]
    public string Pivchecker { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("narno", Order = 181)]
    public string Narno { get; set; }
    /// <summary>
    /// 获取或者设置医嘱号
    /// </summary>
    [Column("clinicreportorderno", Order = 182)]
    public int? Clinicreportorderno { get; set; }
    /// <summary>
    /// 获取或者设置抗生素授权人
    /// </summary>
    [MaxLength(20)]
    [Column("AntibioyicAuthor", Order = 183)]
    public string AntibioyicAuthor { get; set; }
    /// <summary>
    /// 获取或者设置嘱托
    /// </summary>
    [MaxLength(500)]
    [Column("entrust", Order = 184)]
    public string Entrust { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("cease", Order = 185)]
    public string Cease { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isC7Day", Order = 186)]
    public string IsC7Day { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("YHXFlag", Order = 187)]
    public string YHXFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("relatedr", Order = 188)]
    public string Relatedr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("relateno", Order = 189)]
    public string Relateno { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("APPID", Order = 190)]
    public string APPID { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ReviewFlag", Order = 191)]
    public string ReviewFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("ReviewMark", Order = 192)]
    public string ReviewMark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("urgent", Order = 193)]
    public int? Urgent { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ReviewFlaghis", Order = 194)]
    public string ReviewFlaghis { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("infusion_rate", Order = 195)]
    public string InfusionRate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("DangerRdn", Order = 196)]
    public string DangerRdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("AntiTip", Order = 197)]
    public string AntiTip { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("ApplyBackMany", Order = 198)]
    public decimal? ApplyBackMany { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("pdrug_insucode", Order = 199)]
    public string PdrugInsucode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("Antiflag", Order = 200)]
    public string Antiflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("acupoints", Order = 201)]
    public string Acupoints { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cisxh", Order = 202)]
    public long? Cisxh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cismxxh", Order = 203)]
    public long? Cismxxh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cisxhlb", Order = 204)]
    public int? Cisxhlb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cislybz", Order = 205)]
    public int? Cislybz { get; set; }
    /// <summary>
    /// 获取或者设置自费标志
    /// </summary>
    [Column("zfbz", Order = 206)]
    public int? Zfbz { get; set; }
    /// <summary>
    /// 获取或者设置自备标志
    /// </summary>
    [Column("zbbz", Order = 207)]
    public int? Zbbz { get; set; }
    /// <summary>
    /// 获取或者设置高值耗材编码
    /// </summary>
    [MaxLength(64)]
    [Column("gzhcbm", Order = 208)]
    public string Gzhcbm { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Stay;
        yield return Orderflag;
        yield return Orderno;
    }
}