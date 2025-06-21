namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 病人基础信息表
/// </summary>
[Table("pmain")]
[PrimaryKey(nameof(Mrn))]
public sealed class Pmain : EqualObject
{
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Required]
    [Column("mrn", Order = 100)]
    public int Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 101)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(100)]
    [Column("pname", Order = 102)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置性别
    /// </summary>
    [MaxLength(1)]
    [Column("psex", Order = 103)]
    public string Psex { get; set; }
    /// <summary>
    /// 获取或者设置生日
    /// </summary>
    [Column("pbirthday", Order = 104)]
    public DateTime? Pbirthday { get; set; }
    /// <summary>
    /// 获取或者设置年龄
    /// </summary>
    [Column("age", Order = 105)]
    public int? Age { get; set; }
    /// <summary>
    /// 获取或者设置婚姻
    /// </summary>
    [MaxLength(1)]
    [Column("pmstatus", Order = 106)]
    public string Pmstatus { get; set; }
    /// <summary>
    /// 获取或者设置职业
    /// </summary>
    [MaxLength(10)]
    [Column("poccu", Order = 107)]
    public string Poccu { get; set; }
    /// <summary>
    /// 获取或者设置民族
    /// </summary>
    [MaxLength(10)]
    [Column("prace", Order = 108)]
    public string Prace { get; set; }
    /// <summary>
    /// 获取或者设置身份证号
    /// </summary>
    [MaxLength(18)]
    [Column("pcid", Order = 109)]
    public string Pcid { get; set; }
    /// <summary>
    /// 获取或者设置血型
    /// </summary>
    [MaxLength(2)]
    [Column("bloodtype", Order = 110)]
    public string Bloodtype { get; set; }
    /// <summary>
    /// 获取或者设置rh血型
    /// </summary>
    [MaxLength(1)]
    [Column("rh", Order = 111)]
    public string Rh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("allergy", Order = 112)]
    public string Allergy { get; set; }
    /// <summary>
    /// 获取或者设置联系地址
    /// </summary>
    [MaxLength(500)]
    [Column("paddress", Order = 113)]
    public string Paddress { get; set; }
    /// <summary>
    /// 获取或者设置邮政编码
    /// </summary>
    [MaxLength(6)]
    [Column("pzip", Order = 114)]
    public string Pzip { get; set; }
    /// <summary>
    /// 获取或者设置联系电话
    /// </summary>
    [MaxLength(15)]
    [Column("pphone", Order = 115)]
    public string Pphone { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(200)]
    [Column("unit", Order = 116)]
    public string Unit { get; set; }
    /// <summary>
    /// 获取或者设置单位代码
    /// </summary>
    [MaxLength(15)]
    [Column("unitid", Order = 117)]
    public string Unitid { get; set; }
    /// <summary>
    /// 获取或者设置联系人
    /// </summary>
    [MaxLength(12)]
    [Column("kin", Order = 118)]
    public string Kin { get; set; }
    /// <summary>
    /// 获取或者设置联系人关系
    /// </summary>
    [MaxLength(1)]
    [Column("ktop", Order = 119)]
    public string Ktop { get; set; }
    /// <summary>
    /// 获取或者设置联系人身份证
    /// </summary>
    [MaxLength(18)]
    [Column("kcid", Order = 120)]
    public string Kcid { get; set; }
    /// <summary>
    /// 获取或者设置医保类别
    /// </summary>
    [MaxLength(2)]
    [Column("service", Order = 121)]
    public string Service { get; set; }
    /// <summary>
    /// 获取或者设置病人来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 122)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("commonid", Order = 123)]
    public string Commonid { get; set; }
    /// <summary>
    /// 获取或者设置医保号
    /// </summary>
    [MaxLength(50)]
    [Column("insucode", Order = 124)]
    public string Insucode { get; set; }
    /// <summary>
    /// 获取或者设置欠费标志
    /// </summary>
    [MaxLength(1)]
    [Column("pcf", Order = 125)]
    public string Pcf { get; set; }
    /// <summary>
    /// 获取或者设置死亡标志
    /// </summary>
    [MaxLength(1)]
    [Column("die", Order = 126)]
    public string Die { get; set; }
    /// <summary>
    /// 获取或者设置登记日期
    /// </summary>
    [Column("pdate", Order = 127)]
    public DateTime? Pdate { get; set; }
    /// <summary>
    /// 获取或者设置经办人
    /// </summary>
    [MaxLength(10)]
    [Column("workid", Order = 128)]
    public string Workid { get; set; }
    /// <summary>
    /// 获取或者设置在院标志
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 129)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置年龄单位
    /// </summary>
    [MaxLength(1)]
    [Column("ageunit", Order = 130)]
    public string Ageunit { get; set; }
    /// <summary>
    /// 获取或者设置流水号
    /// </summary>
    [Column("flowid", Order = 131)]
    public int? Flowid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("loseflag", Order = 132)]
    public string Loseflag { get; set; }
    /// <summary>
    /// 获取或者设置老年卡
    /// </summary>
    [MaxLength(1)]
    [Column("agedcard", Order = 133)]
    public string Agedcard { get; set; }
    /// <summary>
    /// 获取或者设置医保就诊类别
    /// </summary>
    [MaxLength(2)]
    [Column("stayinsu", Order = 134)]
    public string Stayinsu { get; set; }
    /// <summary>
    /// 获取或者设置单位类别
    /// </summary>
    [MaxLength(2)]
    [Column("unittype", Order = 135)]
    public string Unittype { get; set; }
    /// <summary>
    /// 获取或者设置医疗待遇类别
    /// </summary>
    [MaxLength(10)]
    [Column("insukind", Order = 136)]
    public string Insukind { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(4)]
    [Column("pkind", Order = 137)]
    public string Pkind { get; set; }
    /// <summary>
    /// 获取或者设置密码
    /// </summary>
    [MaxLength(10)]
    [Column("password", Order = 138)]
    public string Password { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("tsbzmc", Order = 139)]
    public string Tsbzmc { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("tsbzdm", Order = 140)]
    public string Tsbzdm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("tsbz", Order = 141)]
    public string Tsbz { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("oldflag", Order = 142)]
    public string Oldflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("bxbh", Order = 143)]
    public string Bxbh { get; set; }
    /// <summary>
    /// 获取或者设置所属城市
    /// </summary>
    [MaxLength(50)]
    [Column("citizen", Order = 144)]
    public string Citizen { get; set; }
    /// <summary>
    /// 获取或者设置教育情况
    /// </summary>
    [MaxLength(3)]
    [Column("education", Order = 145)]
    public string Education { get; set; }
    /// <summary>
    /// 获取或者设置宗教
    /// </summary>
    [MaxLength(3)]
    [Column("religious", Order = 146)]
    public string Religious { get; set; }
    /// <summary>
    /// 获取或者设置出生地
    /// </summary>
    [MaxLength(100)]
    [Column("birthplace", Order = 147)]
    public string Birthplace { get; set; }
    /// <summary>
    /// 获取或者设置保密级别
    /// </summary>
    [MaxLength(1)]
    [Column("secrecy", Order = 148)]
    public string Secrecy { get; set; }
    /// <summary>
    /// 获取或者设置出生地代码
    /// </summary>
    [MaxLength(10)]
    [Column("addrFromCode", Order = 149)]
    public string AddrFromCode { get; set; }
    /// <summary>
    /// 获取或者设置现住址代码
    /// </summary>
    [MaxLength(10)]
    [Column("addrLiveCode", Order = 150)]
    public string AddrLiveCode { get; set; }
    /// <summary>
    /// 获取或者设置病历号(字符型)
    /// </summary>
    [MaxLength(20)]
    [Column("MRNC", Order = 151)]
    public string MRNC { get; set; }
    /// <summary>
    /// 获取或者设置病历号（主索引）
    /// </summary>
    [MaxLength(20)]
    [Column("patient_id", Order = 152)]
    public string PatientId { get; set; }
    /// <summary>
    /// 获取或者设置院区
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 153)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置转院日期
    /// </summary>
    [Column("hostrandt", Order = 154)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置转院标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 155)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置是否使用
    /// </summary>
    [Column("isuse", Order = 156)]
    public int? Isuse { get; set; }
    /// <summary>
    /// 获取或者设置合并标志
    /// </summary>
    [Column("mergeflag", Order = 157)]
    public int? Mergeflag { get; set; }
    /// <summary>
    /// 获取或者设置合并病历号
    /// </summary>
    [Column("mergeMrn", Order = 158)]
    public int? MergeMrn { get; set; }
    /// <summary>
    /// 获取或者设置合并日期
    /// </summary>
    [Column("mergeDate", Order = 159)]
    public DateTime? MergeDate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("isControl", Order = 160)]
    public byte? IsControl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(15)]
    [Column("kinphone", Order = 161)]
    public string Kinphone { get; set; }
    /// <summary>
    /// 获取或者设置出生地1
    /// </summary>
    [MaxLength(200)]
    [Column("BirthplaceAddress", Order = 162)]
    public string BirthplaceAddress { get; set; }
    /// <summary>
    /// 获取或者设置出生地邮编
    /// </summary>
    [MaxLength(20)]
    [Column("BirthplaceCode", Order = 163)]
    public string BirthplaceCode { get; set; }
    /// <summary>
    /// 获取或者设置联系地址1
    /// </summary>
    [MaxLength(200)]
    [Column("ContactsAddress", Order = 164)]
    public string ContactsAddress { get; set; }
    /// <summary>
    /// 获取或者设置联系地址邮编
    /// </summary>
    [MaxLength(20)]
    [Column("ContactsCode", Order = 165)]
    public string ContactsCode { get; set; }
    /// <summary>
    /// 获取或者设置工作单位地址
    /// </summary>
    [MaxLength(200)]
    [Column("WorkUnitAddress", Order = 166)]
    public string WorkUnitAddress { get; set; }
    /// <summary>
    /// 获取或者设置工作单位邮编
    /// </summary>
    [MaxLength(20)]
    [Column("WorkUnitCode", Order = 167)]
    public string WorkUnitCode { get; set; }
    /// <summary>
    /// 获取或者设置现住址
    /// </summary>
    [MaxLength(200)]
    [Column("PresentAddress", Order = 168)]
    public string PresentAddress { get; set; }
    /// <summary>
    /// 获取或者设置现住址邮编
    /// </summary>
    [MaxLength(20)]
    [Column("PresentCode", Order = 169)]
    public string PresentCode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("istest", Order = 170)]
    public string Istest { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("NativePlace", Order = 171)]
    public string NativePlace { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(15)]
    [Column("WorkPhone", Order = 172)]
    public string WorkPhone { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(6)]
    [Column("WorkPzip", Order = 173)]
    public string WorkPzip { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(6)]
    [Column("ContactsPzip", Order = 174)]
    public string ContactsPzip { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("pctype", Order = 175)]
    public string Pctype { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Mrn;
    }
}