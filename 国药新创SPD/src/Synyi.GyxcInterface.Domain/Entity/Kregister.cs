namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 挂号表
/// </summary>
[Table("k_register")]
[PrimaryKey(nameof(Interid))]
public sealed class KRegister : EqualObject
{
    /// <summary>
    /// 获取或者设置数据来源
    /// </summary>
    [MaxLength(10)]
    [Column("appid", Order = 100)]
    public string Appid { get; set; }
    /// <summary>
    /// 获取或者设置流水号
    /// </summary>
    [Required]
    [Column("interid", Order = 101)]
    public int Interid { get; set; }
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
    /// 获取或者设置就诊类型
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 104)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置病人类别
    /// </summary>
    [MaxLength(2)]
    [Column("service", Order = 105)]
    public string Service { get; set; }
    /// <summary>
    /// 获取或者设置病人姓名
    /// </summary>
    [MaxLength(100)]
    [Column("pname", Order = 106)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [MaxLength(20)]
    [Column("rdn", Order = 107)]
    public string Rdn { get; set; }
    /// <summary>
    /// 获取或者设置登记方式
    /// </summary>
    [MaxLength(1)]
    [Column("regtype", Order = 108)]
    public string Regtype { get; set; }
    /// <summary>
    /// 获取或者设置诊号类别
    /// </summary>
    [MaxLength(2)]
    [Column("clinictype", Order = 109)]
    public string Clinictype { get; set; }
    /// <summary>
    /// 获取或者设置诊号序号
    /// </summary>
    [Required]
    [Column("clinicno", Order = 110)]
    public short Clinicno { get; set; }
    /// <summary>
    /// 获取或者设置上午下午
    /// </summary>
    [MaxLength(2)]
    [Column("ampm", Order = 111)]
    public string Ampm { get; set; }
    /// <summary>
    /// 获取或者设置所挂科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 112)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置挂号时间
    /// </summary>
    [Column("rdate", Order = 113)]
    public DateTime? Rdate { get; set; }
    /// <summary>
    /// 获取或者设置挂号费
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee1", Order = 114)]
    public decimal? Pjfee1 { get; set; }
    /// <summary>
    /// 获取或者设置诊疗费
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee2", Order = 115)]
    public decimal? Pjfee2 { get; set; }
    /// <summary>
    /// 获取或者设置工本费
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee3", Order = 116)]
    public decimal? Pjfee3 { get; set; }
    /// <summary>
    /// 获取或者设置磁卡费
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee4", Order = 117)]
    public decimal? Pjfee4 { get; set; }
    /// <summary>
    /// 获取或者设置预约费
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee5", Order = 118)]
    public decimal? Pjfee5 { get; set; }
    /// <summary>
    /// 获取或者设置附加费
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee6", Order = 119)]
    public decimal? Pjfee6 { get; set; }
    /// <summary>
    /// 获取或者设置小计
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee7", Order = 120)]
    public decimal? Pjfee7 { get; set; }
    /// <summary>
    /// 获取或者设置收进
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee8", Order = 121)]
    public decimal? Pjfee8 { get; set; }
    /// <summary>
    /// 获取或者设置退找
    /// </summary>
    [Precision(16, 4)]
    [Column("feer", Order = 122)]
    public decimal? Feer { get; set; }
    /// <summary>
    /// 获取或者设置支付方式
    /// </summary>
    [MaxLength(1)]
    [Column("paytype", Order = 123)]
    public string Paytype { get; set; }
    /// <summary>
    /// 获取或者设置挂号操作员
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 124)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置报表号
    /// </summary>
    [Column("reportno", Order = 125)]
    public int? Reportno { get; set; }
    /// <summary>
    /// 获取或者设置注销标志
    /// </summary>
    [MaxLength(1)]
    [Column("logout", Order = 126)]
    public string Logout { get; set; }
    /// <summary>
    /// 获取或者设置注销理由
    /// </summary>
    [MaxLength(1)]
    [Column("logoutre", Order = 127)]
    public string Logoutre { get; set; }
    /// <summary>
    /// 获取或者设置是否有效
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 128)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置所挂医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 129)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置结算标记
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 130)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置打印时间
    /// </summary>
    [Column("printdate", Order = 131)]
    public DateTime? Printdate { get; set; }
    /// <summary>
    /// 获取或者设置单位编码
    /// </summary>
    [MaxLength(20)]
    [Column("unitid", Order = 132)]
    public string Unitid { get; set; }
    /// <summary>
    /// 获取或者设置打印标志
    /// </summary>
    [MaxLength(1)]
    [Column("printflag", Order = 133)]
    public string Printflag { get; set; }
    /// <summary>
    /// 获取或者设置打印页数
    /// </summary>
    [Column("printpage", Order = 134)]
    public int? Printpage { get; set; }
    /// <summary>
    /// 获取或者设置（无用）
    /// </summary>
    [Precision(16, 4)]
    [Column("pjfee9", Order = 135)]
    public decimal? Pjfee9 { get; set; }
    /// <summary>
    /// 获取或者设置本年账户
    /// </summary>
    [Precision(16, 2)]
    [Required]
    [Column("bnzh", Order = 136)]
    public decimal Bnzh { get; set; }
    /// <summary>
    /// 获取或者设置历年账户
    /// </summary>
    [Precision(16, 2)]
    [Required]
    [Column("lnzh", Order = 137)]
    public decimal Lnzh { get; set; }
    /// <summary>
    /// 获取或者设置个人现金
    /// </summary>
    [Precision(16, 2)]
    [Required]
    [Column("grxj", Order = 138)]
    public decimal Grxj { get; set; }
    /// <summary>
    /// 获取或者设置备注信息
    /// </summary>
    [MaxLength(16)]
    [Column("remark", Order = 139)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置公务员标志
    /// </summary>
    [Precision(16, 2)]
    [Required]
    [Column("gwybz", Order = 140)]
    public decimal Gwybz { get; set; }
    /// <summary>
    /// 获取或者设置发送标志
    /// </summary>
    [MaxLength(1)]
    [Column("transflag", Order = 141)]
    public string Transflag { get; set; }
    /// <summary>
    /// 获取或者设置关联号
    /// </summary>
    [Column("interid1", Order = 142)]
    public int? Interid1 { get; set; }
    /// <summary>
    /// 获取或者设置退费原来的机内号
    /// </summary>
    [Column("tinterid", Order = 143)]
    public int? Tinterid { get; set; }
    /// <summary>
    /// 获取或者设置就诊类别
    /// </summary>
    [MaxLength(10)]
    [Column("stayinsu", Order = 144)]
    public string Stayinsu { get; set; }
    /// <summary>
    /// 获取或者设置医保类型
    /// </summary>
    [MaxLength(10)]
    [Column("insukind", Order = 145)]
    public string Insukind { get; set; }
    /// <summary>
    /// 获取或者设置单位类型
    /// </summary>
    [MaxLength(10)]
    [Column("unittype", Order = 146)]
    public string Unittype { get; set; }
    /// <summary>
    /// 获取或者设置医保码
    /// </summary>
    [MaxLength(50)]
    [Column("insucode", Order = 147)]
    public string Insucode { get; set; }
    /// <summary>
    /// 获取或者设置签名标志
    /// </summary>
    [MaxLength(1)]
    [Column("signinflag", Order = 148)]
    public string Signinflag { get; set; }
    /// <summary>
    /// 获取或者设置交易流水号
    /// </summary>
    [Precision(18, 0)]
    [Column("tradeid", Order = 149)]
    public decimal? Tradeid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 2)]
    [Column("paregi", Order = 150)]
    public decimal? Paregi { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 2)]
    [Column("paregi2", Order = 151)]
    public decimal? Paregi2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("flag", Order = 152)]
    public string Flag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(40)]
    [Column("mzjsReceiverSerialNo", Order = 153)]
    public string MzjsReceiverSerialNo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(40)]
    [Column("mzjsBusiCycle", Order = 154)]
    public string MzjsBusiCycle { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("gflxjj", Order = 155)]
    public decimal? Gflxjj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("lflxjj", Order = 156)]
    public decimal? Lflxjj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("zyjj", Order = 157)]
    public decimal? Zyjj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("lxpojj", Order = 158)]
    public decimal? Lxpojj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("mztcjj", Order = 159)]
    public decimal? Mztcjj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(40)]
    [Column("mzjsSenderSerialNo", Order = 160)]
    public string MzjsSenderSerialNo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("qyzzmztcjj", Order = 161)]
    public decimal? Qyzzmztcjj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("hzcq_no", Order = 162)]
    public string HzcqNo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 2)]
    [Column("knbzjj", Order = 163)]
    public decimal? Knbzjj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 2)]
    [Column("p66", Order = 164)]
    public decimal? P66 { get; set; }
    /// <summary>
    /// 获取或者设置实际就诊医生
    /// </summary>
    [MaxLength(10)]
    [Column("zddr", Order = 165)]
    public string Zddr { get; set; }
    /// <summary>
    /// 获取或者设置实际就诊科室
    /// </summary>
    [MaxLength(20)]
    [Column("zddept", Order = 166)]
    public string Zddept { get; set; }
    /// <summary>
    /// 获取或者设置自由收费标志
    /// </summary>
    [MaxLength(1)]
    [Column("autofeeflag", Order = 167)]
    public string Autofeeflag { get; set; }
    /// <summary>
    /// 获取或者设置是否结束就诊
    /// </summary>
    [MaxLength(1)]
    [Column("cflag", Order = 168)]
    public string Cflag { get; set; }
    /// <summary>
    /// 获取或者设置发票号
    /// </summary>
    [Precision(18, 0)]
    [Column("invoiceno", Order = 169)]
    public decimal? Invoiceno { get; set; }
    /// <summary>
    /// 获取或者设置主管医生
    /// </summary>
    [MaxLength(18)]
    [Column("attending", Order = 170)]
    public string Attending { get; set; }
    /// <summary>
    /// 获取或者设置医保结算主键
    /// </summary>
    [Column("ybid", Order = 171)]
    public int? Ybid { get; set; }
    /// <summary>
    /// 获取或者设置银行流水号
    /// </summary>
    [Column("bankrdn", Order = 172)]
    public int? Bankrdn { get; set; }
    /// <summary>
    /// 获取或者设置是否打印
    /// </summary>
    [MaxLength(1)]
    [Column("isPrint", Order = 173)]
    public string IsPrint { get; set; }
    /// <summary>
    /// 获取或者设置实际发票号
    /// </summary>
    [Column("isPrintCode", Order = 174)]
    public byte[] IsPrintCode { get; set; }
    /// <summary>
    /// 获取或者设置挂号院区
    /// </summary>
    [MaxLength(10)]
    [Column("hosid", Order = 175)]
    public string Hosid { get; set; }
    /// <summary>
    /// 获取或者设置就诊结束时间
    /// </summary>
    [Column("endTime", Order = 176)]
    public DateTime? EndTime { get; set; }
    /// <summary>
    /// 获取或者设置转院标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 177)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置执行院区
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 178)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置就诊区域
    /// </summary>
    [MaxLength(100)]
    [Column("nstation", Order = 179)]
    public string Nstation { get; set; }
    /// <summary>
    /// 获取或者设置留观标识
    /// </summary>
    [MaxLength(100)]
    [Column("obsflag", Order = 180)]
    public string Obsflag { get; set; }
    /// <summary>
    /// 获取或者设置留观源数据
    /// </summary>
    [MaxLength(100)]
    [Column("obssourceid", Order = 181)]
    public string Obssourceid { get; set; }
    /// <summary>
    /// 获取或者设置留观科室id
    /// </summary>
    [MaxLength(25)]
    [Column("obsdeptid", Order = 182)]
    public string Obsdeptid { get; set; }
    /// <summary>
    /// 获取或者设置留观病区id
    /// </summary>
    [MaxLength(25)]
    [Column("obswardid", Order = 183)]
    public string Obswardid { get; set; }
    /// <summary>
    /// 获取或者设置留观医生id
    /// </summary>
    [MaxLength(25)]
    [Column("obsdoctorid", Order = 184)]
    public string Obsdoctorid { get; set; }
    /// <summary>
    /// 获取或者设置留观护士id
    /// </summary>
    [MaxLength(25)]
    [Column("obsnurseid", Order = 185)]
    public string Obsnurseid { get; set; }
    /// <summary>
    /// 获取或者设置留观状态
    /// </summary>
    [MaxLength(5)]
    [Column("obsstate", Order = 186)]
    public string Obsstate { get; set; }
    /// <summary>
    /// 获取或者设置留观床位
    /// </summary>
    [MaxLength(10)]
    [Column("obsbedid", Order = 186)]
    public string Obsbedid { get; set; }
    /// <summary>
    /// 获取或者设置换科原因
    /// </summary>
    [MaxLength(255)]
    [Column("changedeptreason", Order = 180)]
    public string Changedeptreason { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Interid;
    }

}