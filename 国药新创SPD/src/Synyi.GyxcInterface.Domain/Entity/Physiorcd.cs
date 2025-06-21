namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 电子病历词保存
/// </summary>
[Table("physiorcd")]
[PrimaryKey(nameof(Rdn))]
public class Physiorcd : EqualObject
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
    /// 获取或者设置值类型
    /// </summary>
    [MaxLength(1)]
    [Column("valuetype", Order = 104)]
    public string Valuetype { get; set; }
    /// <summary>
    /// 获取或者设置体征分类
    /// </summary>
    [Column("phcode", Order = 105)]
    public int? Phcode { get; set; }
    /// <summary>
    /// 获取或者设置项目
    /// </summary>
    [MaxLength(8)]
    [Column("phvalue", Order = 106)]
    public string Phvalue { get; set; }
    /// <summary>
    /// 获取或者设置参数
    /// </summary>
    [MaxLength(60)]
    [Column("phrcd", Order = 107)]
    public string Phrcd { get; set; }
    /// <summary>
    /// 获取或者设置输入时间
    /// </summary>
    [Column("dotime", Order = 108)]
    public DateTime? Dotime { get; set; }
    /// <summary>
    /// 获取或者设置病历时间
    /// </summary>
    [Column("rcdtime", Order = 109)]
    public DateTime? Rcdtime { get; set; }
    /// <summary>
    /// 获取或者设置护士
    /// </summary>
    [MaxLength(10)]
    [Column("nurse", Order = 110)]
    public string Nurse { get; set; }
    /// <summary>
    /// 获取或者设置床位号
    /// </summary>
    [MaxLength(20)]
    [Column("bedid", Order = 111)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置程度
    /// </summary>
    [MaxLength(8)]
    [Column("degree", Order = 112)]
    public string Degree { get; set; }
    /// <summary>
    /// 获取或者设置频度
    /// </summary>
    [MaxLength(8)]
    [Column("frequency", Order = 113)]
    public string Frequency { get; set; }
    /// <summary>
    /// 获取或者设置效期
    /// </summary>
    [MaxLength(8)]
    [Column("duration", Order = 114)]
    public string Duration { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Column("phnumb", Order = 115)]
    public int? Phnumb { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(8)]
    [Column("phunit", Order = 116)]
    public string Phunit { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(8)]
    [Column("prtype", Order = 117)]
    public string Prtype { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 118)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置主记录rdn：cpr_prlog.rdn
    /// </summary>
    [Required]
    [Column("relardn", Order = 119)]
    public int Relardn { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [Column("remark", Order = 120)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 121)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置修改人
    /// </summary>
    [MaxLength(10)]
    [Column("modifydr", Order = 122)]
    public string Modifydr { get; set; }
    /// <summary>
    /// 获取或者设置组号
    /// </summary>
    [Column("setno", Order = 123)]
    public int? Setno { get; set; }
    /// <summary>
    /// 获取或者设置输入字段
    /// </summary>
    [MaxLength(60)]
    [Column("inputfield", Order = 124)]
    public string Inputfield { get; set; }
    /// <summary>
    /// 获取或者设置重复字段
    /// </summary>
    [Column("markrdn", Order = 125)]
    public int? Markrdn { get; set; }
    /// <summary>
    /// 获取或者设置组号备注
    /// </summary>
    [MaxLength(60)]
    [Column("setnomark", Order = 126)]
    public string Setnomark { get; set; }
    /// <summary>
    /// 获取或者设置模板对应rdn
    /// </summary>
    [Column("modeldrugrdn", Order = 127)]
    public int? Modeldrugrdn { get; set; }
    /// <summary>
    /// 获取或者设置医嘱子分类
    /// </summary>
    [MaxLength(18)]
    [Column("subprtype", Order = 128)]
    public string Subprtype { get; set; }
    /// <summary>
    /// 获取或者设置标记
    /// </summary>
    [MaxLength(1)]
    [Column("markflag", Order = 129)]
    public string Markflag { get; set; }
    /// <summary>
    /// 获取或者设置原因
    /// </summary>
    [MaxLength(8)]
    [Column("reason", Order = 130)]
    public string Reason { get; set; }
    /// <summary>
    /// 获取或者设置必选项1
    /// </summary>
    [MaxLength(1)]
    [Column("selectflag", Order = 131)]
    public string Selectflag { get; set; }
    /// <summary>
    /// 获取或者设置必选项
    /// </summary>
    [MaxLength(3)]
    [Column("needflag", Order = 132)]
    public string Needflag { get; set; }
    /// <summary>
    /// 获取或者设置显示方式（简0，详细1）
    /// </summary>
    [Required]
    [Column("displaytype", Order = 133)]
    public int Displaytype { get; set; }
    /// <summary>
    /// 获取或者设置文本保存（1,0,2增加项目）
    /// </summary>
    [MaxLength(1)]
    [Column("inhand", Order = 134)]
    public string Inhand { get; set; }
    /// <summary>
    /// 获取或者设置重复标志
    /// </summary>
    [MaxLength(1)]
    [Column("repeatflag", Order = 135)]
    public string Repeatflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(256)]
    [Column("cacode", Order = 136)]
    public string Cacode { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}