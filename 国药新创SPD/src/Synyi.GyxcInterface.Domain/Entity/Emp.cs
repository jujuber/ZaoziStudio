namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 员工表
/// </summary>
[Table("emp")]
[PrimaryKey(nameof(Empid))]
public class Emp : EqualObject
{
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("Kpower", Order = 100)]
    public int? Kpower { get; set; }
    /// <summary>
    /// 获取或者设置员工号
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("empid", Order = 101)]
    public string Empid { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(12)]
    [Column("name", Order = 102)]
    public string Name { get; set; }
    /// <summary>
    /// 获取或者设置密码
    /// </summary>
    [MaxLength(300)]
    [Column("password", Order = 103)]
    public string Password { get; set; }
    /// <summary>
    /// 获取或者设置性别
    /// </summary>
    [MaxLength(1)]
    [Column("sex", Order = 104)]
    public string Sex { get; set; }
    /// <summary>
    /// 获取或者设置科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 105)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置分类
    /// </summary>
    [MaxLength(5)]
    [Column("status", Order = 106)]
    public string Status { get; set; }
    /// <summary>
    /// 获取或者设置职别
    /// </summary>
    [MaxLength(3)]
    [Column("title", Order = 107)]
    public string Title { get; set; }
    /// <summary>
    /// 获取或者设置权限
    /// </summary>
    [MaxLength(3)]
    [Column("domain", Order = 108)]
    public string Domain { get; set; }
    /// <summary>
    /// 获取或者设置处方权
    /// </summary>
    [MaxLength(1)]
    [Column("dpower", Order = 109)]
    public string Dpower { get; set; }
    /// <summary>
    /// 获取或者设置麻醉权
    /// </summary>
    [MaxLength(1)]
    [Column("apower", Order = 110)]
    public string Apower { get; set; }
    /// <summary>
    /// 获取或者设置手术权
    /// </summary>
    [MaxLength(1)]
    [Column("opower", Order = 111)]
    public string Opower { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 112)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置出生日期
    /// </summary>
    [Column("birthday", Order = 113)]
    public DateTime? Birthday { get; set; }
    /// <summary>
    /// 获取或者设置护嘱权
    /// </summary>
    [MaxLength(1)]
    [Column("npower", Order = 114)]
    public string Npower { get; set; }
    /// <summary>
    /// 获取或者设置门诊人员
    /// </summary>
    [MaxLength(1)]
    [Column("opflag", Order = 115)]
    public string Opflag { get; set; }
    /// <summary>
    /// 获取或者设置挂号费
    /// </summary>
    [Precision(16, 4)]
    [Column("regfee", Order = 116)]
    public decimal? Regfee { get; set; }
    /// <summary>
    /// 获取或者设置上午号源总数
    /// </summary>
    [Precision(16, 4)]
    [Column("amtotal", Order = 117)]
    public decimal? Amtotal { get; set; }
    /// <summary>
    /// 获取或者设置上午可增加号源数
    /// </summary>
    [Precision(16, 4)]
    [Column("amadd", Order = 118)]
    public decimal? Amadd { get; set; }
    /// <summary>
    /// 获取或者设置上午时间
    /// </summary>
    [Precision(16, 4)]
    [Column("amappoint", Order = 119)]
    public decimal? Amappoint { get; set; }
    /// <summary>
    /// 获取或者设置下午号源总数
    /// </summary>
    [Precision(16, 4)]
    [Column("pmtotal", Order = 120)]
    public decimal? Pmtotal { get; set; }
    /// <summary>
    /// 获取或者设置下午可增加号源数
    /// </summary>
    [Precision(16, 4)]
    [Column("pmadd", Order = 121)]
    public decimal? Pmadd { get; set; }
    /// <summary>
    /// 获取或者设置下午时间
    /// </summary>
    [Precision(16, 4)]
    [Column("pmappoint", Order = 122)]
    public decimal? Pmappoint { get; set; }
    /// <summary>
    /// 获取或者设置晚间号源总数
    /// </summary>
    [Precision(16, 4)]
    [Column("nttotal", Order = 123)]
    public decimal? Nttotal { get; set; }
    /// <summary>
    /// 获取或者设置晚间可增加号源数
    /// </summary>
    [Precision(16, 4)]
    [Column("ntadd", Order = 124)]
    public decimal? Ntadd { get; set; }
    /// <summary>
    /// 获取或者设置晚间时间
    /// </summary>
    [Precision(16, 4)]
    [Column("ntappoint", Order = 125)]
    public decimal? Ntappoint { get; set; }
    /// <summary>
    /// 获取或者设置拼音码
    /// </summary>
    [MaxLength(10)]
    [Column("py", Order = 126)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置特殊号
    /// </summary>
    [MaxLength(5)]
    [Column("spareid", Order = 127)]
    public string Spareid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("apass", Order = 128)]
    public string Apass { get; set; }
    /// <summary>
    /// 获取或者设置新密码
    /// </summary>
    [MaxLength(50)]
    [Column("newpassword", Order = 129)]
    public string Newpassword { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("newdo", Order = 130)]
    public string Newdo { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("icount", Order = 131)]
    public int? Icount { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("zc", Order = 132)]
    public string Zc { get; set; }
    /// <summary>
    /// 获取或者设置医疗组
    /// </summary>
    [MaxLength(20)]
    [Column("medgroup", Order = 133)]
    public string Medgroup { get; set; }
    /// <summary>
    /// 获取或者设置挂号费收费代码
    /// </summary>
    [MaxLength(20)]
    [Column("regfcode", Order = 134)]
    public string Regfcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("workAuth", Order = 135)]
    public string WorkAuth { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 136)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("hostrandt", Order = 137)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 138)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("cacertno", Order = 139)]
    public string Cacertno { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("passworddate", Order = 140)]
    public DateTime? Passworddate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(80)]
    [Column("deptidmz", Order = 141)]
    public string Deptidmz { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("qcpower", Order = 142)]
    public string Qcpower { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ppower", Order = 143)]
    public string Ppower { get; set; }
    /// <summary>
    /// 获取或者设置备注1
    /// </summary>
    [Column("remark1", Order = 144)]
    public string Remark1 { get; set; }
    /// <summary>
    /// 获取或者设置备注2
    /// </summary>
    [Column("remark2", Order = 145)]
    public string Remark2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("insudrcode", Order = 146)]
    public string Insudrcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("UserTypeCode", Order = 147)]
    public string UserTypeCode { get; set; }
    /// <summary>
    /// 获取或者设置录入时间
    /// </summary>
    [Column("EnterTime", Order = 148)]
    public DateTime? EnterTime { get; set; }
    /// <summary>
    /// 获取或者设置限制
    /// </summary>
    [Column("limits", Order = 149)]
    public int? Limits { get; set; }
    /// <summary>
    /// 获取或者设置挂号标志
    /// </summary>
    [MaxLength(1)]
    [Column("regflag", Order = 150)]
    public string Regflag { get; set; }
    /// <summary>
    /// 获取或者设置组角色
    /// </summary>
    [MaxLength(150)]
    [Column("GROUPROLE", Order = 151)]
    public string GROUPROLE { get; set; }
    /// <summary>
    /// 获取或者设置体温单权限
    /// </summary>
    [MaxLength(1)]
    [Column("temperatureSheet", Order = 152)]
    public string TemperatureSheet { get; set; }
    /// <summary>
    /// 获取或者设置身份证号
    /// </summary>
    [MaxLength(18)]
    [Column("pcid", Order = 153)]
    public string Pcid { get; set; }
    /// <summary>
    /// 获取或者设置证书编号
    /// </summary>
    [MaxLength(50)]
    [Column("certificateNo", Order = 154)]
    public string CertificateNo { get; set; }
    /// <summary>
    /// 获取或者设置是否组长
    /// </summary>
    [MaxLength(2)]
    [Column("isMedgroup", Order = 155)]
    public string IsMedgroup { get; set; }
    /// <summary>
    /// 获取或者设置人事工号
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("OAEmpid", Order = 156)]
    public string OAEmpid { get; set; }
    /// <summary>
    /// 获取或者设置是否外院专家
    /// </summary>
    [MaxLength(2)]
    [Column("isOurHos", Order = 157)]
    public string IsOurHos { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("UseSdate", Order = 158)]
    public DateTime? UseSdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("ybysdm", Order = 159)]
    public string Ybysdm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("zydd", Order = 160)]
    public string Zydd { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("lysj", Order = 161)]
    public DateTime? Lysj { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("empIntroduction", Order = 162)]
    public string EmpIntroduction { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("empGoodat", Order = 163)]
    public string EmpGoodat { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("ybhsdm", Order = 164)]
    public string Ybhsdm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("UseTime", Order = 165)]
    public string UseTime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("IsTest", Order = 166)]
    public int? IsTest { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("jygonghao", Order = 167)]
    public string Jygonghao { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("CaSignature", Order = 168)]
    public string CaSignature { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("CAauthCode", Order = 169)]
    public string CAauthCode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("Zdys", Order = 170)]
    public string Zdys { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Empid;
    }
}