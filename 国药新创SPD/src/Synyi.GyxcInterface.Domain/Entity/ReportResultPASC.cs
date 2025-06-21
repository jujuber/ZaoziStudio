namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 
/// </summary>
[Table("ReportResult_PASC")]
public sealed class ReportResultPASC : EqualObject
{
    /// <summary>
    /// 获取或者设置医院代码
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("hoscode", Order = 100)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置申请单号
    /// </summary>
    [MaxLength(20)]
    [Column("sqdh", Order = 101)]
    public string Sqdh { get; set; }
    /// <summary>
    /// 获取或者设置报告单号
    /// </summary>
    [MaxLength(50)]
    [Column("bgdh", Order = 102)]
    public string Bgdh { get; set; }
    /// <summary>
    /// 获取或者设置标本编号
    /// </summary>
    [MaxLength(20)]
    [Column("bbbh", Order = 103)]
    public string Bbbh { get; set; }
    /// <summary>
    /// 获取或者设置条码
    /// </summary>
    [MaxLength(20)]
    [Column("tmh", Order = 104)]
    public string Tmh { get; set; }
    /// <summary>
    /// 获取或者设置病案号
    /// </summary>
    [MaxLength(20)]
    [Column("hisid", Order = 105)]
    public string Hisid { get; set; }
    /// <summary>
    /// 获取或者设置就诊流水号
    /// </summary>
    [MaxLength(20)]
    [Column("jzlsh", Order = 106)]
    public string Jzlsh { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(20)]
    [Column("xm", Order = 107)]
    public string Xm { get; set; }
    /// <summary>
    /// 获取或者设置出生日期
    /// </summary>
    [Column("csrq", Order = 108)]
    public DateTime? Csrq { get; set; }
    /// <summary>
    /// 获取或者设置患者年龄
    /// </summary>
    [MaxLength(20)]
    [Column("nl", Order = 109)]
    public string Nl { get; set; }
    /// <summary>
    /// 获取或者设置年龄单位
    /// </summary>
    [MaxLength(5)]
    [Column("nldw", Order = 110)]
    public string Nldw { get; set; }
    /// <summary>
    /// 获取或者设置就诊类型代码
    /// </summary>
    [MaxLength(5)]
    [Column("hzlx", Order = 111)]
    public string Hzlx { get; set; }
    /// <summary>
    /// 获取或者设置检查方法
    /// </summary>
    [MaxLength(20)]
    [Column("jcff", Order = 112)]
    public string Jcff { get; set; }
    /// <summary>
    /// 获取或者设置检查类别
    /// </summary>
    [MaxLength(20)]
    [Column("jclb", Order = 113)]
    public string Jclb { get; set; }
    /// <summary>
    /// 获取或者设置病理检查结果
    /// </summary>
    [MaxLength(2000)]
    [Column("bljcjg", Order = 114)]
    public string Bljcjg { get; set; }
    /// <summary>
    /// 获取或者设置检查技师姓名
    /// </summary>
    [MaxLength(20)]
    [Column("jcjsxm", Order = 115)]
    public string Jcjsxm { get; set; }
    /// <summary>
    /// 获取或者设置检查技师工号
    /// </summary>
    [MaxLength(50)]
    [Column("jcjsgh", Order = 116)]
    public string Jcjsgh { get; set; }
    /// <summary>
    /// 获取或者设置检查医师姓名
    /// </summary>
    [MaxLength(20)]
    [Column("jcysxm", Order = 117)]
    public string Jcysxm { get; set; }
    /// <summary>
    /// 获取或者设置检查医师工号
    /// </summary>
    [MaxLength(50)]
    [Column("jcysgh", Order = 118)]
    public string Jcysgh { get; set; }
    /// <summary>
    /// 获取或者设置检查日期
    /// </summary>
    [Column("jcrq", Order = 119)]
    public DateTime? Jcrq { get; set; }
    /// <summary>
    /// 获取或者设置检查报告机构
    /// </summary>
    [MaxLength(50)]
    [Column("bgjg", Order = 120)]
    public string Bgjg { get; set; }
    /// <summary>
    /// 获取或者设置检查报告科室
    /// </summary>
    [MaxLength(50)]
    [Column("bgksmc", Order = 121)]
    public string Bgksmc { get; set; }
    /// <summary>
    /// 获取或者设置报告科室代码
    /// </summary>
    [MaxLength(50)]
    [Column("bgksdm", Order = 122)]
    public string Bgksdm { get; set; }
    /// <summary>
    /// 获取或者设置检查结果--客观所见
    /// </summary>
    [MaxLength(2000)]
    [Column("kgsj", Order = 123)]
    public string Kgsj { get; set; }
    /// <summary>
    /// 获取或者设置检查结果—主观所见
    /// </summary>
    [MaxLength(2000)]
    [Column("jcjg", Order = 124)]
    public string Jcjg { get; set; }
    /// <summary>
    /// 获取或者设置检查结果代码  30 - 报告， 40 - 审核， 50 - 复审， 60 - 终审， 70 - 打印
    /// </summary>
    [MaxLength(50)]
    [Column("jcjgdm", Order = 125)]
    public string Jcjgdm { get; set; }
    /// <summary>
    /// 获取或者设置检查报告备注
    /// </summary>
    [MaxLength(255)]
    [Column("bgbz", Order = 126)]
    public string Bgbz { get; set; }
    /// <summary>
    /// 获取或者设置检查报告日期
    /// </summary>
    [Column("bgsj", Order = 127)]
    public DateTime? Bgsj { get; set; }
    /// <summary>
    /// 获取或者设置报告医师姓名
    /// </summary>
    [MaxLength(20)]
    [Column("bgysxm", Order = 128)]
    public string Bgysxm { get; set; }
    /// <summary>
    /// 获取或者设置报告医师工号
    /// </summary>
    [MaxLength(20)]
    [Column("bgysgh", Order = 129)]
    public string Bgysgh { get; set; }
    /// <summary>
    /// 获取或者设置审核医师姓名
    /// </summary>
    [MaxLength(20)]
    [Column("shysxm", Order = 130)]
    public string Shysxm { get; set; }
    /// <summary>
    /// 获取或者设置审核医师工号
    /// </summary>
    [MaxLength(20)]
    [Column("shysgh", Order = 131)]
    public string Shysgh { get; set; }
    /// <summary>
    /// 获取或者设置报告地址
    /// </summary>
    [MaxLength(200)]
    [Column("bgdz", Order = 132)]
    public string Bgdz { get; set; }
    /// <summary>
    /// 获取或者设置有效标记
    /// </summary>
    [MaxLength(2)]
    [Column("useflag", Order = 133)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置开单医生工号
    /// </summary>
    [MaxLength(20)]
    [Column("Kdysgh", Order = 134)]
    public string Kdysgh { get; set; }
    /// <summary>
    /// 获取或者设置开单医生姓名
    /// </summary>
    [MaxLength(20)]
    [Column("Kdysxm", Order = 135)]
    public string Kdysxm { get; set; }
    /// <summary>
    /// 获取或者设置开单时间
    /// </summary>
    [Column("Kdsj", Order = 136)]
    public DateTime? Kdsj { get; set; }
    /// <summary>
    /// 获取或者设置检查项目
    /// </summary>
    [MaxLength(255)]
    [Column("Jcxm", Order = 137)]
    public string Jcxm { get; set; }
    /// <summary>
    /// 获取或者设置检查项目代码
    /// </summary>
    [MaxLength(255)]
    [Column("Jcxmdm", Order = 138)]
    public string Jcxmdm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("ID", Order = 139)]
    public int ID { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("Sfzh", Order = 140)]
    public string Sfzh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("jcbw", Order = 141)]
    public string Jcbw { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("positive", Order = 142)]
    public string Positive { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(32)]
    [Column("kdksdm", Order = 143)]
    public string Kdksdm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("kdksmc", Order = 144)]
    public string Kdksmc { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield break;
    }
}