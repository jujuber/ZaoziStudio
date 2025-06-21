namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医嘱记录主表
/// </summary>
[Table("cpr_prlog")]
[PrimaryKey(nameof(Stay), nameof(Prtype), nameof(Rdn))]
public sealed class CprPrlog : EqualObject
{
    /// <summary>
    /// 获取或者设置医嘱撤销原因
    /// </summary>
    [MaxLength(150)]
    [Column("revertreason", Order = 100)]
    public string Revertreason { get; set; }
    /// <summary>
    /// 获取或者设置来源唯一编码
    /// </summary>
    [MaxLength(32)]
    [Column("sourcekey", Order = 101)]
    public string Sourcekey { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Required]
    [Column("stay", Order = 102)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类别
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("prtype", Order = 103)]
    public string Prtype { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 104)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 105)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 106)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置医生工号
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 107)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置执行日期
    /// </summary>
    [Column("dodate", Order = 108)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 109)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置医嘱类型
    /// </summary>
    [MaxLength(3)]
    [Column("ordertype", Order = 110)]
    public string Ordertype { get; set; }
    /// <summary>
    /// 获取或者设置有效标志(0无效；1开立；2停止（已校对）；4停止（未校对）；3:已执行)
    /// </summary>
    [MaxLength(1)]
    [Column("doflag", Order = 111)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置输入日期
    /// </summary>
    [Column("indate", Order = 112)]
    public DateTime? Indate { get; set; }
    /// <summary>
    /// 获取或者设置下次执行日期
    /// </summary>
    [Column("nextdate", Order = 113)]
    public DateTime? Nextdate { get; set; }
    /// <summary>
    /// 获取或者设置执行标志
    /// </summary>
    [MaxLength(1)]
    [Column("exeflag", Order = 114)]
    public string Exeflag { get; set; }
    /// <summary>
    /// 获取或者设置护士校对标志
    /// </summary>
    [MaxLength(1)]
    [Column("nscheckflag", Order = 115)]
    public string Nscheckflag { get; set; }
    /// <summary>
    /// 获取或者设置校对护士
    /// </summary>
    [MaxLength(20)]
    [Column("nschecker", Order = 116)]
    public string Nschecker { get; set; }
    /// <summary>
    /// 获取或者设置在院标志
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 117)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置护士校对时间
    /// </summary>
    [Column("nscheckdate", Order = 118)]
    public DateTime? Nscheckdate { get; set; }
    /// <summary>
    /// 获取或者设置护士执行时间
    /// </summary>
    [Column("nsdodate", Order = 119)]
    public DateTime? Nsdodate { get; set; }
    /// <summary>
    /// 获取或者设置护士执行标志
    /// </summary>
    [MaxLength(1)]
    [Column("nsexeflag", Order = 120)]
    public string Nsexeflag { get; set; }
    /// <summary>
    /// 获取或者设置护理有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("nsdoflag", Order = 121)]
    public string Nsdoflag { get; set; }
    /// <summary>
    /// 获取或者设置执行代码
    /// </summary>
    [MaxLength(18)]
    [Column("docode", Order = 122)]
    public string Docode { get; set; }
    /// <summary>
    /// 获取或者设置主医嘱标志
    /// </summary>
    [MaxLength(3)]
    [Column("mainflag", Order = 123)]
    public string Mainflag { get; set; }
    /// <summary>
    /// 获取或者设置相关号
    /// </summary>
    [Column("relano", Order = 124)]
    public int? Relano { get; set; }
    /// <summary>
    /// 获取或者设置打印标志
    /// </summary>
    [MaxLength(1)]
    [Column("printflag", Order = 125)]
    public string Printflag { get; set; }
    /// <summary>
    /// 获取或者设置审批人
    /// </summary>
    [MaxLength(5)]
    [Column("approveby", Order = 126)]
    public string Approveby { get; set; }
    /// <summary>
    /// 获取或者设置停止日期
    /// </summary>
    [Column("datestop", Order = 127)]
    public DateTime? Datestop { get; set; }
    /// <summary>
    /// 获取或者设置医生下次日期
    /// </summary>
    [Column("drdatenext", Order = 128)]
    public DateTime? Drdatenext { get; set; }
    /// <summary>
    /// 获取或者设置有效期
    /// </summary>
    [Column("duration", Order = 129)]
    public int? Duration { get; set; }
    /// <summary>
    /// 获取或者设置开始日期
    /// </summary>
    [Column("datestart", Order = 130)]
    public DateTime? Datestart { get; set; }
    /// <summary>
    /// 获取或者设置护嘱停止人
    /// </summary>
    [MaxLength(20)]
    [Column("nsstop", Order = 131)]
    public string Nsstop { get; set; }
    /// <summary>
    /// 获取或者设置页号
    /// </summary>
    [Column("pageno", Order = 132)]
    public int? Pageno { get; set; }
    /// <summary>
    /// 获取或者设置收费时间
    /// </summary>
    [MaxLength(3)]
    [Column("sfsj", Order = 133)]
    public string Sfsj { get; set; }
    /// <summary>
    /// 获取或者设置绑定代码1
    /// </summary>
    [MaxLength(20)]
    [Column("cpcode1", Order = 134)]
    public string Cpcode1 { get; set; }
    /// <summary>
    /// 获取或者设置绑定代码2
    /// </summary>
    [MaxLength(20)]
    [Column("cpcode2", Order = 135)]
    public string Cpcode2 { get; set; }
    /// <summary>
    /// 获取或者设置绑定代码3
    /// </summary>
    [MaxLength(20)]
    [Column("cpcode3", Order = 136)]
    public string Cpcode3 { get; set; }
    /// <summary>
    /// 获取或者设置模板id
    /// </summary>
    [Column("modelid", Order = 137)]
    public int? Modelid { get; set; }
    /// <summary>
    /// 获取或者设置更新医生
    /// </summary>
    [MaxLength(20)]
    [Column("updatedr", Order = 138)]
    public string Updatedr { get; set; }
    /// <summary>
    /// 获取或者设置更新日期
    /// </summary>
    [Column("updatedate", Order = 139)]
    public DateTime? Updatedate { get; set; }
    /// <summary>
    /// 获取或者设置一天的频度
    /// </summary>
    [MaxLength(20)]
    [Column("dstring", Order = 140)]
    public string Dstring { get; set; }
    /// <summary>
    /// 获取或者设置一周的频度
    /// </summary>
    [MaxLength(20)]
    [Column("tstring", Order = 141)]
    public string Tstring { get; set; }
    /// <summary>
    /// 获取或者设置停止医嘱标准  （用于判断医嘱变动）
    /// </summary>
    [MaxLength(10)]
    [Column("printdoflag", Order = 142)]
    public string Printdoflag { get; set; }
    /// <summary>
    /// 获取或者设置是否已经完成打印   1 完成打印  0  未打印
    /// </summary>
    [MaxLength(10)]
    [Column("isprint", Order = 143)]
    public string Isprint { get; set; }
    /// <summary>
    /// 获取或者设置是否打印           1 打印     0 不打印（用于在打印时控制当前数据是否打印）
    /// </summary>
    [MaxLength(50)]
    [Column("printstart", Order = 144)]
    public string Printstart { get; set; }
    /// <summary>
    /// 获取或者设置是否停止打印
    /// </summary>
    [MaxLength(10)]
    [Column("isstopprint", Order = 145)]
    public string Isstopprint { get; set; }
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
    [MaxLength(20)]
    [Column("stopRdn", Order = 148)]
    public string StopRdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("printstopflag", Order = 149)]
    public string Printstopflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("zllx", Order = 150)]
    public string Zllx { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cisxh", Order = 151)]
    public long? Cisxh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cismxxh", Order = 152)]
    public long? Cismxxh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cisxhlb", Order = 153)]
    public int? Cisxhlb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("cislybz", Order = 154)]
    public int? Cislybz { get; set; }
    /// <summary>
    /// 获取或者设置执行病区代码
    /// </summary>
    [MaxLength(32)]
    [Column("zxbqid", Order = 155)]
    public string Zxbqid { get; set; }
    /// <summary>
    /// 获取或者设置执行病区
    /// </summary>
    [MaxLength(64)]
    [Column("zxbq", Order = 156)]
    public string Zxbq { get; set; }
    /// <summary>
    /// 获取或者设置开单医生代码
    /// </summary>
    [MaxLength(32)]
    [Column("kdysid", Order = 157)]
    public string Kdysid { get; set; }
    /// <summary>
    /// 获取或者设置开单医生
    /// </summary>
    [MaxLength(64)]
    [Column("kdys", Order = 158)]
    public string Kdys { get; set; }
    /// <summary>
    /// 获取或者设置执行状态
    /// </summary>
    [Column("zxzt", Order = 159)]
    public int? Zxzt { get; set; }
    /// <summary>
    /// 获取或者设置开单科室代码
    /// </summary>
    [MaxLength(32)]
    [Column("kdksid", Order = 160)]
    public string Kdksid { get; set; }
    /// <summary>
    /// 获取或者设置开单科室
    /// </summary>
    [MaxLength(64)]
    [Column("kdks", Order = 161)]
    public string Kdks { get; set; }
    /// <summary>
    /// 获取或者设置第二核对护士代码
    /// </summary>
    [MaxLength(32)]
    [Column("hdhs2id", Order = 160)]
    public string Hdhs2Id { get; set; }
    /// <summary>
    /// 获取或者设置第二核对护士
    /// </summary>
    [MaxLength(64)]
    [Column("hdhs2", Order = 161)]
    public string Hdhs2 { get; set; }
    /// <summary>
    /// 获取或者设置核对病区代码
    /// </summary>
    [MaxLength(32)]
    [Column("hdbqid", Order = 162)]
    public string Hdbqid { get; set; }
    /// <summary>
    /// 获取或者设置核对病区
    /// </summary>
    [MaxLength(64)]
    [Column("hdbq", Order = 163)]
    public string Hdbq { get; set; }
    /// <summary>
    /// 获取或者设置单据分类代码
    /// </summary>
    [Column("djflid", Order = 164)]
    public long? DjflId { get; set; }
    /// <summary>
    /// 获取或者设置单据分类
    /// </summary>
    [MaxLength(64)]
    [Column("djfl", Order = 165)]
    public string Djfl { get; set; }
    /// <summary>
    /// 获取或者设置执行人
    /// </summary>
    [MaxLength(64)]
    [Column("zxr", Order = 166)]
    public string Zxr { get; set; }
    /// <summary>
    /// 获取或者设置执行人
    /// </summary>
    [MaxLength(64)]
    [Column("zxrid", Order = 167)]
    public string Zxrid { get; set; }
    /// <summary>
    /// 获取或者设置执行日期
    /// </summary>
    [MaxLength(64)]
    [Column("Zxrq", Order = 168)]
    public DateTime? Zxrq { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Stay;
        yield return Prtype;
        yield return Rdn;
    }

}