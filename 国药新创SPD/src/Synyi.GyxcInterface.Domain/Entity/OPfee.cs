namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 门诊费用明细
/// </summary>
[Table("o_pfee")]
[PrimaryKey(nameof(Rdn), nameof(Stay))]
public sealed class OPfee : EqualObject
{

    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 100)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Required]
    [Column("stay", Order = 101)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(3)]
    [Column("orderflag", Order = 102)]
    public string Orderflag { get; set; }
    /// <summary>
    /// 获取或者设置医嘱号
    /// </summary>
    [Required]
    [Column("orderno", Order = 103)]
    public int Orderno { get; set; }
    /// <summary>
    /// 获取或者设置执行次数
    /// </summary>
    [Required]
    [Column("domany", Order = 104)]
    public int Domany { get; set; }
    /// <summary>
    /// 获取或者设置机内号
    /// </summary>
    [Column("interid", Order = 105)]
    public int? Interid { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 106)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 107)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置收费代码
    /// </summary>
    [MaxLength(18)]
    [Column("fcode", Order = 108)]
    public string Fcode { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(16, 4)]
    [Column("many", Order = 109)]
    public decimal? Many { get; set; }
    /// <summary>
    /// 获取或者设置总金额
    /// </summary>
    [Precision(16, 4)]
    [Column("fee", Order = 110)]
    public decimal? Fee { get; set; }
    /// <summary>
    /// 获取或者设置自费金额
    /// </summary>
    [Precision(16, 4)]
    [Column("feez", Order = 111)]
    public decimal? Feez { get; set; }
    /// <summary>
    /// 获取或者设置开单科室
    /// </summary>
    [MaxLength(20)]
    [Column("cdept", Order = 112)]
    public string Cdept { get; set; }
    /// <summary>
    /// 获取或者设置执行科室
    /// </summary>
    [MaxLength(20)]
    [Column("rdept", Order = 113)]
    public string Rdept { get; set; }
    /// <summary>
    /// 获取或者设置医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 114)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置结算人
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 115)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置开单时间
    /// </summary>
    [Column("cdate", Order = 116)]
    public DateTime? Cdate { get; set; }
    /// <summary>
    /// 获取或者设置结算日期
    /// </summary>
    [Column("jsdate", Order = 117)]
    public DateTime? Jsdate { get; set; }
    /// <summary>
    /// 获取或者设置结算标记
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 118)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置发票流水号
    /// </summary>
    [Column("fbid", Order = 119)]
    public int? Fbid { get; set; }
    /// <summary>
    /// 获取或者设置费用类别
    /// </summary>
    [MaxLength(2)]
    [Column("ftype", Order = 120)]
    public string Ftype { get; set; }
    /// <summary>
    /// 获取或者设置项目名称
    /// </summary>
    [MaxLength(200)]
    [Column("remark", Order = 121)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置执行时间
    /// </summary>
    [Column("rdate", Order = 122)]
    public DateTime? Rdate { get; set; }
    /// <summary>
    /// 获取或者设置就诊科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptin", Order = 123)]
    public string Deptin { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(8)]
    [Column("unit", Order = 124)]
    public string Unit { get; set; }
    /// <summary>
    /// 获取或者设置审批编号
    /// </summary>
    [MaxLength(20)]
    [Column("allow", Order = 125)]
    public string Allow { get; set; }
    /// <summary>
    /// 获取或者设置医保上传标记
    /// </summary>
    [MaxLength(1)]
    [Column("transflag", Order = 126)]
    public string Transflag { get; set; }
    /// <summary>
    /// 获取或者设置是否被退药
    /// </summary>
    [MaxLength(1)]
    [Column("backflag", Order = 127)]
    public string Backflag { get; set; }
    /// <summary>
    /// 获取或者设置负记录对应正记录主键
    /// </summary>
    [Column("backabc", Order = 128)]
    public int? Backabc { get; set; }
    /// <summary>
    /// 获取或者设置已取药标志
    /// </summary>
    [MaxLength(1)]
    [Column("getflag", Order = 129)]
    public string Getflag { get; set; }
    /// <summary>
    /// 获取或者设置退标志
    /// </summary>
    [MaxLength(20)]
    [Column("deptdo", Order = 130)]
    public string Deptdo { get; set; }
    /// <summary>
    /// 获取或者设置零售价
    /// </summary>
    [Precision(16, 4)]
    [Column("npl", Order = 131)]
    public decimal? Npl { get; set; }
    /// <summary>
    /// 获取或者设置进价
    /// </summary>
    [Precision(16, 4)]
    [Column("punits", Order = 132)]
    public decimal? Punits { get; set; }
    /// <summary>
    /// 获取或者设置项目代码
    /// </summary>
    [MaxLength(18)]
    [Column("drcode", Order = 133)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(8)]
    [Column("packunit", Order = 134)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装系数
    /// </summary>
    [Column("pack", Order = 135)]
    public int? Pack { get; set; }
    /// <summary>
    /// 获取或者设置产地代码
    /// </summary>
    [Column("manfcode", Order = 136)]
    public int? Manfcode { get; set; }
    /// <summary>
    /// 获取或者设置门诊换算单位
    /// </summary>
    [MaxLength(8)]
    [Column("oppackunit", Order = 137)]
    public string Oppackunit { get; set; }
    /// <summary>
    /// 获取或者设置门诊换算系数
    /// </summary>
    [Precision(16, 4)]
    [Column("oppack", Order = 138)]
    public decimal? Oppack { get; set; }
    /// <summary>
    /// 获取或者设置账页号
    /// </summary>
    [Column("abc", Order = 139)]
    public int? Abc { get; set; }
    /// <summary>
    /// 获取或者设置收费标志
    /// </summary>
    [MaxLength(1)]
    [Column("chargeflag", Order = 140)]
    public string Chargeflag { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别1
    /// </summary>
    [MaxLength(3)]
    [Column("itemtype", Order = 141)]
    public string Itemtype { get; set; }
    /// <summary>
    /// 获取或者设置关联医嘱明细表主键
    /// </summary>
    [Column("iorderno", Order = 142)]
    public int? Iorderno { get; set; }
    /// <summary>
    /// 获取或者设置冲账标志
    /// </summary>
    [MaxLength(1)]
    [Column("backdo", Order = 143)]
    public string Backdo { get; set; }
    /// <summary>
    /// 获取或者设置发药人
    /// </summary>
    [MaxLength(20)]
    [Column("ph", Order = 144)]
    public string Ph { get; set; }
    /// <summary>
    /// 获取或者设置发药日期
    /// </summary>
    [Column("dodate", Order = 145)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置处方号
    /// </summary>
    [Column("drugno", Order = 146)]
    public int? Drugno { get; set; }
    /// <summary>
    /// 获取或者设置贴数
    /// </summary>
    [Column("setnumb", Order = 147)]
    public int? Setnumb { get; set; }
    /// <summary>
    /// 获取或者设置退药数量
    /// </summary>
    [Precision(16, 4)]
    [Column("preback", Order = 148)]
    public decimal? Preback { get; set; }
    /// <summary>
    /// 获取或者设置检验检验表主键
    /// </summary>
    [MaxLength(1)]
    [Column("clinicin", Order = 149)]
    public string Clinicin { get; set; }
    /// <summary>
    /// 获取或者设置药品批号主键
    /// </summary>
    [MaxLength(100)]
    [Column("dihtimerdn", Order = 150)]
    public string Dihtimerdn { get; set; }
    /// <summary>
    /// 获取或者设置报表标记
    /// </summary>
    [MaxLength(1)]
    [Column("reportflag", Order = 151)]
    public string Reportflag { get; set; }
    /// <summary>
    /// 获取或者设置报表号
    /// </summary>
    [Column("reportno", Order = 152)]
    public int? Reportno { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(12)]
    [Column("dj", Order = 153)]
    public string Dj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("gbh", Order = 154)]
    public int? Gbh { get; set; }
    /// <summary>
    /// 获取或者设置自付比例（住院）
    /// </summary>
    [MaxLength(5)]
    [Column("zyffbl", Order = 155)]
    public string Zyffbl { get; set; }
    /// <summary>
    /// 获取或者设置自付比例
    /// </summary>
    [MaxLength(6)]
    [Column("zfbl", Order = 156)]
    public string Zfbl { get; set; }
    /// <summary>
    /// 获取或者设置医保限定内容
    /// </summary>
    [MaxLength(100)]
    [Column("ybxdmark", Order = 157)]
    public string Ybxdmark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("CLflag", Order = 158)]
    public string CLflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(15, 0)]
    [Column("CLabcormany", Order = 159)]
    public decimal? CLabcormany { get; set; }
    /// <summary>
    /// 获取或者设置自费标志
    /// </summary>
    [MaxLength(1)]
    [Column("selfpaid", Order = 160)]
    public string Selfpaid { get; set; }
    /// <summary>
    /// 获取或者设置医保码
    /// </summary>
    [MaxLength(50)]
    [Column("insucode", Order = 161)]
    public string Insucode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("bj2flag", Order = 162)]
    public string Bj2flag { get; set; }
    /// <summary>
    /// 获取或者设置挂号/收费
    /// </summary>
    [MaxLength(1)]
    [Column("registerflag", Order = 163)]
    public string Registerflag { get; set; }
    /// <summary>
    /// 获取或者设置上传的医保码
    /// </summary>
    [MaxLength(50)]
    [Column("transinsucode", Order = 164)]
    public string Transinsucode { get; set; }
    /// <summary>
    /// 获取或者设置费用上传人
    /// </summary>
    [MaxLength(50)]
    [Column("transjp", Order = 165)]
    public string Transjp { get; set; }
    /// <summary>
    /// 获取或者设置费用上传时间
    /// </summary>
    [Column("transdt", Order = 166)]
    public DateTime? Transdt { get; set; }
    /// <summary>
    /// 获取或者设置执行院区
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 167)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置院区
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 168)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置结算院区
    /// </summary>
    [MaxLength(20)]
    [Column("jshoscode", Order = 169)]
    public string Jshoscode { get; set; }
    /// <summary>
    /// 获取或者设置主管医生
    /// </summary>
    [MaxLength(18)]
    [Column("attending", Order = 170)]
    public string Attending { get; set; }
    /// <summary>
    /// 获取或者设置信息来源
    /// </summary>
    [MaxLength(5)]
    [Column("appid", Order = 171)]
    public string Appid { get; set; }
    /// <summary>
    /// 获取或者设置扩展表主键
    /// </summary>
    [Column("basesubid", Order = 172)]
    public int? Basesubid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("feey", Order = 173)]
    public decimal? Feey { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("zkbl", Order = 174)]
    public decimal? Zkbl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("ymxm", Order = 175)]
    public string Ymxm { get; set; }
    /// <summary>
    /// 获取或者设置物资批次号
    /// </summary>
    [MaxLength(32)]
    [Column("hrpwzpch", Order = 176)]
    public string HrpWzPch { get; set; }
    /// <summary>
    /// 获取或者设置物资发放标志 1-待发放 2-已发放
    /// </summary>
    [Column("hrpexeflag", Order = 177)]
    public int? HrpExeFlag { get; set; }
    /// <summary>
    /// 获取或者设置物资请领单标志
    /// </summary>
    [Column("hrpqldbz", Order = 178)]
    public int? HrpQldbz { get; set; }
    /// <summary>
    /// 获取或者设置物资请领单标识
    /// </summary>
    [Column("hrpqldid", Order = 179)]
    public long? HrpQldId { get; set; }
    /// <summary>
    /// 获取或者设置物资出库单标识
    /// </summary>
    [Column("hrpckdid", Order = 180)]
    public long? HrpCkdId { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
        yield return Stay;
    }

}
