namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 床位表
/// </summary>
[Table("bed")]
[PrimaryKey(nameof(Bedid))]
public class Bed : EqualObject
{
    /// <summary>
    /// 获取或者设置用于床位排序
    /// </summary>
    [Column("bedsort", Order = 100)]
    public int? Bedsort { get; set; }
    /// <summary>
    /// 获取或者设置床位号
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("bedid", Order = 101)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 102)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 103)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(30)]
    [Column("pname", Order = 104)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置性别
    /// </summary>
    [MaxLength(1)]
    [Column("psex", Order = 105)]
    public string Psex { get; set; }
    /// <summary>
    /// 获取或者设置年龄
    /// </summary>
    [Column("age", Order = 106)]
    public int? Age { get; set; }
    /// <summary>
    /// 获取或者设置年龄的那位
    /// </summary>
    [MaxLength(1)]
    [Column("ageunit", Order = 107)]
    public string Ageunit { get; set; }
    /// <summary>
    /// 获取或者设置科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptin", Order = 108)]
    public string Deptin { get; set; }
    /// <summary>
    /// 获取或者设置病区
    /// </summary>
    [MaxLength(20)]
    [Column("deptbed", Order = 109)]
    public string Deptbed { get; set; }
    /// <summary>
    /// 获取或者设置入院日期
    /// </summary>
    [Column("admid", Order = 110)]
    public DateTime? Admid { get; set; }
    /// <summary>
    /// 获取或者设置出院日志
    /// </summary>
    [Column("discd", Order = 111)]
    public DateTime? Discd { get; set; }
    /// <summary>
    /// 获取或者设置床位占用
    /// </summary>
    [MaxLength(1)]
    [Column("occu", Order = 112)]
    public string Occu { get; set; }
    /// <summary>
    /// 获取或者设置床位收费类型
    /// </summary>
    [MaxLength(18)]
    [Column("bedtype", Order = 113)]
    public string Bedtype { get; set; }
    /// <summary>
    /// 获取或者设置空调（0、无 1、有空调 ）
    /// </summary>
    [MaxLength(1)]
    [Column("aircondi", Order = 114)]
    public string Aircondi { get; set; }
    /// <summary>
    /// 获取或者设置医嘱控制（0、控制 1、不控制
    /// </summary>
    [MaxLength(1)]
    [Column("inft", Order = 115)]
    public string Inft { get; set; }
    /// <summary>
    /// 获取或者设置母婴标志
    /// </summary>
    [MaxLength(1)]
    [Column("mother", Order = 116)]
    public string Mother { get; set; }
    /// <summary>
    /// 获取或者设置探视者
    /// </summary>
    [MaxLength(1)]
    [Column("visitor", Order = 117)]
    public string Visitor { get; set; }
    /// <summary>
    /// 获取或者设置机内号
    /// </summary>
    [Column("interid", Order = 118)]
    public int? Interid { get; set; }
    /// <summary>
    /// 获取或者设置过敏信息
    /// </summary>
    [MaxLength(2)]
    [Column("allergy", Order = 119)]
    public string Allergy { get; set; }
    /// <summary>
    /// 获取或者设置护理级别（1、一级护理 2、二级护理 3、三级护理）
    /// </summary>
    [MaxLength(200)]
    [Column("caretype", Order = 120)]
    public string Caretype { get; set; }
    /// <summary>
    /// 获取或者设置诊断
    /// </summary>
    [MaxLength(200)]
    [Column("diag", Order = 121)]
    public string Diag { get; set; }
    /// <summary>
    /// 获取或者设置床位特性
    /// </summary>
    [MaxLength(1)]
    [Column("bedstatus", Order = 122)]
    public string Bedstatus { get; set; }
    /// <summary>
    /// 获取或者设置病人类别
    /// </summary>
    [MaxLength(2)]
    [Column("service", Order = 123)]
    public string Service { get; set; }
    /// <summary>
    /// 获取或者设置房间号
    /// </summary>
    [MaxLength(3)]
    [Column("room", Order = 124)]
    public string Room { get; set; }
    /// <summary>
    /// 获取或者设置打印行号
    /// </summary>
    [Column("rownumb", Order = 125)]
    public int? Rownumb { get; set; }
    /// <summary>
    /// 获取或者设置开放天数
    /// </summary>
    [Column("controlday", Order = 126)]
    public int? Controlday { get; set; }
    /// <summary>
    /// 获取或者设置经办
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 127)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置控制起始日期
    /// </summary>
    [Column("controlstart", Order = 128)]
    public DateTime? Controlstart { get; set; }
    /// <summary>
    /// 获取或者设置关联病历号
    /// </summary>
    [Column("relamrn", Order = 129)]
    public int? Relamrn { get; set; }
    /// <summary>
    /// 获取或者设置默认科室
    /// </summary>
    [MaxLength(20)]
    [Column("defultdept", Order = 130)]
    public string Defultdept { get; set; }
    /// <summary>
    /// 获取或者设置床位收费日期
    /// </summary>
    [Column("beddate", Order = 131)]
    public DateTime? Beddate { get; set; }
    /// <summary>
    /// 获取或者设置上次结算日期
    /// </summary>
    [Column("lastjs", Order = 132)]
    public DateTime? Lastjs { get; set; }
    /// <summary>
    /// 获取或者设置/
    /// </summary>
    [Precision(16, 4)]
    [Column("zerototal", Order = 133)]
    public decimal? Zerototal { get; set; }
    /// <summary>
    /// 获取或者设置//
    /// </summary>
    [Precision(16, 4)]
    [Column("zerototalz", Order = 134)]
    public decimal? Zerototalz { get; set; }
    /// <summary>
    /// 获取或者设置饮食类别
    /// </summary>
    [MaxLength(1)]
    [Column("foodtype", Order = 135)]
    public string Foodtype { get; set; }
    /// <summary>
    /// 获取或者设置医保码
    /// </summary>
    [MaxLength(50)]
    [Column("insucode", Order = 136)]
    public string Insucode { get; set; }
    /// <summary>
    /// 获取或者设置社保身份类别
    /// </summary>
    [MaxLength(10)]
    [Column("insukind", Order = 137)]
    public string Insukind { get; set; }
    /// <summary>
    /// 获取或者设置社保身份变更
    /// </summary>
    [MaxLength(2)]
    [Column("newser", Order = 138)]
    public string Newser { get; set; }
    /// <summary>
    /// 获取或者设置社保就诊类别
    /// </summary>
    [MaxLength(2)]
    [Column("stayinsu", Order = 139)]
    public string Stayinsu { get; set; }
    /// <summary>
    /// 获取或者设置社保单位类别
    /// </summary>
    [MaxLength(2)]
    [Column("unittype", Order = 140)]
    public string Unittype { get; set; }
    /// <summary>
    /// 获取或者设置诊断代码
    /// </summary>
    [MaxLength(200)]
    [Column("diagcode", Order = 141)]
    public string Diagcode { get; set; }
    /// <summary>
    /// 获取或者设置关联使用
    /// </summary>
    [MaxLength(1)]
    [Column("realused", Order = 142)]
    public string Realused { get; set; }
    /// <summary>
    /// 获取或者设置自由收费标志
    /// </summary>
    [MaxLength(1)]
    [Column("freeflag", Order = 143)]
    public string Freeflag { get; set; }
    /// <summary>
    /// 获取或者设置卡号
    /// </summary>
    [MaxLength(15)]
    [Column("cardid", Order = 144)]
    public string Cardid { get; set; }
    /// <summary>
    /// 获取或者设置新医嘱标志
    /// </summary>
    [MaxLength(1)]
    [Column("neworderflag", Order = 145)]
    public string Neworderflag { get; set; }
    /// <summary>
    /// 获取或者设置是否入科
    /// </summary>
    [MaxLength(1)]
    [Column("fl", Order = 146)]
    public string Fl { get; set; }
    /// <summary>
    /// 获取或者设置预出院标志
    /// </summary>
    [MaxLength(1)]
    [Column("readytooutflag", Order = 147)]
    public string Readytooutflag { get; set; }
    /// <summary>
    /// 获取或者设置预出院日期
    /// </summary>
    [Column("ycydate", Order = 148)]
    public DateTime? Ycydate { get; set; }
    /// <summary>
    /// 获取或者设置预出院
    /// </summary>
    [MaxLength(1)]
    [Column("ycyflag", Order = 149)]
    public string Ycyflag { get; set; }
    /// <summary>
    /// 获取或者设置预出院备注
    /// </summary>
    [MaxLength(60)]
    [Column("ycyremark", Order = 150)]
    public string Ycyremark { get; set; }
    /// <summary>
    /// 获取或者设置主管医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 151)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置主治医生
    /// </summary>
    [MaxLength(10)]
    [Column("fellow", Order = 152)]
    public string Fellow { get; set; }
    /// <summary>
    /// 获取或者设置见习医生
    /// </summary>
    [MaxLength(10)]
    [Column("resident", Order = 153)]
    public string Resident { get; set; }
    /// <summary>
    /// 获取或者设置手术日期
    /// </summary>
    [MaxLength(20)]
    [Column("operdate", Order = 154)]
    public string Operdate { get; set; }
    /// <summary>
    /// 获取或者设置病历书写次数
    /// </summary>
    [Column("emrcount", Order = 155)]
    public int? Emrcount { get; set; }
    /// <summary>
    /// 获取或者设置费用控制金额
    /// </summary>
    [Precision(18, 4)]
    [Column("Controlsfee", Order = 156)]
    public decimal? Controlsfee { get; set; }
    /// <summary>
    /// 获取或者设置结算锁定标志
    /// </summary>
    [MaxLength(1)]
    [Column("jslock", Order = 157)]
    public string Jslock { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 158)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置是否为婴儿
    /// </summary>
    [MaxLength(1)]
    [Column("isbaby", Order = 159)]
    public string Isbaby { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("nurse", Order = 160)]
    public string Nurse { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Bedid;
    }
}