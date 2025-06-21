namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 处方主表
/// </summary>
[Table("pdrugno")]
[PrimaryKey(nameof(Orderflag), nameof(Rdn))]
public sealed class Pdrugno : EqualObject
{
    /// <summary>
    /// 获取或者设置来源 O门诊I住院
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 100)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置煎药标志
    /// </summary>
    [MaxLength(1)]
    [Column("jyflag", Order = 101)]
    public string Jyflag { get; set; }
    /// <summary>
    /// 获取或者设置pdrugnoip表记号用于查询发药批次
    /// </summary>
    [Column("drugno", Order = 102)]
    public long? Drugno { get; set; }
    /// <summary>
    /// 获取或者设置悬壶台处方字段
    /// </summary>
    [MaxLength(20)]
    [Column("XHpdrugno", Order = 103)]
    public string XHpdrugno { get; set; }
    /// <summary>
    /// 获取或者设置悬壶台中心处方编号
    /// </summary>
    [MaxLength(100)]
    [Column("XHZXpdrugno", Order = 104)]
    public string XHZXpdrugno { get; set; }
    /// <summary>
    /// 获取或者设置药房审方
    /// </summary>
    [MaxLength(1)]
    [Column("ReviewFlaghis", Order = 105)]
    public string ReviewFlaghis { get; set; }
    /// <summary>
    /// 获取或者设置中药配送标记
    /// </summary>
    [MaxLength(1)]
    [Column("distribution_flag", Order = 106)]
    public string DistributionFlag { get; set; }
    /// <summary>
    /// 获取或者设置超说明书用药标记
    /// </summary>
    [MaxLength(1)]
    [Column("Exceed_Instructions", Order = 107)]
    public string ExceedInstructions { get; set; }
    /// <summary>
    /// 获取或者设置中药配送标记关联处方号
    /// </summary>
    [MaxLength(20)]
    [Column("distribution_pageno", Order = 108)]
    public string DistributionPageno { get; set; }
    /// <summary>
    /// 获取或者设置插入时间
    /// </summary>
    [Column("insert_date", Order = 109)]
    public DateTime? InsertDate { get; set; }
    /// <summary>
    /// 获取或者设置创建时间
    /// </summary>
    [Column("create_datetime", Order = 110)]
    public DateTime? CreateDatetime { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类型
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("orderflag", Order = 111)]
    public string Orderflag { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 112)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置发票号码
    /// </summary>
    [Column("fbid", Order = 113)]
    public int? Fbid { get; set; }
    /// <summary>
    /// 获取或者设置病人姓名
    /// </summary>
    [MaxLength(50)]
    [Column("pname", Order = 114)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置有效标记
    /// </summary>
    [MaxLength(1)]
    [Column("doflag", Order = 115)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置登记时间
    /// </summary>
    [Column("indate", Order = 116)]
    public DateTime? Indate { get; set; }
    /// <summary>
    /// 获取或者设置执行时间
    /// </summary>
    [Column("dodate", Order = 117)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置经办人
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 118)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置金额
    /// </summary>
    [Precision(16, 4)]
    [Column("fee", Order = 119)]
    public decimal? Fee { get; set; }
    /// <summary>
    /// 获取或者设置发药药师
    /// </summary>
    [MaxLength(15)]
    [Column("ph", Order = 120)]
    public string Ph { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 121)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 122)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置审方药师
    /// </summary>
    [MaxLength(15)]
    [Column("checkph", Order = 123)]
    public string Checkph { get; set; }
    /// <summary>
    /// 获取或者设置记录数
    /// </summary>
    [Column("rownumb", Order = 124)]
    public int? Rownumb { get; set; }
    /// <summary>
    /// 获取或者设置发药药房代码
    /// </summary>
    [MaxLength(20)]
    [Column("pharmdept", Order = 125)]
    public string Pharmdept { get; set; }
    /// <summary>
    /// 获取或者设置配药药师
    /// </summary>
    [MaxLength(15)]
    [Column("doph", Order = 126)]
    public string Doph { get; set; }
    /// <summary>
    /// 获取或者设置开单医师工号
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 127)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置临床科室名称
    /// </summary>
    [MaxLength(20)]
    [Column("clinicdept", Order = 128)]
    public string Clinicdept { get; set; }
    /// <summary>
    /// 获取或者设置发放类型
    /// </summary>
    [MaxLength(1)]
    [Column("senttype", Order = 129)]
    public string Senttype { get; set; }
    /// <summary>
    /// 获取或者设置结算标志
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 130)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置贴数
    /// </summary>
    [Column("setnumb", Order = 131)]
    public int? Setnumb { get; set; }
    /// <summary>
    /// 获取或者设置病人医保类别
    /// </summary>
    [MaxLength(2)]
    [Column("service", Order = 132)]
    public string Service { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(250)]
    [Column("remark", Order = 133)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置医嘱号
    /// </summary>
    [Column("clinicrdn", Order = 134)]
    public int? Clinicrdn { get; set; }
    /// <summary>
    /// 获取或者设置医技类别
    /// </summary>
    [MaxLength(3)]
    [Column("itemtype", Order = 135)]
    public string Itemtype { get; set; }
    /// <summary>
    /// 获取或者设置特殊病种打印标志
    /// </summary>
    [MaxLength(1)]
    [Column("pflag", Order = 136)]
    public string Pflag { get; set; }
    /// <summary>
    /// 获取或者设置状态
    /// </summary>
    [MaxLength(20)]
    [Column("state", Order = 137)]
    public string State { get; set; }
    /// <summary>
    /// 获取或者设置打印标志
    /// </summary>
    [MaxLength(1)]
    [Column("printflag", Order = 138)]
    public string Printflag { get; set; }
    /// <summary>
    /// 获取或者设置医保类型
    /// </summary>
    [MaxLength(2)]
    [Column("stayinsu", Order = 139)]
    public string Stayinsu { get; set; }
    /// <summary>
    /// 获取或者设置退回标记
    /// </summary>
    [MaxLength(1)]
    [Column("backflag", Order = 140)]
    public string Backflag { get; set; }
    /// <summary>
    /// 获取或者设置退回人员
    /// </summary>
    [MaxLength(10)]
    [Column("backempid", Order = 141)]
    public string Backempid { get; set; }
    /// <summary>
    /// 获取或者设置退回时间
    /// </summary>
    [Column("backtime", Order = 142)]
    public DateTime? Backtime { get; set; }
    /// <summary>
    /// 获取或者设置自由渠道
    /// </summary>
    [MaxLength(50)]
    [Column("freechannel", Order = 143)]
    public string Freechannel { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(10)]
    [Column("hoscode", Order = 144)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置审核标志
    /// </summary>
    [Column("checkflag", Order = 145)]
    public int? Checkflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("tjno", Order = 146)]
    public string Tjno { get; set; }
    /// <summary>
    /// 获取或者设置备注1
    /// </summary>
    [MaxLength(250)]
    [Column("remark1", Order = 147)]
    public string Remark1 { get; set; }
    /// <summary>
    /// 获取或者设置执行院区代码
    /// </summary>
    [MaxLength(10)]
    [Column("dohoscode", Order = 148)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置诊断码
    /// </summary>
    [MaxLength(300)]
    [Column("diagcode", Order = 149)]
    public string Diagcode { get; set; }
    /// <summary>
    /// 获取或者设置备注2
    /// </summary>
    [MaxLength(50)]
    [Column("remark2", Order = 150)]
    public string Remark2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("mxbcfbz", Order = 151)]
    public int? Mxbcfbz { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("operrdn", Order = 152)]
    public int? Operrdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("isXgjc", Order = 153)]
    public string IsXgjc { get; set; }
    /// <summary>
    /// 获取或者设置医保诊断码
    /// </summary>
    [MaxLength(255)]
    [Column("insudiagcode", Order = 154)]
    public string Insudiagcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("jm_serial", Order = 155)]
    public int? JmSerial { get; set; }
    /// <summary>
    /// 获取或者设置发药人
    /// </summary>
    [MaxLength(12)]
    [Column("dispensingjp", Order = 156)]
    public string Dispensingjp { get; set; }
    /// <summary>
    /// 获取或者设置发药时间
    /// </summary>
    [Column("dispensingtime", Order = 157)]
    public DateTime? Dispensingtime { get; set; }
    /// <summary>
    /// 获取或者设置发药标志
    /// </summary>
    [MaxLength(1)]
    [Column("dispensingflag", Order = 158)]
    public string Dispensingflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("release", Order = 159)]
    public string Release { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("oldInterid", Order = 160)]
    public string OldInterid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("prescriptiontype", Order = 161)]
    public string Prescriptiontype { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("prescriptionlastdate", Order = 162)]
    public DateTime? Prescriptionlastdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("CDSSToken", Order = 163)]
    public string CDSSToken { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("CDSSPdrugNo", Order = 164)]
    public string CDSSPdrugNo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("APPID", Order = 165)]
    public string APPID { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ReviewFlag", Order = 166)]
    public string ReviewFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("ReviewMark", Order = 167)]
    public string ReviewMark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("registerInterid", Order = 168)]
    public int? RegisterInterid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("dosage_Z", Order = 169)]
    public string DosageZ { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("doaddress", Order = 170)]
    public string Doaddress { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("feey", Order = 171)]
    public decimal? Feey { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("zkbl", Order = 172)]
    public decimal? Zkbl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("ymxm", Order = 173)]
    public string Ymxm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cisxh", Order = 174)]
    public long? Cisxh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cislybz", Order = 175)]
    public int? Cislybz { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cisxhlb", Order = 176)]
    public int? Cisxhlb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cisxtlb", Order = 177)]
    public string Cisxtlb { get; set; }
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
    /// 获取或者设置物资发放标志 1-待发放 2-已发放
    /// </summary>
    [Column("hrpexeflag", Order = 180)]
    public int? HrpExeFlag { get; set; }
    /// <summary>
    /// 获取或者设置物资出库单标识
    /// </summary>
    [Column("hrpckdid", Order = 181)]
    public long? HrpCkdId { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Orderflag;
        yield return Rdn;
    }
}