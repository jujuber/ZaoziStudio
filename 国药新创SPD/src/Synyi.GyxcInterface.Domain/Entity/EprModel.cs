namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医嘱模板
/// </summary>
[Table("epr_model")]
[PrimaryKey(nameof(Rdn))]
public class EprModel : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Column("rdn", Order = 100)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置父记录号
    /// </summary>
    [Column("parentrdn", Order = 101)]
    public int? ParentRdn { get; set; }
    /// <summary>
    /// 获取或者设置级别
    /// </summary>
    [Column("leve", Order = 102)]
    public int? Leve { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 103)]
    public string DeptId { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(100)]
    [Column("remark", Order = 104)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置内容
    /// </summary>
    [MaxLength(4000)]
    [Column("reportm", Order = 105)]
    public string ReportM { get; set; }
    /// <summary>
    /// 获取或者设置属性
    /// </summary>
    [MaxLength(4000)]
    [Column("attribute", Order = 106)]
    public string Attribute { get; set; }
    /// <summary>
    /// 获取或者设置模板类别
    /// </summary>
    [MaxLength(1)]
    [Column("mtype", Order = 107)]
    public string MType { get; set; }
    /// <summary>
    /// 获取或者设置私人标志
    /// </summary>
    [MaxLength(1)]
    [Column("pflag", Order = 108)]
    public string pFlag { get; set; }
    /// <summary>
    /// 获取或者设置日期
    /// </summary>
    [Column("dodate", Order = 109)]
    public DateTime? DoDate { get; set; }
    /// <summary>
    /// 获取或者设置操作员工号
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 110)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(3)]
    [Column("orderflag", Order = 111)]
    public string OrderFlag { get; set; }
    /// <summary>
    /// 获取或者设置英文备注
    /// </summary>
    [MaxLength(100)]
    [Column("remarke", Order = 112)]
    public string RemarkE { get; set; }
    /// <summary>
    /// 获取或者设置部位码
    /// </summary>
    [MaxLength(20)]
    [Column("tcode", Order = 113)]
    public string TCode { get; set; }
    /// <summary>
    /// 获取或者设置诊断码
    /// </summary>
    [MaxLength(20)]
    [Column("dcode", Order = 114)]
    public string DCode { get; set; }
    /// <summary>
    /// 获取或者设置科室
    /// </summary>
    [MaxLength(20)]
    [Column("condept", Order = 115)]
    public string ConDept { get; set; }
    /// <summary>
    /// 获取或者设置拼音码
    /// </summary>
    [MaxLength(100)]
    [Column("py", Order = 116)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置模板ID
    /// </summary>
    [Column("modelid", Order = 117)]
    public int? ModelId { get; set; }
    /// <summary>
    /// 获取或者设置员工号
    /// </summary>
    [MaxLength(20)]
    [Column("empid", Order = 118)]
    public string EmpId { get; set; }
    /// <summary>
    /// 获取或者设置次数
    /// </summary>
    [Column("series", Order = 119)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置总费用
    /// </summary>
    [Precision(10, 2)]
    [Column("totalfee", Order = 120)]
    public decimal? TotalFee { get; set; }
    /// <summary>
    /// 获取或者设置住院标志
    /// </summary>
    [MaxLength(2)]
    [Column("inpflag", Order = 121)]
    public string InpFlag { get; set; }
    /// <summary>
    /// 获取或者设置定位
    /// </summary>
    [Column("plh", Order = 122)]
    public int? Plh { get; set; }
    /// <summary>
    /// 获取或者设置默认标志
    /// </summary>
    [MaxLength(1)]
    [Column("defaultflag", Order = 123)]
    public string DefaultFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("picflag", Order = 124)]
    public string PicFlag { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 125)]
    public string UseFlag { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 126)]
    public string HosCode { get; set; }


    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}
