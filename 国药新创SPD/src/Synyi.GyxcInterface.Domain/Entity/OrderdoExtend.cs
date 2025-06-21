namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 医嘱执行计划
/// </summary>
[Table("INP_YZZXMXKZ")]
[PrimaryKey(nameof(Rdn))]
public sealed class OrderdoExtend : EqualObject
{
    /// <summary>
    /// 获取或者设置打印标志
    /// </summary>
    [MaxLength(1)]
    [Column("printflag", Order = 100)]
    public string Printflag { get; set; }
    /// <summary>
    /// 获取或者设置实发数量
    /// </summary>
    [Precision(18, 4)]
    [Column("realsent", Order = 102)]
    public decimal? Realsent { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 104)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 105)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(3)]
    [Column("prtype", Order = 106)]
    public string Prtype { get; set; }
    /// <summary>
    /// 获取或者设置医嘱号
    /// </summary>
    [Column("orderno", Order = 107)]
    public int? Orderno { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 108)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 109)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置执行代码
    /// </summary>
    [MaxLength(20)]
    [Column("docode", Order = 110)]
    public string Docode { get; set; }
    /// <summary>
    /// 获取或者设置执行标志(0：未执行    1：已执行     2：不执行)
    /// </summary>
    [MaxLength(1)]
    [Column("exeflag", Order = 111)]
    public string Exeflag { get; set; }
    /// <summary>
    /// 获取或者设置执行护士
    /// </summary>
    [MaxLength(20)]
    [Column("ns", Order = 112)]
    public string Ns { get; set; }
    /// <summary>
    /// 获取或者设置执行时间
    /// </summary>
    [Column("dodate", Order = 113)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置输入日期
    /// </summary>
    [Column("indate", Order = 114)]
    public DateTime? Indate { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(16, 4)]
    [Column("many", Order = 115)]
    public decimal? Many { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(200)]
    [Column("remark", Order = 116)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置校对护士
    /// </summary>
    [MaxLength(20)]
    [Column("nschecker", Order = 117)]
    public string Nschecker { get; set; }
    /// <summary>
    /// 获取或者设置理由备注
    /// </summary>
    [MaxLength(100)]
    [Column("reasonmark", Order = 118)]
    public string Reasonmark { get; set; }
    /// <summary>
    /// 获取或者设置病区
    /// </summary>
    [MaxLength(10)]
    [Column("deptbed", Order = 119)]
    public string Deptbed { get; set; }
    /// <summary>
    /// 获取或者设置计算机执行标志
    /// </summary>
    [MaxLength(2)]
    [Column("computerflag", Order = 120)]
    public string Computerflag { get; set; }
    /// <summary>
    /// 获取或者设置收费标志
    /// </summary>
    [MaxLength(1)]
    [Column("chargeflag", Order = 121)]
    public string Chargeflag { get; set; }
    /// <summary>
    /// 获取或者设置计划用药时间
    /// </summary>
    [Column("plandate", Order = 122)]
    public DateTime? Plandate { get; set; }
    /// <summary>
    /// 获取或者设置执行条码
    /// </summary>
    [MaxLength(30)]
    [Column("dobarcode", Order = 123)]
    public string Dobarcode { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(10)]
    [Column("unit", Order = 124)]
    public string Unit { get; set; }
    /// <summary>
    /// 获取或者设置主医嘱标志
    /// </summary>
    [MaxLength(1)]
    [Column("mainflag", Order = 125)]
    public string Mainflag { get; set; }
    /// <summary>
    /// 获取或者设置发药标志
    /// </summary>
    [MaxLength(1)]
    [Column("phexeflag", Order = 126)]
    public string Phexeflag { get; set; }
    /// <summary>
    /// 获取或者设置发药人
    /// </summary>
    [MaxLength(50)]
    [Column("ph", Order = 127)]
    public string Ph { get; set; }
    /// <summary>
    /// 获取或者设置发药时间
    /// </summary>
    [Column("phdate", Order = 128)]
    public DateTime? Phdate { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("doflag", Order = 129)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置组号
    /// </summary>
    [Column("setno", Order = 130)]
    public int? Setno { get; set; }
    /// <summary>
    /// 获取或者设置预退量
    /// </summary>
    [Precision(18, 4)]
    [Column("preback", Order = 131)]
    public decimal? Preback { get; set; }
    /// <summary>
    /// 获取或者设置库存批次主键
    /// </summary>
    [Column("dihtimerdn", Order = 132)]
    public int? Dihtimerdn { get; set; }
    /// <summary>
    /// 获取或者设置批号
    /// </summary>
    [MaxLength(200)]
    [Column("dilotn", Order = 133)]
    public string Dilotn { get; set; }
    /// <summary>
    /// 获取或者设置病区代码
    /// </summary>
    [MaxLength(20)]
    [Column("todept", Order = 134)]
    public string Todept { get; set; }
    /// <summary>
    /// 获取或者设置锁定标志
    /// </summary>
    [Column("lockflag", Order = 135)]
    public int? Lockflag { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 136)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置执行院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 137)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置转院日期
    /// </summary>
    [Column("hostrandt", Order = 138)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置转院标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 139)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置设备发送单号
    /// </summary>
    [Column("devicesendno", Order = 140)]
    public long? Devicesendno { get; set; }
    /// <summary>
    /// 获取或者设置设备发送标志
    /// </summary>
    [MaxLength(1)]
    [Column("devicesenndflag", Order = 141)]
    public string Devicesenndflag { get; set; }
    /// <summary>
    /// 获取或者设置发送日期
    /// </summary>
    [Column("senddt", Order = 142)]
    public DateTime? Senddt { get; set; }
    /// <summary>
    /// 获取或者设置贴数
    /// </summary>
    [Column("setnumb", Order = 143)]
    public int? Setnumb { get; set; }
    /// <summary>
    /// 获取或者设置备用药
    /// </summary>
    [MaxLength(20)]
    [Column("deptdo", Order = 144)]
    public string Deptdo { get; set; }
    /// <summary>
    /// 获取或者设置护士校对日期
    /// </summary>
    [Column("nscheckdate", Order = 145)]
    public DateTime? Nscheckdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("devicesendflag", Order = 146)]
    public string Devicesendflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("sjns", Order = 147)]
    public string Sjns { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("ZXprintflag", Order = 148)]
    public int? ZXprintflag { get; set; }
    /// <summary>
    /// 获取或者设置条码
    /// </summary>
    [MaxLength(500)]
    [Column("barcode", Order = 149)]
    public string Barcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("orderdono", Order = 150)]
    public string Orderdono { get; set; }
    /// <summary>
    /// 获取或者设置需要配置
    /// </summary>
    [MaxLength(1)]
    [Column("needconfig", Order = 151)]
    public string Needconfig { get; set; }
    /// <summary>
    /// 获取或者设置原因
    /// </summary>
    [MaxLength(200)]
    [Column("reason", Order = 152)]
    public string Reason { get; set; }
    /// <summary>
    /// 获取或者设置护士申请标记
    /// </summary>
    [MaxLength(1)]
    [Column("allowdispense", Order = 153)]
    public string Allowdispense { get; set; }
    /// <summary>
    /// 获取或者设置护士申请日期
    /// </summary>
    [Column("allowdate", Order = 154)]
    public DateTime? Allowdate { get; set; }
    /// <summary>
    /// 获取或者设置护士申请医生
    /// </summary>
    [MaxLength(20)]
    [Column("allowdr", Order = 155)]
    public string Allowdr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("SSprintflag", Order = 156)]
    public string SSprintflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("prebackdate", Order = 157)]
    public DateTime? Prebackdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("bedid", Order = 158)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置物资发放标志
    /// </summary>
    [Column("hrpexeflag", Order = 159)]
    public int? HrpExeflag { get; set; }
    /// <summary>
    /// 获取或者设置物资发放用户代码
    /// </summary>
    [MaxLength(32)]
    [Column("hrpffyhid", Order = 160)]
    public string HrpFfyhid { get; set; }
    /// <summary>
    /// 获取或者设置物资发放用户
    /// </summary>
    [MaxLength(64)]
    [Column("hrpffyh", Order = 161)]
    public string HrpFfyh { get; set; }
    /// <summary>
    /// 获取或者设置物资发放日期
    /// </summary>
    [Column("hrpffrq", Order = 162)]
    public DateTime? HrpFfrq { get; set; }
    /// <summary>
    /// 获取或者设置物资请领单标志
    /// </summary>
    [Column("hrpqldbz", Order = 163)]
    public int? HrpQldbz { get; set; }
    /// <summary>
    /// 获取或者设置物资请领单标识
    /// </summary>
    [Column("hrpqldid", Order = 164)]
    public long? HrpQldId { get; set; }
    /// <summary>
    /// 获取或者设置关联医嘱号
    /// </summary>
    [Column("glyzrdn", Order = 165)]
    public long? Glyzrdn { get; set; }
    /// <summary>
    /// 获取或者设置执行科室代码
    /// </summary>
    [MaxLength(32)]
    [Column("zxksid", Order = 166)]
    public string ZxksId { get; set; }
    /// <summary>
    /// 获取或者设置执行科室
    /// </summary>
    [MaxLength(64)]
    [Column("zxks", Order = 167)]
    public string Zxks { get; set; }
    /// <summary>
    /// 获取或者设置物资出库单标识
    /// </summary>
    [Column("hrpckdid", Order = 168)]
    public long? HrpCkdId { get; set; }
    /// <summary>
    /// 获取或者设置库房代码
    /// </summary>
    [String32]
    [Column("pharmdept", Order = 169)]
    public string Pharmdept { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}