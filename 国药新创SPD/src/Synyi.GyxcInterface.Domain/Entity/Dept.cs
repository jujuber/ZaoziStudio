namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 科室基础表
/// </summary>
[Table("dept")]
[PrimaryKey(nameof(Deptid))]
public class Dept : EqualObject
{
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("deptid", Order = 100)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置科室名称
    /// </summary>
    [MaxLength(40)]
    [Column("deptname", Order = 101)]
    public string Deptname { get; set; }
    /// <summary>
    /// 获取或者设置上级码
    /// </summary>
    [MaxLength(20)]
    [Column("forward", Order = 102)]
    public string Forward { get; set; }
    /// <summary>
    /// 获取或者设置热键
    /// </summary>
    [MaxLength(3)]
    [Column("hotkey", Order = 103)]
    public string Hotkey { get; set; }
    /// <summary>
    /// 获取或者设置状态（1行政，2后勤，3医生，4护理，5医技，6药剂，7其他）
    /// </summary>
    [MaxLength(1)]
    [Column("status", Order = 104)]
    public string Status { get; set; }
    /// <summary>
    /// 获取或者设置区域
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 105)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("ecnomic", Order = 106)]
    public string Ecnomic { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 107)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置拼音码
    /// </summary>
    [MaxLength(20)]
    [Column("py", Order = 108)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置挂号标志
    /// </summary>
    [MaxLength(1)]
    [Column("regflag", Order = 109)]
    public string Regflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(7)]
    [Column("cd", Order = 110)]
    public string Cd { get; set; }
    /// <summary>
    /// 获取或者设置库房标志（A：药库，D：药房，3：三级库，S：药店）
    /// </summary>
    [MaxLength(1)]
    [Column("dflag", Order = 111)]
    public string Dflag { get; set; }
    /// <summary>
    /// 获取或者设置挂号类别（1普通，2专家，3急诊）
    /// </summary>
    [MaxLength(1)]
    [Column("regtype", Order = 112)]
    public string Regtype { get; set; }
    /// <summary>
    /// 获取或者设置库房管理与目录对应关系（0西药库；1成药库；2中药库；3材料库） 可多选
    /// </summary>
    [MaxLength(1)]
    [Column("sflag", Order = 113)]
    public string Sflag { get; set; }
    /// <summary>
    /// 获取或者设置欠费限额
    /// </summary>
    [Precision(16, 4)]
    [Column("feelimit", Order = 114)]
    public decimal? Feelimit { get; set; }
    /// <summary>
    /// 获取或者设置简码
    /// </summary>
    [MaxLength(3)]
    [Column("simple", Order = 115)]
    public string Simple { get; set; }
    /// <summary>
    /// 获取或者设置别名
    /// </summary>
    [MaxLength(40)]
    [Column("bm", Order = 116)]
    public string Bm { get; set; }
    /// <summary>
    /// 获取或者设置全检索
    /// </summary>
    [MaxLength(20)]
    [Column("alldeptflag", Order = 117)]
    public string Alldeptflag { get; set; }
    /// <summary>
    /// 获取或者设置限号选医生标志
    /// </summary>
    [MaxLength(20)]
    [Column("deptlr", Order = 118)]
    public string Deptlr { get; set; }
    /// <summary>
    /// 获取或者设置附加费标志
    /// </summary>
    [MaxLength(20)]
    [Column("deptadd", Order = 119)]
    public string Deptadd { get; set; }
    /// <summary>
    /// 获取或者设置药房部门
    /// </summary>
    [Column("deptpharm", Order = 120)]
    public int? Deptpharm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("ybdeptid", Order = 121)]
    public string Ybdeptid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("yjks", Order = 122)]
    public string Yjks { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(4)]
    [Column("ftype", Order = 123)]
    public string Ftype { get; set; }
    /// <summary>
    /// 获取或者设置排序
    /// </summary>
    [MaxLength(5)]
    [Column("sort", Order = 124)]
    public string Sort { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("simplename", Order = 125)]
    public string Simplename { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("gh", Order = 126)]
    public string Gh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("baformard", Order = 127)]
    public string Baformard { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("baorder", Order = 128)]
    public string Baorder { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("bonusdept", Order = 129)]
    public string Bonusdept { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("printtime", Order = 130)]
    public DateTime? Printtime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("printtime_a", Order = 131)]
    public DateTime? PrinttimeA { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("printtime_b", Order = 132)]
    public DateTime? PrinttimeB { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("bedquota", Order = 133)]
    public decimal? Bedquota { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("timea", Order = 134)]
    public string Timea { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("timeb", Order = 135)]
    public string Timeb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("regfcode", Order = 136)]
    public string Regfcode { get; set; }
    /// <summary>
    /// 获取或者设置院区标记
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 137)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("hostrandt", Order = 138)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 139)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置病区代码
    /// </summary>
    [MaxLength(20)]
    [Column("beddeptcode", Order = 140)]
    public string Beddeptcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("xyflag", Order = 141)]
    public string Xyflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("pivas", Order = 142)]
    public string Pivas { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("reportsort", Order = 143)]
    public int? Reportsort { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("xh", Order = 144)]
    public string Xh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(40)]
    [Column("ygybflag", Order = 145)]
    public string Ygybflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(8)]
    [Column("restrict_rdn", Order = 146)]
    public string RestrictRdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(255)]
    [Column("drpdept", Order = 147)]
    public string Drpdept { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("depttelephone", Order = 148)]
    public string Depttelephone { get; set; }
    /// <summary>
    /// 获取或者设置对应系统
    /// </summary>
    [MaxLength(300)]
    [Column("OPENEXE", Order = 149)]
    public string OPENEXE { get; set; }
    /// <summary>
    /// 获取或者设置病历标记
    /// </summary>
    [Column("emr_first", Order = 150)]
    public int? EmrFirst { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("bdflag", Order = 151)]
    public string Bdflag { get; set; }
    /// <summary>
    /// 获取或者设置科室职能
    /// </summary>
    [MaxLength(20)]
    [Column("DeptFun", Order = 152)]
    public string DeptFun { get; set; }
    /// <summary>
    /// 获取或者设置一级学科
    /// </summary>
    [MaxLength(20)]
    [Column("OneSubject", Order = 153)]
    public string OneSubject { get; set; }
    /// <summary>
    /// 获取或者设置二级学科
    /// </summary>
    [MaxLength(20)]
    [Column("SecondSubject", Order = 154)]
    public string SecondSubject { get; set; }
    /// <summary>
    /// 获取或者设置最小单位
    /// </summary>
    [MaxLength(20)]
    [Column("SmallestUnit", Order = 155)]
    public string SmallestUnit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("IsTest", Order = 156)]
    public int? IsTest { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("address", Order = 157)]
    public string Address { get; set; }
    /// <summary>
    /// 获取或者设置康复标志
    /// </summary>
    [Column("kfbz", Order = 158)]
    public int? Kfbz { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Deptid;
    }
}