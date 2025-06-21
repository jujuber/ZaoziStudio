namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医技使用申请单
/// </summary>
[Table("clinicreport")]
[PrimaryKey(nameof(Orderflag), nameof(Orderno))]
public sealed class Clinicreport : EqualObject
{
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("JJflag", Order = 100)]
    public string JJflag { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("orderflag", Order = 101)]
    public string Orderflag { get; set; }
    /// <summary>
    /// 获取或者设置医嘱号
    /// </summary>
    [Required]
    [Column("orderno", Order = 102)]
    public int Orderno { get; set; }
    /// <summary>
    /// 获取或者设置报告单号
    /// </summary>
    [MaxLength(18)]
    [Column("accession", Order = 103)]
    public string Accession { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 104)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊序号
    /// </summary>
    [Column("series", Order = 105)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置病人姓名
    /// </summary>
    [MaxLength(50)]
    [Column("pname", Order = 106)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置性别
    /// </summary>
    [MaxLength(1)]
    [Column("psex", Order = 107)]
    public string Psex { get; set; }
    /// <summary>
    /// 获取或者设置年龄
    /// </summary>
    [Column("page", Order = 108)]
    public int? Page { get; set; }
    /// <summary>
    /// 获取或者设置病人来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 109)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置床位号
    /// </summary>
    [MaxLength(20)]
    [Column("bedid", Order = 110)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置病人类别
    /// </summary>
    [MaxLength(2)]
    [Column("service", Order = 111)]
    public string Service { get; set; }
    /// <summary>
    /// 获取或者设置病人临床科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptin", Order = 112)]
    public string Deptin { get; set; }
    /// <summary>
    /// 获取或者设置医技科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 113)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置申请医生
    /// </summary>
    [MaxLength(20)]
    [Column("sdr", Order = 114)]
    public string Sdr { get; set; }
    /// <summary>
    /// 获取或者设置申请日期
    /// </summary>
    [Column("sdate", Order = 115)]
    public DateTime? Sdate { get; set; }
    /// <summary>
    /// 获取或者设置临床诊断代码
    /// </summary>
    [MaxLength(200)]
    [Column("cdiagcode", Order = 116)]
    public string Cdiagcode { get; set; }
    /// <summary>
    /// 获取或者设置临床诊断名称
    /// </summary>
    [MaxLength(200)]
    [Column("cdiag", Order = 117)]
    public string Cdiag { get; set; }
    /// <summary>
    /// 获取或者设置部位代码
    /// </summary>
    [MaxLength(250)]
    [Column("tcode", Order = 118)]
    public string Tcode { get; set; }
    /// <summary>
    /// 获取或者设置申请项目代码
    /// </summary>
    [MaxLength(250)]
    [Column("ecode", Order = 119)]
    public string Ecode { get; set; }
    /// <summary>
    /// 获取或者设置项目内容
    /// </summary>
    [MaxLength(250)]
    [Column("etext", Order = 120)]
    public string Etext { get; set; }
    /// <summary>
    /// 获取或者设置描述
    /// </summary>
    [MaxLength(400)]
    [Column("exam", Order = 121)]
    public string Exam { get; set; }
    /// <summary>
    /// 获取或者设置医技结论
    /// </summary>
    [MaxLength(400)]
    [Column("pdiag", Order = 122)]
    public string Pdiag { get; set; }
    /// <summary>
    /// 获取或者设置诊断医生
    /// </summary>
    [MaxLength(20)]
    [Column("pdr", Order = 123)]
    public string Pdr { get; set; }
    /// <summary>
    /// 获取或者设置诊断日期
    /// </summary>
    [Column("pdate", Order = 124)]
    public DateTime? Pdate { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(250)]
    [Column("annotation", Order = 125)]
    public string Annotation { get; set; }
    /// <summary>
    /// 获取或者设置标本类型
    /// </summary>
    [MaxLength(2)]
    [Column("slidetype", Order = 126)]
    public string Slidetype { get; set; }
    /// <summary>
    /// 获取或者设置执行标志
    /// </summary>
    [MaxLength(1)]
    [Column("doflag", Order = 127)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置住院标志
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 128)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("distrbute", Order = 129)]
    public string Distrbute { get; set; }
    /// <summary>
    /// 获取或者设置审核标志
    /// </summary>
    [MaxLength(1)]
    [Column("checkflag", Order = 130)]
    public string Checkflag { get; set; }
    /// <summary>
    /// 获取或者设置收费标志
    /// </summary>
    [MaxLength(1)]
    [Column("chargflag", Order = 131)]
    public string Chargflag { get; set; }
    /// <summary>
    /// 获取或者设置诊断代码
    /// </summary>
    [MaxLength(250)]
    [Column("pcode", Order = 132)]
    public string Pcode { get; set; }
    /// <summary>
    /// 获取或者设置病区
    /// </summary>
    [MaxLength(20)]
    [Column("deptbed", Order = 133)]
    public string Deptbed { get; set; }
    /// <summary>
    /// 获取或者设置总费用
    /// </summary>
    [Precision(18, 2)]
    [Column("totalfee", Order = 134)]
    public decimal? Totalfee { get; set; }
    /// <summary>
    /// 获取或者设置主诉
    /// </summary>
    [MaxLength(400)]
    [Column("complain", Order = 135)]
    public string Complain { get; set; }
    /// <summary>
    /// 获取或者设置检验部门
    /// </summary>
    [MaxLength(20)]
    [Column("labdept", Order = 136)]
    public string Labdept { get; set; }
    /// <summary>
    /// 获取或者设置标验标志
    /// </summary>
    [MaxLength(5)]
    [Column("labflag", Order = 137)]
    public string Labflag { get; set; }
    /// <summary>
    /// 获取或者设置上传标志
    /// </summary>
    [MaxLength(1)]
    [Column("transflag", Order = 138)]
    public string Transflag { get; set; }
    /// <summary>
    /// 获取或者设置房号
    /// </summary>
    [MaxLength(8)]
    [Column("roomno", Order = 139)]
    public string Roomno { get; set; }
    /// <summary>
    /// 获取或者设置相关号
    /// </summary>
    [Column("relano", Order = 140)]
    public int? Relano { get; set; }
    /// <summary>
    /// 获取或者设置停止医生
    /// </summary>
    [MaxLength(20)]
    [Column("stopdr", Order = 141)]
    public string Stopdr { get; set; }
    /// <summary>
    /// 获取或者设置停嘱日期
    /// </summary>
    [Column("stopdate", Order = 142)]
    public DateTime? Stopdate { get; set; }
    /// <summary>
    /// 获取或者设置医嘱性质
    /// </summary>
    [MaxLength(1)]
    [Column("ordertype", Order = 143)]
    public string Ordertype { get; set; }
    /// <summary>
    /// 获取或者设置效期
    /// </summary>
    [Column("duration", Order = 144)]
    public int? Duration { get; set; }
    /// <summary>
    /// 获取或者设置输入日期
    /// </summary>
    [Column("datein", Order = 145)]
    public DateTime? Datein { get; set; }
    /// <summary>
    /// 获取或者设置频率
    /// </summary>
    [MaxLength(50)]
    [Column("frequency", Order = 146)]
    public string Frequency { get; set; }
    /// <summary>
    /// 获取或者设置用法
    /// </summary>
    [MaxLength(50)]
    [Column("admission", Order = 147)]
    public string Admission { get; set; }
    /// <summary>
    /// 获取或者设置申请单当前状态
    /// </summary>
    [MaxLength(5)]
    [Column("registerflag", Order = 148)]
    public string Registerflag { get; set; }
    /// <summary>
    /// 获取或者设置急诊标志
    /// </summary>
    [MaxLength(1)]
    [Column("emerflag", Order = 149)]
    public string Emerflag { get; set; }
    /// <summary>
    /// 获取或者设置转运标志
    /// </summary>
    [MaxLength(2)]
    [Column("movemode", Order = 150)]
    public string Movemode { get; set; }
    /// <summary>
    /// 获取或者设置自费
    /// </summary>
    [Precision(18, 2)]
    [Column("totalfeez", Order = 151)]
    public decimal? Totalfeez { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [MaxLength(50)]
    [Column("numbstring", Order = 152)]
    public string Numbstring { get; set; }
    /// <summary>
    /// 获取或者设置院区
    /// </summary>
    [MaxLength(10)]
    [Column("hoscode", Order = 153)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("mutertype", Order = 154)]
    public string Mutertype { get; set; }
    /// <summary>
    /// 获取或者设置执行院区
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 155)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("yjpprint", Order = 156)]
    public string Yjpprint { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("lisbackxml", Order = 157)]
    public string Lisbackxml { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("lisbackitem", Order = 158)]
    public string Lisbackitem { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("cease", Order = 159)]
    public string Cease { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("APPID", Order = 160)]
    public string APPID { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cissqdxh", Order = 161)]
    public long? Cissqdxh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cisxhlb", Order = 162)]
    public int? Cisxhlb { get; set; }
    /// <summary>
    /// 获取或者设置申请单附属信息
    /// </summary>
    [Column("sqdfsxx", Order = 163)]
    public string Sqdfsxx { get; set; }
    /// <summary>
    /// 获取或者设置输血申请单号
    /// </summary>
    [Column("tfsqdno", Order = 164)]
    public string Tfsqdno { get; set; }
    /// <summary>
    /// 获取或者设置输血申请单血型
    /// </summary>
    [Column("tfsqdxx", Order = 165)]
    public string Tfsqdxx { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Orderflag;
        yield return Orderno;
    }

}