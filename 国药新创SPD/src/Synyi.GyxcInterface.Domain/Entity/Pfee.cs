namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 住院费用明细
/// </summary>
[Table("pfee")]
[PrimaryKey(nameof(Rdn))]
public sealed class Pfee : EqualObject
{
    /// <summary>
    /// 获取或者设置报表号
    /// </summary>
    [Column("reportno", Order = 100)]
    public int? Reportno { get; set; }
    /// <summary>
    /// 获取或者设置已作报表标记
    /// </summary>
    [MaxLength(5)]
    [Column("reportflag", Order = 101)]
    public string Reportflag { get; set; }
    /// <summary>
    /// 获取或者设置做报表日期
    /// </summary>
    [Column("reportDate", Order = 102)]
    public DateTime? ReportDate { get; set; }
    /// <summary>
    /// 获取或者设置是否营样费
    /// </summary>
    [MaxLength(1)]
    [Column("nutritionflag", Order = 103)]
    public string Nutritionflag { get; set; }
    /// <summary>
    /// 获取或者设置明细编码（主键）
    /// </summary>
    [Required]
    [Column("rdn", Order = 104)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置就诊类别
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 105)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置费用类别
    /// </summary>
    [MaxLength(3)]
    [Column("orderflag", Order = 106)]
    public string Orderflag { get; set; }
    /// <summary>
    /// 获取或者设置医嘱号
    /// </summary>
    [Required]
    [Column("orderno", Order = 107)]
    public int Orderno { get; set; }
    /// <summary>
    /// 获取或者设置执行次数
    /// </summary>
    [Required]
    [Column("domany", Order = 108)]
    public int Domany { get; set; }
    /// <summary>
    /// 获取或者设置机内号
    /// </summary>
    [Required]
    [Column("interid", Order = 109)]
    public int Interid { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Required]
    [Column("mrn", Order = 110)]
    public int Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Required]
    [Column("series", Order = 111)]
    public int Series { get; set; }
    /// <summary>
    /// 获取或者设置诊疗编码
    /// </summary>
    [MaxLength(18)]
    [Column("fcode", Order = 112)]
    public string Fcode { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(16, 4)]
    [Required]
    [Column("many", Order = 113)]
    public decimal Many { get; set; }
    /// <summary>
    /// 获取或者设置金额
    /// </summary>
    [Precision(16, 4)]
    [Required]
    [Column("fee", Order = 114)]
    public decimal Fee { get; set; }
    /// <summary>
    /// 获取或者设置自付金额
    /// </summary>
    [Precision(16, 4)]
    [Required]
    [Column("feez", Order = 115)]
    public decimal Feez { get; set; }
    /// <summary>
    /// 获取或者设置执行科室
    /// </summary>
    [MaxLength(20)]
    [Column("cdept", Order = 116)]
    public string Cdept { get; set; }
    /// <summary>
    /// 获取或者设置记账科室
    /// </summary>
    [MaxLength(20)]
    [Column("rdept", Order = 117)]
    public string Rdept { get; set; }
    /// <summary>
    /// 获取或者设置医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 118)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置记账人员
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 119)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置执行日期
    /// </summary>
    [Column("cdate", Order = 120)]
    public DateTime? Cdate { get; set; }
    /// <summary>
    /// 获取或者设置结算日期
    /// </summary>
    [Column("jsdate", Order = 121)]
    public DateTime? Jsdate { get; set; }
    /// <summary>
    /// 获取或者设置结账标志  0：未结算，1：正常结算，3：欠费出院，8：出院召回
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 122)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置发票号
    /// </summary>
    [Column("fbid", Order = 123)]
    public int? Fbid { get; set; }
    /// <summary>
    /// 获取或者设置财务分类
    /// </summary>
    [MaxLength(2)]
    [Column("ftype", Order = 124)]
    public string Ftype { get; set; }
    /// <summary>
    /// 获取或者设置项目名称
    /// </summary>
    [MaxLength(200)]
    [Column("remark", Order = 125)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置记账日期
    /// </summary>
    [Column("rdate", Order = 126)]
    public DateTime? Rdate { get; set; }
    /// <summary>
    /// 获取或者设置就诊科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptin", Order = 127)]
    public string Deptin { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(10)]
    [Column("unit", Order = 128)]
    public string Unit { get; set; }
    /// <summary>
    /// 获取或者设置批准文号
    /// </summary>
    [MaxLength(20)]
    [Column("allow", Order = 129)]
    public string Allow { get; set; }
    /// <summary>
    /// 获取或者设置医农保上传明细标志
    /// </summary>
    [MaxLength(1)]
    [Column("transflag", Order = 130)]
    public string Transflag { get; set; }
    /// <summary>
    /// 获取或者设置退费标记
    /// </summary>
    [MaxLength(1)]
    [Column("backflag", Order = 131)]
    public string Backflag { get; set; }
    /// <summary>
    /// 获取或者设置负记录对应正记录主键
    /// </summary>
    [Column("backabc", Order = 132)]
    public int? Backabc { get; set; }
    /// <summary>
    /// 获取或者设置取药标志
    /// </summary>
    [MaxLength(1)]
    [Column("getflag", Order = 133)]
    public string Getflag { get; set; }
    /// <summary>
    /// 获取或者设置自备药
    /// </summary>
    [MaxLength(20)]
    [Column("deptdo", Order = 134)]
    public string Deptdo { get; set; }
    /// <summary>
    /// 获取或者设置单价
    /// </summary>
    [Precision(16, 4)]
    [Column("npl", Order = 135)]
    public decimal? Npl { get; set; }
    /// <summary>
    /// 获取或者设置进价
    /// </summary>
    [Precision(16, 4)]
    [Column("punits", Order = 136)]
    public decimal? Punits { get; set; }
    /// <summary>
    /// 获取或者设置药品材料编码
    /// </summary>
    [MaxLength(18)]
    [Column("drcode", Order = 137)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(8)]
    [Column("packunit", Order = 138)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装系数
    /// </summary>
    [Column("pack", Order = 139)]
    public int? Pack { get; set; }
    /// <summary>
    /// 获取或者设置产地代码
    /// </summary>
    [Column("manfcode", Order = 140)]
    public int? Manfcode { get; set; }
    /// <summary>
    /// 获取或者设置住院换算单位
    /// </summary>
    [MaxLength(8)]
    [Column("oppackunit", Order = 141)]
    public string Oppackunit { get; set; }
    /// <summary>
    /// 获取或者设置住院换算系数
    /// </summary>
    [Precision(16, 4)]
    [Column("oppack", Order = 142)]
    public decimal? Oppack { get; set; }
    /// <summary>
    /// 获取或者设置顺序号码
    /// </summary>
    [Column("abc", Order = 143)]
    public int? Abc { get; set; }
    /// <summary>
    /// 获取或者设置收费标志
    /// </summary>
    [MaxLength(1)]
    [Column("chargeflag", Order = 144)]
    public string Chargeflag { get; set; }
    /// <summary>
    /// 获取或者设置项目类型
    /// </summary>
    [MaxLength(3)]
    [Column("itemtype", Order = 145)]
    public string Itemtype { get; set; }
    /// <summary>
    /// 获取或者设置医嘱计划主键
    /// </summary>
    [Column("iorderno", Order = 146)]
    public int? Iorderno { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("backdo", Order = 147)]
    public string Backdo { get; set; }
    /// <summary>
    /// 获取或者设置发药人
    /// </summary>
    [MaxLength(20)]
    [Column("ph", Order = 148)]
    public string Ph { get; set; }
    /// <summary>
    /// 获取或者设置发药时间
    /// </summary>
    [Column("getdate", Order = 149)]
    public DateTime? Getdate { get; set; }
    /// <summary>
    /// 获取或者设置药品批号主键
    /// </summary>
    [MaxLength(100)]
    [Column("dihtimerdn", Order = 150)]
    public string Dihtimerdn { get; set; }
    /// <summary>
    /// 获取或者设置检验检查主键
    /// </summary>
    [MaxLength(1)]
    [Column("clinicin", Order = 151)]
    public string Clinicin { get; set; }
    /// <summary>
    /// 获取或者设置执行日期1
    /// </summary>
    [Column("dodate", Order = 152)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置处方号
    /// </summary>
    [Column("drugno", Order = 153)]
    public int? Drugno { get; set; }
    /// <summary>
    /// 获取或者设置草药贴数
    /// </summary>
    [Column("setnumb", Order = 154)]
    public int? Setnumb { get; set; }
    /// <summary>
    /// 获取或者设置退药数
    /// </summary>
    [Precision(16, 4)]
    [Column("preback", Order = 155)]
    public decimal? Preback { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("dj", Order = 156)]
    public string Dj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("gbh", Order = 157)]
    public int? Gbh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("zyffbz", Order = 158)]
    public string Zyffbz { get; set; }
    /// <summary>
    /// 获取或者设置审批编号
    /// </summary>
    [MaxLength(25)]
    [Column("spbh", Order = 159)]
    public string Spbh { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类型
    /// </summary>
    [MaxLength(3)]
    [Column("ordertype", Order = 160)]
    public string Ordertype { get; set; }
    /// <summary>
    /// 获取或者设置医保码
    /// </summary>
    [MaxLength(100)]
    [Column("insucode", Order = 161)]
    public string Insucode { get; set; }
    /// <summary>
    /// 获取或者设置床位科室
    /// </summary>
    [MaxLength(20)]
    [Column("beddept", Order = 162)]
    public string Beddept { get; set; }
    /// <summary>
    /// 获取或者设置床位医生
    /// </summary>
    [MaxLength(20)]
    [Column("beddr", Order = 163)]
    public string Beddr { get; set; }
    /// <summary>
    /// 获取或者设置医保限定标记
    /// </summary>
    [MaxLength(10)]
    [Column("ybxdflag", Order = 164)]
    public string Ybxdflag { get; set; }
    /// <summary>
    /// 获取或者设置医保限定内容
    /// </summary>
    [MaxLength(500)]
    [Column("ybxdmark", Order = 165)]
    public string Ybxdmark { get; set; }
    /// <summary>
    /// 获取或者设置上传医保码
    /// </summary>
    [MaxLength(50)]
    [Column("transinsucode", Order = 166)]
    public string Transinsucode { get; set; }
    /// <summary>
    /// 获取或者设置上传人
    /// </summary>
    [MaxLength(20)]
    [Column("transjp", Order = 167)]
    public string Transjp { get; set; }
    /// <summary>
    /// 获取或者设置上传时间
    /// </summary>
    [Column("transdt", Order = 168)]
    public DateTime? Transdt { get; set; }
    /// <summary>
    /// 获取或者设置执行院区
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 169)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置院区
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 170)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置结算院区
    /// </summary>
    [MaxLength(20)]
    [Column("jshoscode", Order = 171)]
    public string Jshoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("CLflag", Order = 172)]
    public string CLflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 0)]
    [Column("CLabcormany", Order = 173)]
    public decimal? CLabcormany { get; set; }
    /// <summary>
    /// 获取或者设置医保等级
    /// </summary>
    [MaxLength(1)]
    [Column("drtt", Order = 174)]
    public string Drtt { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("bj2flag", Order = 175)]
    public string Bj2flag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("pajp", Order = 176)]
    public string Pajp { get; set; }
    /// <summary>
    /// 获取或者设置智能收费主键
    /// </summary>
    [Column("autofeerdn", Order = 177)]
    public int? Autofeerdn { get; set; }
    /// <summary>
    /// 获取或者设置记账院区
    /// </summary>
    [MaxLength(20)]
    [Column("rhoscode", Order = 178)]
    public string Rhoscode { get; set; }
    /// <summary>
    /// 获取或者设置扩展表主键
    /// </summary>
    [Column("basesubid", Order = 179)]
    public int? Basesubid { get; set; }
    /// <summary>
    /// 获取或者设置实际零售价
    /// </summary>
    [Precision(18, 4)]
    [Column("realnpl", Order = 180)]
    public decimal? Realnpl { get; set; }
    /// <summary>
    /// 获取或者设置数据来源
    /// </summary>
    [MaxLength(5)]
    [Column("appid", Order = 181)]
    public string Appid { get; set; }
    /// <summary>
    /// 获取或者设置原始记账日期
    /// </summary>
    [Column("oldrdate", Order = 182)]
    public DateTime? Oldrdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("Company", Order = 183)]
    public string Company { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 184)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("mzrdn", Order = 185)]
    public int? Mzrdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("insert_time", Order = 186)]
    public DateTime? InsertTime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("repairfee", Order = 187)]
    public string Repairfee { get; set; }
    /// <summary>
    /// 获取或者设置物资批次号
    /// </summary>
    [MaxLength(32)]
    [Column("hrpwzpch", Order = 188)]
    public string HrpWzPch { get; set; }
    /// <summary>
    /// 获取或者设置物资出库单标识
    /// </summary>
    [Column("hrpwzckdid", Order = 189)]
    public long? HrpWzCkdId { get; set; }
    /// <summary>
    /// 获取或者设置记账病区
    /// </summary>
    [MaxLength(20)]
    [Column("rward", Order = 190)]
    public string Rward { get; set; }

    /// <summary>
    /// 获取或者设置规格
    [MaxLength(128)]
    [Column("gg", Order = 191)]
    public string Gg { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("Xdh", Order = 192)]
    public string Xdh { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}