namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 
/// </summary>
[Table("ReportResult_LIS")]
public sealed class ReportResultLIS : EqualObject
{
    /// <summary>
    /// 获取或者设置申请单号
    /// </summary>
    [MaxLength(200)]
    [Column("sqdh", Order = 100)]
    public string Sqdh { get; set; }
    /// <summary>
    /// 获取或者设置报告单号
    /// </summary>
    [MaxLength(50)]
    [Column("bgdh", Order = 101)]
    public string Bgdh { get; set; }
    /// <summary>
    /// 获取或者设置检验流水号
    /// </summary>
    [MaxLength(20)]
    [Column("ywzj", Order = 102)]
    public string Ywzj { get; set; }
    /// <summary>
    /// 获取或者设置标本编号
    /// </summary>
    [MaxLength(20)]
    [Column("bbbh", Order = 103)]
    public string Bbbh { get; set; }
    /// <summary>
    /// 获取或者设置条码号
    /// </summary>
    [MaxLength(20)]
    [Column("tmh", Order = 104)]
    public string Tmh { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(20)]
    [Column("xm", Order = 105)]
    public string Xm { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [MaxLength(20)]
    [Column("hisid", Order = 106)]
    public string Hisid { get; set; }
    /// <summary>
    /// 获取或者设置就诊流水号
    /// </summary>
    [MaxLength(20)]
    [Column("jzlsh", Order = 107)]
    public string Jzlsh { get; set; }
    /// <summary>
    /// 获取或者设置患者出生日期
    /// </summary>
    [Column("hzcsrq", Order = 108)]
    public DateTime? Hzcsrq { get; set; }
    /// <summary>
    /// 获取或者设置患者年龄
    /// </summary>
    [MaxLength(20)]
    [Column("nl", Order = 109)]
    public string Nl { get; set; }
    /// <summary>
    /// 获取或者设置年龄单位 Y岁M月D天
    /// </summary>
    [MaxLength(20)]
    [Column("nldw", Order = 110)]
    public string Nldw { get; set; }
    /// <summary>
    /// 获取或者设置就诊类型代码1门诊2急诊3住院9其他
    /// </summary>
    [MaxLength(20)]
    [Column("hzlx", Order = 111)]
    public string Hzlx { get; set; }
    /// <summary>
    /// 获取或者设置检验方法
    /// </summary>
    [MaxLength(200)]
    [Column("jyff", Order = 112)]
    public string Jyff { get; set; }
    /// <summary>
    /// 获取或者设置检验类别
    /// </summary>
    [MaxLength(200)]
    [Column("jylb", Order = 113)]
    public string Jylb { get; set; }
    /// <summary>
    /// 获取或者设置常规检验结果ID
    /// </summary>
    [MaxLength(20)]
    [Column("cgjgxxid", Order = 114)]
    public string Cgjgxxid { get; set; }
    /// <summary>
    /// 获取或者设置微生物检验结果ID
    /// </summary>
    [MaxLength(20)]
    [Column("wswjgxxid", Order = 115)]
    public string Wswjgxxid { get; set; }
    /// <summary>
    /// 获取或者设置细菌检验结果ID
    /// </summary>
    [MaxLength(20)]
    [Column("xjjgxxid", Order = 116)]
    public string Xjjgxxid { get; set; }
    /// <summary>
    /// 获取或者设置药敏检验结果ID
    /// </summary>
    [MaxLength(20)]
    [Column("ymjgxxid", Order = 117)]
    public string Ymjgxxid { get; set; }
    /// <summary>
    /// 获取或者设置检验技师
    /// </summary>
    [MaxLength(20)]
    [Column("jyjsxm", Order = 118)]
    public string Jyjsxm { get; set; }
    /// <summary>
    /// 获取或者设置检验技师工号
    /// </summary>
    [MaxLength(20)]
    [Column("jyjsgh", Order = 119)]
    public string Jyjsgh { get; set; }
    /// <summary>
    /// 获取或者设置检验医师
    /// </summary>
    [MaxLength(20)]
    [Column("jyysxm", Order = 120)]
    public string Jyysxm { get; set; }
    /// <summary>
    /// 获取或者设置检验医师工号
    /// </summary>
    [MaxLength(20)]
    [Column("jyysgh", Order = 121)]
    public string Jyysgh { get; set; }
    /// <summary>
    /// 获取或者设置检验日期
    /// </summary>
    [Column("jyrq", Order = 122)]
    public DateTime? Jyrq { get; set; }
    /// <summary>
    /// 获取或者设置检验机构
    /// </summary>
    [MaxLength(200)]
    [Column("jyjg", Order = 123)]
    public string Jyjg { get; set; }
    /// <summary>
    /// 获取或者设置检验报告科室
    /// </summary>
    [MaxLength(20)]
    [Column("bgksmc", Order = 124)]
    public string Bgksmc { get; set; }
    /// <summary>
    /// 获取或者设置报告科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("bgksdm", Order = 125)]
    public string Bgksdm { get; set; }
    /// <summary>
    /// 获取或者设置检验报告备注
    /// </summary>
    [MaxLength(200)]
    [Column("bgbz", Order = 126)]
    public string Bgbz { get; set; }
    /// <summary>
    /// 获取或者设置检验审核日期
    /// </summary>
    [Column("shsj", Order = 127)]
    public DateTime? Shsj { get; set; }
    /// <summary>
    /// 获取或者设置审核医师姓名
    /// </summary>
    [MaxLength(20)]
    [Column("shysxm", Order = 128)]
    public string Shysxm { get; set; }
    /// <summary>
    /// 获取或者设置审核医师工号
    /// </summary>
    [MaxLength(255)]
    [Column("shysgh", Order = 129)]
    public string Shysgh { get; set; }
    /// <summary>
    /// 获取或者设置检验报告日期
    /// </summary>
    [Column("bgrq", Order = 130)]
    public DateTime? Bgrq { get; set; }
    /// <summary>
    /// 获取或者设置报告医师姓名
    /// </summary>
    [MaxLength(20)]
    [Column("bgysxm", Order = 131)]
    public string Bgysxm { get; set; }
    /// <summary>
    /// 获取或者设置报告医师工号
    /// </summary>
    [MaxLength(20)]
    [Column("bgysgh", Order = 132)]
    public string Bgysgh { get; set; }
    /// <summary>
    /// 获取或者设置医院代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 133)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置使用标记
    /// </summary>
    [MaxLength(2)]
    [Column("useflag", Order = 134)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置打印标签时间
    /// </summary>
    [Column("dybqsj", Order = 135)]
    public DateTime? Dybqsj { get; set; }
    /// <summary>
    /// 获取或者设置打印标签ID
    /// </summary>
    [MaxLength(20)]
    [Column("dybqempid ", Order = 136)]
    public string Dybqempid { get; set; }
    /// <summary>
    /// 获取或者设置打印标签姓名
    /// </summary>
    [MaxLength(20)]
    [Column("dybqempname", Order = 137)]
    public string Dybqempname { get; set; }
    /// <summary>
    /// 获取或者设置标本采集时间
    /// </summary>
    [Column("bbcysj", Order = 138)]
    public DateTime? Bbcysj { get; set; }
    /// <summary>
    /// 获取或者设置标本采集工号
    /// </summary>
    [MaxLength(20)]
    [Column("bbcyempid", Order = 139)]
    public string Bbcyempid { get; set; }
    /// <summary>
    /// 获取或者设置标本采集姓名
    /// </summary>
    [MaxLength(20)]
    [Column("bbcyempname", Order = 140)]
    public string Bbcyempname { get; set; }
    /// <summary>
    /// 获取或者设置样本签收时间
    /// </summary>
    [Column("bbqssj", Order = 141)]
    public DateTime? Bbqssj { get; set; }
    /// <summary>
    /// 获取或者设置样本签收工号
    /// </summary>
    [MaxLength(20)]
    [Column("bbqsempid", Order = 142)]
    public string Bbqsempid { get; set; }
    /// <summary>
    /// 获取或者设置样本签收姓名
    /// </summary>
    [MaxLength(50)]
    [Column("bbqsempname", Order = 143)]
    public string Bbqsempname { get; set; }
    /// <summary>
    /// 获取或者设置样本接收时间
    /// </summary>
    [Column("ybjssj", Order = 144)]
    public DateTime? Ybjssj { get; set; }
    /// <summary>
    /// 获取或者设置样本接收工号
    /// </summary>
    [MaxLength(50)]
    [Column("ybjsempid", Order = 145)]
    public string Ybjsempid { get; set; }
    /// <summary>
    /// 获取或者设置样本接收姓名
    /// </summary>
    [MaxLength(20)]
    [Column("ybjsempname", Order = 146)]
    public string Ybjsempname { get; set; }
    /// <summary>
    /// 获取或者设置开单医生工号
    /// </summary>
    [MaxLength(20)]
    [Column("Kdysgh", Order = 147)]
    public string Kdysgh { get; set; }
    /// <summary>
    /// 获取或者设置开单医生姓名
    /// </summary>
    [MaxLength(50)]
    [Column("Kdysxm", Order = 148)]
    public string Kdysxm { get; set; }
    /// <summary>
    /// 获取或者设置开单时间
    /// </summary>
    [Column("Kdsj", Order = 149)]
    public DateTime? Kdsj { get; set; }
    /// <summary>
    /// 获取或者设置检验项目名称
    /// </summary>
    [MaxLength(200)]
    [Column("Jyxmmc", Order = 150)]
    public string Jyxmmc { get; set; }
    /// <summary>
    /// 获取或者设置检验项目代码
    /// </summary>
    [MaxLength(200)]
    [Column("Jyxmdm", Order = 151)]
    public string Jyxmdm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("ID", Order = 152)]
    public int ID { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("Sfzh", Order = 153)]
    public string Sfzh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("Bblx", Order = 154)]
    public string Bblx { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("Bbh", Order = 155)]
    public string Bbh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("Bbzt", Order = 156)]
    public string Bbzt { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("Cjbw", Order = 157)]
    public string Cjbw { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(512)]
    [Column("bgdz", Order = 158)]
    public string Bgdz { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(32)]
    [Column("kdksdm", Order = 159)]
    public string Kdksdm { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("kdksmc", Order = 160)]
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