namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 病人就诊记录信息
/// </summary>
[Table("pcase")]
[PrimaryKey(nameof(Mrn), nameof(Series))]
public class Pcase : EqualObject
{
    /// <summary>
    /// 获取或者设置绿色通道病人 1是
    /// </summary>
    [MaxLength(1)]
    [Column("GreenFlag", Order = 100)]
    public string GreenFlag { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Required]
    [Column("mrn", Order = 101)]
    public int Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Required]
    [Column("series", Order = 102)]
    public int Series { get; set; }
    /// <summary>
    /// 获取或者设置病人类别
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 103)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(50)]
    [Column("pname", Order = 104)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置性别
    /// </summary>
    [MaxLength(1)]
    [Column("psex", Order = 105)]
    public string Psex { get; set; }
    /// <summary>
    /// 获取或者设置登记日期
    /// </summary>
    [Required]
    [Column("pdate", Order = 106)]
    public DateTime Pdate { get; set; }
    /// <summary>
    /// 获取或者设置科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 107)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置次科室1
    /// </summary>
    [MaxLength(20)]
    [Column("depts", Order = 108)]
    public string Depts { get; set; }
    /// <summary>
    /// 获取或者设置次科室2
    /// </summary>
    [MaxLength(20)]
    [Column("deptt", Order = 109)]
    public string Deptt { get; set; }
    /// <summary>
    /// 获取或者设置医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 110)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置住院医生
    /// </summary>
    [MaxLength(10)]
    [Column("resident", Order = 111)]
    public string Resident { get; set; }
    /// <summary>
    /// 获取或者设置诊断
    /// </summary>
    [MaxLength(100)]
    [Column("digm", Order = 112)]
    public string Digm { get; set; }
    /// <summary>
    /// 获取或者设置诊断代码
    /// </summary>
    [MaxLength(100)]
    [Column("digmcode", Order = 113)]
    public string Digmcode { get; set; }
    /// <summary>
    /// 获取或者设置事件代码
    /// </summary>
    [MaxLength(200)]
    [Column("evcode", Order = 114)]
    public string Evcode { get; set; }
    /// <summary>
    /// 获取或者设置诊断1
    /// </summary>
    [MaxLength(100)]
    [Column("dig1", Order = 115)]
    public string Dig1 { get; set; }
    /// <summary>
    /// 获取或者设置诊断代码1
    /// </summary>
    [MaxLength(20)]
    [Column("dig1code", Order = 116)]
    public string Dig1code { get; set; }
    /// <summary>
    /// 获取或者设置诊断2
    /// </summary>
    [MaxLength(100)]
    [Column("dig2", Order = 117)]
    public string Dig2 { get; set; }
    /// <summary>
    /// 获取或者设置诊断代码2
    /// </summary>
    [MaxLength(20)]
    [Column("dig2code", Order = 118)]
    public string Dig2code { get; set; }
    /// <summary>
    /// 获取或者设置诊断3
    /// </summary>
    [MaxLength(100)]
    [Column("dig3", Order = 119)]
    public string Dig3 { get; set; }
    /// <summary>
    /// 获取或者设置诊断代码3
    /// </summary>
    [MaxLength(20)]
    [Column("dig3code", Order = 120)]
    public string Dig3code { get; set; }
    /// <summary>
    /// 获取或者设置年龄
    /// </summary>
    [Column("age", Order = 121)]
    public int? Age { get; set; }
    /// <summary>
    /// 获取或者设置年龄单位
    /// </summary>
    [MaxLength(1)]
    [Column("ageunit", Order = 122)]
    public string Ageunit { get; set; }
    /// <summary>
    /// 获取或者设置床位
    /// </summary>
    [MaxLength(20)]
    [Column("bedid", Order = 123)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置入院时间
    /// </summary>
    [Column("admid", Order = 124)]
    public DateTime? Admid { get; set; }
    /// <summary>
    /// 获取或者设置出院时间
    /// </summary>
    [Column("discd", Order = 125)]
    public DateTime? Discd { get; set; }
    /// <summary>
    /// 获取或者设置严重程度
    /// </summary>
    [MaxLength(1)]
    [Column("acondi", Order = 126)]
    public string Acondi { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("dcondi", Order = 127)]
    public string Dcondi { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("disp", Order = 128)]
    public string Disp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("oflag", Order = 129)]
    public string Oflag { get; set; }
    /// <summary>
    /// 获取或者设置在院标志
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 130)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("optoin", Order = 131)]
    public string Optoin { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("clitopa", Order = 132)]
    public string Clitopa { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("preop", Order = 133)]
    public string Preop { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("op1code", Order = 134)]
    public string Op1code { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("op2code", Order = 135)]
    public string Op2code { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("op3code", Order = 136)]
    public string Op3code { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("caseconfirm", Order = 137)]
    public string Caseconfirm { get; set; }
    /// <summary>
    /// 获取或者设置操作员
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 138)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("hospitalid", Order = 139)]
    public string Hospitalid { get; set; }
    /// <summary>
    /// 获取或者设置流水号
    /// </summary>
    [Column("flowid", Order = 140)]
    public int? Flowid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("inout", Order = 141)]
    public string Inout { get; set; }
    /// <summary>
    /// 获取或者设置关联病历号
    /// </summary>
    [Column("relamrn", Order = 142)]
    public int? Relamrn { get; set; }
    /// <summary>
    /// 获取或者设置母婴标志
    /// </summary>
    [MaxLength(1)]
    [Column("baby", Order = 143)]
    public string Baby { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("deptf", Order = 144)]
    public string Deptf { get; set; }
    /// <summary>
    /// 获取或者设置结束就诊时间
    /// </summary>
    [Column("date0", Order = 145)]
    public DateTime? Date0 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("date1", Order = 146)]
    public DateTime? Date1 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("date2", Order = 147)]
    public DateTime? Date2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("date3", Order = 148)]
    public DateTime? Date3 { get; set; }
    /// <summary>
    /// 获取或者设置上传标志
    /// </summary>
    [MaxLength(1)]
    [Column("transflag", Order = 149)]
    public string Transflag { get; set; }
    /// <summary>
    /// 获取或者设置上传日期
    /// </summary>
    [Column("transdate", Order = 150)]
    public DateTime? Transdate { get; set; }
    /// <summary>
    /// 获取或者设置医生1
    /// </summary>
    [MaxLength(20)]
    [Column("dr1", Order = 151)]
    public string Dr1 { get; set; }
    /// <summary>
    /// 获取或者设置医生2
    /// </summary>
    [MaxLength(20)]
    [Column("dr2", Order = 152)]
    public string Dr2 { get; set; }
    /// <summary>
    /// 获取或者设置医生3
    /// </summary>
    [MaxLength(20)]
    [Column("dr3", Order = 153)]
    public string Dr3 { get; set; }
    /// <summary>
    /// 获取或者设置信息源
    /// </summary>
    [MaxLength(1)]
    [Column("infofrom", Order = 154)]
    public string Infofrom { get; set; }
    /// <summary>
    /// 获取或者设置临床路径标记
    /// </summary>
    [MaxLength(1)]
    [Column("cpflag", Order = 155)]
    public string Cpflag { get; set; }
    /// <summary>
    /// 获取或者设置上次进食时间
    /// </summary>
    [Column("lastfooddate", Order = 156)]
    public DateTime? Lastfooddate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("keepflag", Order = 157)]
    public string Keepflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("prlevel", Order = 158)]
    public int? Prlevel { get; set; }
    /// <summary>
    /// 获取或者设置主索引标志
    /// </summary>
    [MaxLength(3)]
    [Column("indexflag", Order = 159)]
    public string Indexflag { get; set; }
    /// <summary>
    /// 获取或者设置门诊就诊医师
    /// </summary>
    [MaxLength(20)]
    [Column("opdr", Order = 160)]
    public string Opdr { get; set; }
    /// <summary>
    /// 获取或者设置入院科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptin", Order = 161)]
    public string Deptin { get; set; }
    /// <summary>
    /// 获取或者设置评估等级
    /// </summary>
    [MaxLength(1)]
    [Column("ratingflag", Order = 162)]
    public string Ratingflag { get; set; }
    /// <summary>
    /// 获取或者设置已写文书总数
    /// </summary>
    [Column("emrcount", Order = 163)]
    public int? Emrcount { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 164)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置转院日期
    /// </summary>
    [Column("hostrandt", Order = 165)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置转院标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 166)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isshare", Order = 167)]
    public string Isshare { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("cacode", Order = 168)]
    public string Cacode { get; set; }
    /// <summary>
    /// 获取或者设置医保类别代码
    /// </summary>
    [MaxLength(20)]
    [Column("insukind", Order = 169)]
    public string Insukind { get; set; }
    /// <summary>
    /// 获取或者设置医保类别
    /// </summary>
    [MaxLength(50)]
    [Column("insukindnm", Order = 170)]
    public string Insukindnm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("bllx", Order = 171)]
    public string Bllx { get; set; }
    /// <summary>
    /// 获取或者设置特殊病种
    /// </summary>
    [MaxLength(50)]
    [Column("stayinsu", Order = 172)]
    public string Stayinsu { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("insuIcd", Order = 173)]
    public string InsuIcd { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("cpdiagcode", Order = 174)]
    public string Cpdiagcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("cpvaryflag", Order = 175)]
    public string Cpvaryflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("cpindr", Order = 176)]
    public string Cpindr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("cpcode", Order = 177)]
    public string Cpcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("cpreason", Order = 178)]
    public string Cpreason { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 0)]
    [Column("amountrelief", Order = 179)]
    public decimal? Amountrelief { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("tjlsh", Order = 180)]
    public string Tjlsh { get; set; }
    /// <summary>
    /// 获取或者设置执行院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 181)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置进房事件
    /// </summary>
    [Column("inroomdate", Order = 182)]
    public DateTime? Inroomdate { get; set; }
    /// <summary>
    /// 获取或者设置出房事件
    /// </summary>
    [Column("outroomdate", Order = 183)]
    public DateTime? Outroomdate { get; set; }
    /// <summary>
    /// 获取或者设置入院科室1
    /// </summary>
    [MaxLength(20)]
    [Column("indeptin", Order = 184)]
    public string Indeptin { get; set; }
    /// <summary>
    /// 获取或者设置出院科室
    /// </summary>
    [MaxLength(20)]
    [Column("outdeptin", Order = 185)]
    public string Outdeptin { get; set; }
    /// <summary>
    /// 获取或者设置入院病区
    /// </summary>
    [MaxLength(20)]
    [Column("indeptbed", Order = 186)]
    public string Indeptbed { get; set; }
    /// <summary>
    /// 获取或者设置出院病区
    /// </summary>
    [MaxLength(20)]
    [Column("outdeptbed", Order = 187)]
    public string Outdeptbed { get; set; }
    /// <summary>
    /// 获取或者设置治愈代码
    /// </summary>
    [MaxLength(5)]
    [Column("Cure", Order = 188)]
    public string Cure { get; set; }
    /// <summary>
    /// 获取或者设置治疗
    /// </summary>
    [MaxLength(100)]
    [Column("CureRemark", Order = 189)]
    public string CureRemark { get; set; }
    /// <summary>
    /// 获取或者设置病人类型
    /// </summary>
    [MaxLength(2)]
    [Column("service", Order = 190)]
    public string Service { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("isjcyy", Order = 191)]
    public string Isjcyy { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("ISCheckLeave", Order = 192)]
    public string ISCheckLeave { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("ddfs", Order = 193)]
    public string Ddfs { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("firstvisit", Order = 194)]
    public string Firstvisit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("sjh", Order = 195)]
    public string Sjh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("Highriskfalls", Order = 196)]
    public string Highriskfalls { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("Pressuresores", Order = 197)]
    public string Pressuresores { get; set; }
    /// <summary>
    /// 获取或者设置ADL值
    /// </summary>
    [MaxLength(20)]
    [Column("ADL", Order = 198)]
    public string ADL { get; set; }
    /// <summary>
    /// 获取或者设置是否婴儿
    /// </summary>
    [MaxLength(1)]
    [Column("isbaby", Order = 199)]
    public string Isbaby { get; set; }
    /// <summary>
    /// 获取或者设置母亲就诊次数
    /// </summary>
    [Column("relaseries", Order = 200)]
    public int? Relaseries { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isywsh", Order = 201)]
    public string Isywsh { get; set; }
    /// <summary>
    /// 获取或者设置护士随访数
    /// </summary>
    [MaxLength(2)]
    [Column("followDegree", Order = 202)]
    public string FollowDegree { get; set; }
    /// <summary>
    /// 获取或者设置VTE值
    /// </summary>
    [MaxLength(10)]
    [Column("VTE", Order = 203)]
    public string VTE { get; set; }
    /// <summary>
    /// 获取或者设置随访护士
    /// </summary>
    [MaxLength(50)]
    [Column("FollowEmpid", Order = 204)]
    public string FollowEmpid { get; set; }
    /// <summary>
    /// 获取或者设置随访医生数
    /// </summary>
    [MaxLength(50)]
    [Column("followDegreeDr", Order = 205)]
    public string FollowDegreeDr { get; set; }
    /// <summary>
    /// 获取或者设置随访医生
    /// </summary>
    [MaxLength(50)]
    [Column("FollowEmpidDr", Order = 206)]
    public string FollowEmpidDr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("Predischarge", Order = 207)]
    public string Predischarge { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("APACHE", Order = 208)]
    public string APACHE { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("QCFLAG", Order = 209)]
    public string QCFLAG { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("firstward", Order = 210)]
    public int? Firstward { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("AdmissionContactCode", Order = 211)]
    public string AdmissionContactCode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("AdmissionContactName", Order = 212)]
    public string AdmissionContactName { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("referralnum", Order = 213)]
    public string Referralnum { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("splitSettlflag", Order = 214)]
    public string SplitSettlflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("accompanyingFlag", Order = 215)]
    public string AccompanyingFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("sjhNew", Order = 216)]
    public string SjhNew { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("FirstServe", Order = 217)]
    public string FirstServe { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("FirstServeType", Order = 218)]
    public string FirstServeType { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("ObservationFlag", Order = 219)]
    public string ObservationFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("HomeFlag", Order = 220)]
    public string HomeFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("Isgravida", Order = 221)]
    public string Isgravida { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("IsgravidaPlan", Order = 222)]
    public string IsgravidaPlan { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isSendMsg", Order = 223)]
    public string IsSendMsg { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("QCStatus", Order = 224)]
    public int? QCStatus { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("QCErrorFlag", Order = 225)]
    public int? QCErrorFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("ModifyTime", Order = 226)]
    public DateTime? ModifyTime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("Opcode", Order = 227)]
    public string Opcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("DayDiseaseType", Order = 228)]
    public string DayDiseaseType { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("interid", Order = 229)]
    public int? InterId { get; set; }
    /// <summary>
    /// 获取或者设置护士长代码
    /// </summary>
    [MaxLength(32)]
    [Column("hszid", Order = 230)]
    public string HszId { get; set; }
    /// <summary>
    /// 获取或者设置责任护士代码
    /// </summary>
    [MaxLength(32)]
    [Column("zrhsid", Order = 231)]
    public string ZrhsId { get; set; }
    /// <summary>
    /// 获取或者设置护理级别代码
    /// </summary>
    [MaxLength(32)]
    [Column("hljbid", Order = 232)]
    public string HljbId { get; set; }
    /// <summary>
    /// 获取或者设置护理级别
    /// </summary>
    [MaxLength(64)]
    [Column("hljb", Order = 233)]
    public string Hljb { get; set; }
    /// <summary>
    /// 出区时间
    /// </summary>
    [Column("cqsj", Order = 234)]
    public DateTime? Cqsj { get; set; }
    /// <summary>
    /// 入科标志
    /// </summary>
    [Column("rkbz", Order = 235)]
    public bool? Rkbz { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Mrn;
        yield return Series;
    }
}