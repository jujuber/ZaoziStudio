namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 排班明细表
/// </summary>
[Table("o_restrict_time_actual")]
[PrimaryKey(nameof(Id))]
public sealed class ORestrictTimeActual : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 100)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 101)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置看诊类型
    /// </summary>
    [MaxLength(1)]
    [Column("classid", Order = 102)]
    public string Classid { get; set; }
    /// <summary>
    /// 获取或者设置星期几
    /// </summary>
    [Column("dayofweek", Order = 103)]
    public byte? Dayofweek { get; set; }
    /// <summary>
    /// 获取或者设置员工代码
    /// </summary>
    [MaxLength(20)]
    [Column("empid", Order = 104)]
    public string Empid { get; set; }
    /// <summary>
    /// 获取或者设置开始日期
    /// </summary>
    [MaxLength(10)]
    [Column("startime", Order = 105)]
    public string Startime { get; set; }
    /// <summary>
    /// 获取或者设置号源
    /// </summary>
    [Column("regno", Order = 106)]
    public int? Regno { get; set; }
    /// <summary>
    /// 获取或者设置用途 GH01现场挂号 GH02 窗口预约 GH03 网上预约
    /// </summary>
    [MaxLength(20)]
    [Column("isweb", Order = 107)]
    public string Isweb { get; set; }
    /// <summary>
    /// 获取或者设置排班序号
    /// </summary>
    [Column("orid", Order = 108)]
    public int? Orid { get; set; }
    /// <summary>
    /// 获取或者设置结束时间
    /// </summary>
    [MaxLength(10)]
    [Column("endtime", Order = 109)]
    public string Endtime { get; set; }
    /// <summary>
    /// 获取或者设置上下午标记
    /// </summary>
    [MaxLength(5)]
    [Column("ampm", Order = 110)]
    public string Ampm { get; set; }
    /// <summary>
    /// 获取或者设置ID
    /// </summary>
    [Required]
    [Column("id", Order = 111)]
    public int Id { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("pbid", Order = 112)]
    public int? Pbid { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 113)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊次数
    /// </summary>
    [Column("series", Order = 114)]
    public int? Series { get; set; }
    /// <summary>
    /// 获取或者设置结算渠道
    /// </summary>
    [Column("jsway", Order = 115)]
    public int? Jsway { get; set; }
    /// <summary>
    /// 获取或者设置挂号标记
    /// </summary>
    [Column("regflag", Order = 116)]
    public int? Regflag { get; set; }
    /// <summary>
    /// 获取或者设置业务流水号
    /// </summary>
    [Column("preid", Order = 117)]
    public int? Preid { get; set; }
    /// <summary>
    /// 获取或者设置机内号
    /// </summary>
    [Column("interid", Order = 118)]
    public long? Interid { get; set; }
    /// <summary>
    /// 获取或者设置号源类型
    /// </summary>
    [MaxLength(10)]
    [Column("sourcetype", Order = 119)]
    public string Sourcetype { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 120)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("pbdate", Order = 121)]
    public DateTime? Pbdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("platformUploadFlag", Order = 122)]
    public string PlatformUploadFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("platformPreFlag", Order = 123)]
    public string PlatformPreFlag { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}