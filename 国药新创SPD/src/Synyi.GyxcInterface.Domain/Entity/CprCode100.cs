namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医嘱类别
/// </summary>
[Table("cpr_code100")]
[PrimaryKey(nameof(Prtype))]
public sealed class CprCode100 : EqualObject
{
    /// <summary>
    /// 获取或者设置类别码(D-药品；Z-中药；BDS-备血；BDT-输血；FOD-膳食；PS-停医嘱；OS-停医嘱;NSC-治疗处置)
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("prtype", Order = 100)]
    public string Prtype { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(40)]
    [Column("remark", Order = 101)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置备注（英）
    /// </summary>
    [MaxLength(60)]
    [Column("remarke", Order = 102)]
    public string Remarke { get; set; }
    /// <summary>
    /// 获取或者设置门诊使用
    /// </summary>
    [MaxLength(1)]
    [Column("opflag", Order = 103)]
    public string Opflag { get; set; }
    /// <summary>
    /// 获取或者设置住院使用(P-药品；O-检查；S-手术；T(prtype == "H30")-会诊)
    /// </summary>
    [MaxLength(1)]
    [Column("ipflag", Order = 104)]
    public string Ipflag { get; set; }
    /// <summary>
    /// 获取或者设置序号
    /// </summary>
    [Column("showseries", Order = 105)]
    public int? Showseries { get; set; }
    /// <summary>
    /// 获取或者设置注意事项
    /// </summary>
    [MaxLength(250)]
    [Column("attention", Order = 106)]
    public string Attention { get; set; }
    /// <summary>
    /// 获取或者设置默认部门
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 107)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置最大量
    /// </summary>
    [Column("nomax", Order = 108)]
    public int? Nomax { get; set; }
    /// <summary>
    /// 获取或者设置申请单格式
    /// </summary>
    [MaxLength(40)]
    [Column("showform", Order = 109)]
    public string Showform { get; set; }
    /// <summary>
    /// 获取或者设置申请标志
    /// </summary>
    [MaxLength(1)]
    [Column("askflag", Order = 110)]
    public string Askflag { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 111)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置显示报表
    /// </summary>
    [MaxLength(2)]
    [Column("showreport", Order = 112)]
    public string Showreport { get; set; }
    /// <summary>
    /// 获取或者设置/
    /// </summary>
    [MaxLength(3)]
    [Column("ct", Order = 113)]
    public string Ct { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类型名称
    /// </summary>
    [MaxLength(40)]
    [Column("orderflagname", Order = 114)]
    public string Orderflagname { get; set; }
    /// <summary>
    /// 获取或者设置显示序号
    /// </summary>
    [Column("ipshowseries", Order = 115)]
    public int? Ipshowseries { get; set; }
    /// <summary>
    /// 获取或者设置电子病类号
    /// </summary>
    [MaxLength(10)]
    [Column("txcode", Order = 116)]
    public string Txcode { get; set; }
    /// <summary>
    /// 获取或者设置文本标志
    /// </summary>
    [MaxLength(1)]
    [Column("textflag", Order = 117)]
    public string Textflag { get; set; }
    /// <summary>
    /// 获取或者设置执行代码
    /// </summary>
    [MaxLength(50)]
    [Column("doccode", Order = 118)]
    public string Doccode { get; set; }
    /// <summary>
    /// 获取或者设置唯一数量
    /// </summary>
    [Column("onlynumb", Order = 119)]
    public int? Onlynumb { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类型名称（英）
    /// </summary>
    [MaxLength(100)]
    [Column("orderflagename", Order = 120)]
    public string Orderflagename { get; set; }
    /// <summary>
    /// 获取或者设置单独打印
    /// </summary>
    [MaxLength(1)]
    [Required]
    [Column("printonly", Order = 121)]
    public string Printonly { get; set; }
    /// <summary>
    /// 获取或者设置给病人
    /// </summary>
    [MaxLength(1)]
    [Column("forpatient", Order = 122)]
    public string Forpatient { get; set; }
    /// <summary>
    /// 获取或者设置收费标志
    /// </summary>
    [MaxLength(1)]
    [Column("ichargeflag", Order = 123)]
    public string Ichargeflag { get; set; }
    /// <summary>
    /// 获取或者设置收费动作
    /// </summary>
    [MaxLength(1)]
    [Column("ichargeaction", Order = 124)]
    public string Ichargeaction { get; set; }
    /// <summary>
    /// 获取或者设置打印标志
    /// </summary>
    [MaxLength(1)]
    [Column("printiflag", Order = 125)]
    public string Printiflag { get; set; }
    /// <summary>
    /// 获取或者设置音频
    /// </summary>
    [MaxLength(20)]
    [Column("py", Order = 126)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置归口
    /// </summary>
    [MaxLength(20)]
    [Column("put", Order = 127)]
    public string Put { get; set; }
    /// <summary>
    /// 获取或者设置打印标志1
    /// </summary>
    [MaxLength(1)]
    [Column("printflagI", Order = 128)]
    public string PrintflagI { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Prtype;
    }
}