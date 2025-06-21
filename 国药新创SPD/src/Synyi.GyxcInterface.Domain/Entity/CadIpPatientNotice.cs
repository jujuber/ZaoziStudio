namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 住院预约单
/// </summary>
[Table("cadIpPatientNotice")]
[PrimaryKey(nameof(PatientNoticeId))]
public sealed class CadIpPatientNotice : EqualObject
{
    /// <summary>
    /// 获取或者设置联系人
    /// </summary>
    [MaxLength(20)]
    [Column("contacts", Order = 100)]
    public string Contacts { get; set; }
    /// <summary>
    /// 获取或者设置家属联系人
    /// </summary>
    [MaxLength(20)]
    [Column("homecontact", Order = 101)]
    public string Homecontact { get; set; }
    /// <summary>
    /// 获取或者设置家属联系人电话
    /// </summary>
    [MaxLength(11)]
    [Column("homecontactphone", Order = 102)]
    public string Homecontactphone { get; set; }
    /// <summary>
    /// 获取或者设置是否陪客
    /// </summary>
    [MaxLength(3)]
    [Column("accompanyingFlag", Order = 103)]
    public string AccompanyingFlag { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("patientNoticeId", Order = 104)]
    public int PatientNoticeId { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("patientID", Order = 105)]
    public int? PatientID { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("outpatientNo", Order = 106)]
    public int? OutpatientNo { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("codelist", Order = 107)]
    public string Codelist { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(50)]
    [Column("patientName", Order = 108)]
    public string PatientName { get; set; }
    /// <summary>
    /// 获取或者设置性别
    /// </summary>
    [MaxLength(1)]
    [Column("patientSex", Order = 109)]
    public string PatientSex { get; set; }
    /// <summary>
    /// 获取或者设置年龄
    /// </summary>
    [Column("patientAge", Order = 110)]
    public int? PatientAge { get; set; }
    /// <summary>
    /// 获取或者设置婚姻
    /// </summary>
    [MaxLength(1)]
    [Column("merry", Order = 111)]
    public string Merry { get; set; }
    /// <summary>
    /// 获取或者设置地址
    /// </summary>
    [MaxLength(200)]
    [Column("patientAddress", Order = 112)]
    public string PatientAddress { get; set; }
    /// <summary>
    /// 获取或者设置移动电话
    /// </summary>
    [MaxLength(20)]
    [Column("patientCellphone", Order = 113)]
    public string PatientCellphone { get; set; }
    /// <summary>
    /// 获取或者设置电话
    /// </summary>
    [MaxLength(20)]
    [Column("patientPhone", Order = 114)]
    public string PatientPhone { get; set; }
    /// <summary>
    /// 获取或者设置身份证号
    /// </summary>
    [MaxLength(20)]
    [Column("patientIdentifyCard", Order = 115)]
    public string PatientIdentifyCard { get; set; }
    /// <summary>
    /// 获取或者设置特殊病人
    /// </summary>
    [MaxLength(1)]
    [Column("specialPatient", Order = 116)]
    public string SpecialPatient { get; set; }
    /// <summary>
    /// 获取或者设置医生
    /// </summary>
    [MaxLength(10)]
    [Column("doctor", Order = 117)]
    public string Doctor { get; set; }
    /// <summary>
    /// 获取或者设置申请日期
    /// </summary>
    [Column("applicationDate", Order = 118)]
    public DateTime? ApplicationDate { get; set; }
    /// <summary>
    /// 获取或者设置开单科室
    /// </summary>
    [MaxLength(10)]
    [Column("secOffice", Order = 119)]
    public string SecOffice { get; set; }
    /// <summary>
    /// 获取或者设置诊断
    /// </summary>
    [MaxLength(200)]
    [Column("diagnose", Order = 120)]
    public string Diagnose { get; set; }
    /// <summary>
    /// 获取或者设置主管医生
    /// </summary>
    [MaxLength(10)]
    [Column("attending", Order = 121)]
    public string Attending { get; set; }
    /// <summary>
    /// 获取或者设置疾病类型
    /// </summary>
    [MaxLength(1)]
    [Column("diseaseClass", Order = 122)]
    public string DiseaseClass { get; set; }
    /// <summary>
    /// 获取或者设置床位类型
    /// </summary>
    [MaxLength(3)]
    [Column("isroom", Order = 123)]
    public string Isroom { get; set; }
    /// <summary>
    /// 获取或者设置是否单独区域
    /// </summary>
    [MaxLength(1)]
    [Column("isOnlyarea", Order = 124)]
    public string IsOnlyarea { get; set; }
    /// <summary>
    /// 获取或者设置是否封闭区域
    /// </summary>
    [MaxLength(1)]
    [Column("isClosearea", Order = 125)]
    public string IsClosearea { get; set; }
    /// <summary>
    /// 获取或者设置无限制
    /// </summary>
    [MaxLength(1)]
    [Column("unlimite", Order = 126)]
    public string Unlimite { get; set; }
    /// <summary>
    /// 获取或者设置手术前
    /// </summary>
    [MaxLength(1)]
    [Column("isPreoperative", Order = 127)]
    public string IsPreoperative { get; set; }
    /// <summary>
    /// 获取或者设置术前常规
    /// </summary>
    [MaxLength(1)]
    [Column("isPreoperatRoutine", Order = 128)]
    public string IsPreoperatRoutine { get; set; }
    /// <summary>
    /// 获取或者设置特殊检查
    /// </summary>
    [MaxLength(500)]
    [Column("specialInspection", Order = 129)]
    public string SpecialInspection { get; set; }
    /// <summary>
    /// 获取或者设置心肺检查
    /// </summary>
    [MaxLength(1)]
    [Column("cardiopulmonarycheck", Order = 130)]
    public string Cardiopulmonarycheck { get; set; }
    /// <summary>
    /// 获取或者设置手术预约日期
    /// </summary>
    [Column("appOperativeDate", Order = 131)]
    public DateTime? AppOperativeDate { get; set; }
    /// <summary>
    /// 获取或者设置医生预约日期
    /// </summary>
    [Column("appointmentIn", Order = 132)]
    public DateTime? AppointmentIn { get; set; }
    /// <summary>
    /// 获取或者设置预交款
    /// </summary>
    [Precision(19, 4)]
    [Column("prePay", Order = 133)]
    public decimal? PrePay { get; set; }
    /// <summary>
    /// 获取或者设置交款方式
    /// </summary>
    [MaxLength(20)]
    [Column("PrepayType", Order = 134)]
    public string PrepayType { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(500)]
    [Column("comment", Order = 135)]
    public string Comment { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("validFlag", Order = 136)]
    public string ValidFlag { get; set; }
    /// <summary>
    /// 获取或者设置接收标志
    /// </summary>
    [MaxLength(1)]
    [Column("acceptFlag", Order = 137)]
    public string AcceptFlag { get; set; }
    /// <summary>
    /// 获取或者设置安排标志
    /// </summary>
    [MaxLength(1)]
    [Column("arrangeFlag", Order = 138)]
    public string ArrangeFlag { get; set; }
    /// <summary>
    /// 获取或者设置通知标志
    /// </summary>
    [MaxLength(2)]
    [Column("noticeFlag", Order = 139)]
    public string NoticeFlag { get; set; }
    /// <summary>
    /// 获取或者设置重复通知标志
    /// </summary>
    [MaxLength(1)]
    [Column("renoticeFlag", Order = 140)]
    public string RenoticeFlag { get; set; }
    /// <summary>
    /// 获取或者设置重复标志
    /// </summary>
    [MaxLength(1)]
    [Column("replayFlag", Order = 141)]
    public string ReplayFlag { get; set; }
    /// <summary>
    /// 获取或者设置入院标志
    /// </summary>
    [MaxLength(1)]
    [Column("inFlag", Order = 142)]
    public string InFlag { get; set; }
    /// <summary>
    /// 获取或者设置安排日期
    /// </summary>
    [Column("ArrangeDate", Order = 143)]
    public DateTime? ArrangeDate { get; set; }
    /// <summary>
    /// 获取或者设置入院日期
    /// </summary>
    [Column("indate", Order = 144)]
    public DateTime? Indate { get; set; }
    /// <summary>
    /// 获取或者设置出院日期
    /// </summary>
    [Column("outdate", Order = 145)]
    public DateTime? Outdate { get; set; }
    /// <summary>
    /// 获取或者设置通知记录
    /// </summary>
    [MaxLength(2)]
    [Column("noticeRecord", Order = 146)]
    public string NoticeRecord { get; set; }
    /// <summary>
    /// 获取或者设置未通知记录
    /// </summary>
    [MaxLength(50)]
    [Column("unnoticedRecord", Order = 147)]
    public string UnnoticedRecord { get; set; }
    /// <summary>
    /// 获取或者设置手术名称
    /// </summary>
    [MaxLength(50)]
    [Column("OperName", Order = 148)]
    public string OperName { get; set; }
    /// <summary>
    /// 获取或者设置病人转发
    /// </summary>
    [MaxLength(50)]
    [Column("patientforward", Order = 149)]
    public string Patientforward { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(50)]
    [Column("hoscode", Order = 150)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置执行院区代码
    /// </summary>
    [MaxLength(50)]
    [Column("dohoscode", Order = 151)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置医嘱项目代码
    /// </summary>
    [MaxLength(500)]
    [Column("orderitemname", Order = 152)]
    public string Orderitemname { get; set; }
    /// <summary>
    /// 获取或者设置医嘱项目名称
    /// </summary>
    [MaxLength(500)]
    [Column("orderitemcode", Order = 153)]
    public string Orderitemcode { get; set; }
    /// <summary>
    /// 获取或者设置特殊代码
    /// </summary>
    [MaxLength(500)]
    [Column("specialcode", Order = 154)]
    public string Specialcode { get; set; }
    /// <summary>
    /// 获取或者设置医生备注
    /// </summary>
    [MaxLength(250)]
    [Column("drremark", Order = 155)]
    public string Drremark { get; set; }
    /// <summary>
    /// 获取或者设置安排病区
    /// </summary>
    [MaxLength(20)]
    [Column("arrageBedDept", Order = 156)]
    public string ArrageBedDept { get; set; }
    /// <summary>
    /// 获取或者设置接收日期
    /// </summary>
    [Column("acceptDate", Order = 157)]
    public DateTime? AcceptDate { get; set; }
    /// <summary>
    /// 获取或者设置住院机内号
    /// </summary>
    [Column("interid", Order = 158)]
    public long? Interid { get; set; }
    /// <summary>
    /// 获取或者设置是否完成转换
    /// </summary>
    [Column("isCompleChange", Order = 159)]
    public int? IsCompleChange { get; set; }
    /// <summary>
    /// 获取或者设置安排科室
    /// </summary>
    [MaxLength(20)]
    [Column("arragedeptin", Order = 160)]
    public string Arragedeptin { get; set; }
    /// <summary>
    /// 获取或者设置申请科室
    /// </summary>
    [MaxLength(20)]
    [Column("applicationdeptin", Order = 161)]
    public string Applicationdeptin { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("isWSFlag", Order = 162)]
    public string IsWSFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("iswss", Order = 163)]
    public string Iswss { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ischbr", Order = 164)]
    public string Ischbr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isrjbr", Order = 165)]
    public string Isrjbr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isSavedCheck", Order = 166)]
    public string IsSavedCheck { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("cdiag", Order = 167)]
    public string Cdiag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(300)]
    [Column("complain", Order = 168)]
    public string Complain { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("contacts_Two", Order = 169)]
    public string ContactsTwo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isDualReferral", Order = 170)]
    public string IsDualReferral { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("DualReferralRdn", Order = 171)]
    public string DualReferralRdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("outorderno", Order = 172)]
    public string Outorderno { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("isHiv", Order = 173)]
    public string IsHiv { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isReferral", Order = 174)]
    public string IsReferral { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("Opcode", Order = 175)]
    public string Opcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(32)]
    [Column("DayDiseaseType", Order = 176)]
    public string DayDiseaseType { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("lgbz", Order = 177)]
    public bool? Lgbz { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("lgdjbz", Order = 178)]
    public bool? Lgdjbz { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return PatientNoticeId;
    }
}