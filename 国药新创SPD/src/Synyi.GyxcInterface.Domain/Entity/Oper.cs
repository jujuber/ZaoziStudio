namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 手术记录表
/// </summary>
[Table("oper")]
[PrimaryKey(nameof(Rdn))]
public sealed class Oper : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 100)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 101)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 102)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 103)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置床位号
    /// </summary>
    [MaxLength(20)]
    [Column("bedid", Order = 104)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(18)]
    [Column("pname", Order = 105)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置性别
    /// </summary>
    [MaxLength(1)]
    [Column("psex", Order = 106)]
    public string Psex { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 107)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置年龄
    /// </summary>
    [Column("age", Order = 108)]
    public int? Age { get; set; }
    /// <summary>
    /// 获取或者设置年龄单位
    /// </summary>
    [MaxLength(1)]
    [Column("ageunit", Order = 109)]
    public string Ageunit { get; set; }
    /// <summary>
    /// 获取或者设置常规急诊
    /// </summary>
    [MaxLength(1)]
    [Column("agent", Order = 110)]
    public string Agent { get; set; }
    /// <summary>
    /// 获取或者设置输入日期
    /// </summary>
    [Column("indate", Order = 111)]
    public DateTime? Indate { get; set; }
    /// <summary>
    /// 获取或者设置申请日期
    /// </summary>
    [Column("askdate", Order = 112)]
    public DateTime? Askdate { get; set; }
    /// <summary>
    /// 获取或者设置计划日期
    /// </summary>
    [Column("plandate", Order = 113)]
    public DateTime? Plandate { get; set; }
    /// <summary>
    /// 获取或者设置开始日期
    /// </summary>
    [Column("startdate", Order = 114)]
    public DateTime? Startdate { get; set; }
    /// <summary>
    /// 获取或者设置结束日期
    /// </summary>
    [Column("enddate", Order = 115)]
    public DateTime? Enddate { get; set; }
    /// <summary>
    /// 获取或者设置申请医生
    /// </summary>
    [MaxLength(20)]
    [Column("askdr", Order = 116)]
    public string Askdr { get; set; }
    /// <summary>
    /// 获取或者设置手术室
    /// </summary>
    [MaxLength(8)]
    [Column("room", Order = 117)]
    public string Room { get; set; }
    /// <summary>
    /// 获取或者设置台次
    /// </summary>
    [Column("cdo", Order = 118)]
    public int? Cdo { get; set; }
    /// <summary>
    /// 获取或者设置临床主诊断代码
    /// </summary>
    [MaxLength(100)]
    [Column("prediagpcode", Order = 119)]
    public string Prediagpcode { get; set; }
    /// <summary>
    /// 获取或者设置临床次诊断代码
    /// </summary>
    [MaxLength(100)]
    [Column("prediagscode", Order = 120)]
    public string Prediagscode { get; set; }
    /// <summary>
    /// 获取或者设置术前主手术代码
    /// </summary>
    [MaxLength(100)]
    [Column("preoperpcode", Order = 121)]
    public string Preoperpcode { get; set; }
    /// <summary>
    /// 获取或者设置术前次手术代码
    /// </summary>
    [MaxLength(100)]
    [Column("preoperscode", Order = 122)]
    public string Preoperscode { get; set; }
    /// <summary>
    /// 获取或者设置术后主诊断
    /// </summary>
    [MaxLength(100)]
    [Column("postdiagpcode", Order = 123)]
    public string Postdiagpcode { get; set; }
    /// <summary>
    /// 获取或者设置术后次诊断
    /// </summary>
    [MaxLength(100)]
    [Column("postdiagscode", Order = 124)]
    public string Postdiagscode { get; set; }
    /// <summary>
    /// 获取或者设置主手术代码
    /// </summary>
    [MaxLength(100)]
    [Column("operpcode", Order = 125)]
    public string Operpcode { get; set; }
    /// <summary>
    /// 获取或者设置次手术代码
    /// </summary>
    [MaxLength(100)]
    [Column("operscode", Order = 126)]
    public string Operscode { get; set; }
    /// <summary>
    /// 获取或者设置麻醉师
    /// </summary>
    [MaxLength(20)]
    [Column("anes", Order = 127)]
    public string Anes { get; set; }
    /// <summary>
    /// 获取或者设置特殊要求
    /// </summary>
    [MaxLength(10)]
    [Column("sptech", Order = 128)]
    public string Sptech { get; set; }
    /// <summary>
    /// 获取或者设置隔离
    /// </summary>
    [MaxLength(5)]
    [Column("isolated", Order = 129)]
    public string Isolated { get; set; }
    /// <summary>
    /// 获取或者设置通知
    /// </summary>
    [MaxLength(20)]
    [Column("notifyby", Order = 130)]
    public string Notifyby { get; set; }
    /// <summary>
    /// 获取或者设置申批
    /// </summary>
    [MaxLength(20)]
    [Column("verifyby", Order = 131)]
    public string Verifyby { get; set; }
    /// <summary>
    /// 获取或者设置手术级别
    /// </summary>
    [MaxLength(1)]
    [Column("operlevel", Order = 132)]
    public string Operlevel { get; set; }
    /// <summary>
    /// 获取或者设置手术并发症
    /// </summary>
    [MaxLength(10)]
    [Column("opcompli", Order = 133)]
    public string Opcompli { get; set; }
    /// <summary>
    /// 获取或者设置手术结果
    /// </summary>
    [MaxLength(1)]
    [Column("opresult", Order = 134)]
    public string Opresult { get; set; }
    /// <summary>
    /// 获取或者设置麻醉并发症
    /// </summary>
    [MaxLength(10)]
    [Column("ancompli", Order = 135)]
    public string Ancompli { get; set; }
    /// <summary>
    /// 获取或者设置麻醉结果
    /// </summary>
    [MaxLength(1)]
    [Column("anresult", Order = 136)]
    public string Anresult { get; set; }
    /// <summary>
    /// 获取或者设置切口类型
    /// </summary>
    [MaxLength(1)]
    [Column("wound", Order = 137)]
    public string Wound { get; set; }
    /// <summary>
    /// 获取或者设置愈合
    /// </summary>
    [MaxLength(1)]
    [Column("heal", Order = 138)]
    public string Heal { get; set; }
    /// <summary>
    /// 获取或者设置感染
    /// </summary>
    [MaxLength(10)]
    [Column("infect", Order = 139)]
    public string Infect { get; set; }
    /// <summary>
    /// 获取或者设置执行标志
    /// </summary>
    [MaxLength(20)]
    [Column("doflag", Order = 140)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置主刀
    /// </summary>
    [MaxLength(20)]
    [Column("drp", Order = 141)]
    public string Drp { get; set; }
    /// <summary>
    /// 获取或者设置助一
    /// </summary>
    [MaxLength(20)]
    [Column("drs", Order = 142)]
    public string Drs { get; set; }
    /// <summary>
    /// 获取或者设置助二
    /// </summary>
    [MaxLength(20)]
    [Column("drt", Order = 143)]
    public string Drt { get; set; }
    /// <summary>
    /// 获取或者设置主麻
    /// </summary>
    [MaxLength(20)]
    [Column("ansp", Order = 144)]
    public string Ansp { get; set; }
    /// <summary>
    /// 获取或者设置助麻
    /// </summary>
    [MaxLength(20)]
    [Column("anss", Order = 145)]
    public string Anss { get; set; }
    /// <summary>
    /// 获取或者设置主管护士
    /// </summary>
    [MaxLength(20)]
    [Column("nsp", Order = 146)]
    public string Nsp { get; set; }
    /// <summary>
    /// 获取或者设置助理护士
    /// </summary>
    [MaxLength(20)]
    [Column("nss", Order = 147)]
    public string Nss { get; set; }
    /// <summary>
    /// 获取或者设置助理护士1
    /// </summary>
    [MaxLength(20)]
    [Column("nst", Order = 148)]
    public string Nst { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(100)]
    [Column("remark", Order = 149)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置术前诊断
    /// </summary>
    [MaxLength(100)]
    [Column("pred", Order = 150)]
    public string Pred { get; set; }
    /// <summary>
    /// 获取或者设置术后诊断
    /// </summary>
    [MaxLength(100)]
    [Column("postd", Order = 151)]
    public string Postd { get; set; }
    /// <summary>
    /// 获取或者设置主手术
    /// </summary>
    [MaxLength(200)]
    [Column("operp", Order = 152)]
    public string Operp { get; set; }
    /// <summary>
    /// 获取或者设置次手术
    /// </summary>
    [MaxLength(200)]
    [Column("opers", Order = 153)]
    public string Opers { get; set; }
    /// <summary>
    /// 获取或者设置其它a
    /// </summary>
    [MaxLength(50)]
    [Column("othera", Order = 154)]
    public string Othera { get; set; }
    /// <summary>
    /// 获取或者设置其它b
    /// </summary>
    [MaxLength(50)]
    [Column("otherb", Order = 155)]
    public string Otherb { get; set; }
    /// <summary>
    /// 获取或者设置其它c
    /// </summary>
    [MaxLength(50)]
    [Column("otherc", Order = 156)]
    public string Otherc { get; set; }
    /// <summary>
    /// 获取或者设置其它d
    /// </summary>
    [MaxLength(10)]
    [Column("otherd", Order = 157)]
    public string Otherd { get; set; }
    /// <summary>
    /// 获取或者设置申请单号
    /// </summary>
    [Column("orderno", Order = 158)]
    public int? Orderno { get; set; }
    /// <summary>
    /// 获取或者设置术前主手术
    /// </summary>
    [MaxLength(200)]
    [Column("preoperp", Order = 159)]
    public string Preoperp { get; set; }
    /// <summary>
    /// 获取或者设置术前次手术
    /// </summary>
    [MaxLength(200)]
    [Column("preopers", Order = 160)]
    public string Preopers { get; set; }
    /// <summary>
    /// 获取或者设置手术部门
    /// </summary>
    [MaxLength(20)]
    [Column("opdept", Order = 161)]
    public string Opdept { get; set; }
    /// <summary>
    /// 获取或者设置麻醉部门
    /// </summary>
    [MaxLength(20)]
    [Column("anedept", Order = 162)]
    public string Anedept { get; set; }
    /// <summary>
    /// 获取或者设置操作员工号
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 163)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置麻醉经办
    /// </summary>
    [MaxLength(20)]
    [Column("anjp", Order = 164)]
    public string Anjp { get; set; }
    /// <summary>
    /// 获取或者设置手术时间
    /// </summary>
    [Precision(10, 2)]
    [Column("optime", Order = 165)]
    public decimal? Optime { get; set; }
    /// <summary>
    /// 获取或者设置麻醉方法
    /// </summary>
    [MaxLength(60)]
    [Column("aneask", Order = 166)]
    public string Aneask { get; set; }
    /// <summary>
    /// 获取或者设置部位
    /// </summary>
    [MaxLength(10)]
    [Column("part", Order = 167)]
    public string Part { get; set; }
    /// <summary>
    /// 获取或者设置失血
    /// </summary>
    [Column("bloodloss", Order = 168)]
    public int? Bloodloss { get; set; }
    /// <summary>
    /// 获取或者设置成分血1
    /// </summary>
    [Column("prbc", Order = 169)]
    public int? Prbc { get; set; }
    /// <summary>
    /// 获取或者设置成分血2
    /// </summary>
    [Column("ffp", Order = 170)]
    public int? Ffp { get; set; }
    /// <summary>
    /// 获取或者设置血小板
    /// </summary>
    [Column("plates", Order = 171)]
    public int? Plates { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("noterdn_nur04", Order = 172)]
    public int? NoterdnNur04 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("noterdn_nur80", Order = 173)]
    public int? NoterdnNur80 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("ynzzss", Order = 174)]
    public string Ynzzss { get; set; }
    /// <summary>
    /// 获取或者设置手术状态
    /// </summary>
    [MaxLength(2)]
    [Column("oper_statics", Order = 175)]
    public string OperStatics { get; set; }
    /// <summary>
    /// 获取或者设置转移方式
    /// </summary>
    [MaxLength(2)]
    [Column("movemode", Order = 176)]
    public string Movemode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(256)]
    [Column("cacode", Order = 177)]
    public string Cacode { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 178)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置执行院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 179)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置医生科室
    /// </summary>
    [MaxLength(255)]
    [Column("drpdept", Order = 180)]
    public string Drpdept { get; set; }
    /// <summary>
    /// 获取或者设置伤口处理
    /// </summary>
    [MaxLength(50)]
    [Column("swound", Order = 181)]
    public string Swound { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("IsBD", Order = 182)]
    public string IsBD { get; set; }
    /// <summary>
    /// 获取或者设置更新时间
    /// </summary>
    [Column("Updatetime", Order = 183)]
    public DateTime? Updatetime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("daysurgery", Order = 184)]
    public string Daysurgery { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("ExternalKnifeFlag", Order = 185)]
    public string ExternalKnifeFlag { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}