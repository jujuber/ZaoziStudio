namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 病历明细表
/// </summary>
[Table("cpr_pr")]
[PrimaryKey(nameof(Rdn))]
public sealed class CprPr : EqualObject
{
    /// <summary>
    /// 获取或者设置执行科室代码
    /// </summary>
    [MaxLength(50)]
    [Column("rdeptid", Order = 100)]
    public string Rdeptid { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 101)]
    public int Rdn { get; set; }
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
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 104)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(3)]
    [Column("prtype", Order = 105)]
    public string Prtype { get; set; }
    /// <summary>
    /// 获取或者设置标题
    /// </summary>
    [MaxLength(200)]
    [Column("prtitle", Order = 106)]
    public string Prtitle { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(16)]
    [Column("precode", Order = 107)]
    public string Precode { get; set; }
    /// <summary>
    /// 获取或者设置医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 108)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置执行日期
    /// </summary>
    [Column("dodate", Order = 109)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置执行代码
    /// </summary>
    [MaxLength(8)]
    [Column("docode", Order = 110)]
    public string Docode { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 111)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 112)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置更新标志
    /// </summary>
    [MaxLength(1)]
    [Column("updateflag", Order = 113)]
    public string Updateflag { get; set; }
    /// <summary>
    /// 获取或者设置更新日期
    /// </summary>
    [Column("updatedate", Order = 114)]
    public DateTime? Updatedate { get; set; }
    /// <summary>
    /// 获取或者设置审核人
    /// </summary>
    [MaxLength(20)]
    [Column("checkdr", Order = 115)]
    public string Checkdr { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 116)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置病区
    /// </summary>
    [MaxLength(20)]
    [Column("ydeptid", Order = 117)]
    public string Ydeptid { get; set; }
    /// <summary>
    /// 获取或者设置床位号
    /// </summary>
    [MaxLength(20)]
    [Column("bedid", Order = 118)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(30)]
    [Column("pname", Order = 119)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置性别
    /// </summary>
    [MaxLength(1)]
    [Column("psex", Order = 120)]
    public string Psex { get; set; }
    /// <summary>
    /// 获取或者设置执行标志
    /// </summary>
    [MaxLength(1)]
    [Column("doflag", Order = 121)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置去向部门
    /// </summary>
    [MaxLength(20)]
    [Column("todept", Order = 122)]
    public string Todept { get; set; }
    /// <summary>
    /// 获取或者设置申请类别
    /// </summary>
    [MaxLength(1)]
    [Column("ordertype", Order = 123)]
    public string Ordertype { get; set; }
    /// <summary>
    /// 获取或者设置输入日期
    /// </summary>
    [Column("indate", Order = 124)]
    public DateTime? Indate { get; set; }
    /// <summary>
    /// 获取或者设置申请日期
    /// </summary>
    [Column("sdate", Order = 125)]
    public DateTime? Sdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("condiflag", Order = 126)]
    public string Condiflag { get; set; }
    /// <summary>
    /// 获取或者设置诊断
    /// </summary>
    [MaxLength(100)]
    [Column("diag", Order = 127)]
    public string Diag { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(100)]
    [Column("remark", Order = 128)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置关联号
    /// </summary>
    [Column("relano", Order = 129)]
    public int? Relano { get; set; }
    /// <summary>
    /// 获取或者设置年龄
    /// </summary>
    [Column("age", Order = 130)]
    public int? Age { get; set; }
    /// <summary>
    /// 获取或者设置审核标志
    /// </summary>
    [MaxLength(1)]
    [Column("checkflag", Order = 131)]
    public string Checkflag { get; set; }
    /// <summary>
    /// 获取或者设置审核日期
    /// </summary>
    [Column("checkdate", Order = 132)]
    public DateTime? Checkdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("ssh", Order = 133)]
    public string Ssh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("fdr", Order = 134)]
    public string Fdr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("prtype_b", Order = 135)]
    public string PrtypeB { get; set; }
    /// <summary>
    /// 获取或者设置入院日期
    /// </summary>
    [Column("admid", Order = 136)]
    public DateTime? Admid { get; set; }
    /// <summary>
    /// 获取或者设置更新医生
    /// </summary>
    [MaxLength(20)]
    [Column("updatedr", Order = 137)]
    public string Updatedr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("said", Order = 138)]
    public string Said { get; set; }
    /// <summary>
    /// 获取或者设置手术日期
    /// </summary>
    [Column("operdate", Order = 139)]
    public DateTime? Operdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("sqjcflag", Order = 140)]
    public string Sqjcflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("sqcgflag", Order = 141)]
    public string Sqcgflag { get; set; }
    /// <summary>
    /// 获取或者设置特殊检查
    /// </summary>
    [MaxLength(100)]
    [Column("specialcheck", Order = 142)]
    public string Specialcheck { get; set; }
    /// <summary>
    /// 获取或者设置模板id
    /// </summary>
    [Column("modelid", Order = 143)]
    public int? Modelid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("yjk", Order = 144)]
    public string Yjk { get; set; }
    /// <summary>
    /// 获取或者设置诊断名称
    /// </summary>
    [MaxLength(200)]
    [Column("diagname", Order = 145)]
    public string Diagname { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 146)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置执行院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 147)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("grouptype", Order = 148)]
    public string Grouptype { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("consulType", Order = 149)]
    public string ConsulType { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("SignDr", Order = 150)]
    public string SignDr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("SignDate", Order = 151)]
    public DateTime? SignDate { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}