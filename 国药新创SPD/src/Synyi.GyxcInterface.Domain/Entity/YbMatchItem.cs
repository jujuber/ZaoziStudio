namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 财务核算类别
/// </summary>
[Table("YB_Match_Item")]
[PrimaryKey(nameof(Id))]
public sealed class YbMatchItem
{
    /// <summary>
    /// 获取或者设置标识
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID", Order = 1)]
    public int Id { get; set; }
    /// <summary>
    /// 获取或者设置id
    /// </summary>
    [Column("accessID", Order = 2)]
    public int? AccessId { get; set; }
    /// <summary>
    /// 获取或者设置his代码
    /// </summary>
    [MaxLength(50)]
    [Column("hiscode", Order = 3)]
    public string HisCode { get; set; }
    /// <summary>
    /// 获取或者设置his名称
    /// </summary>
    [MaxLength(200)]
    [Column("hisname", Order = 4)]
    public string HisName { get; set; }
    /// <summary>
    /// 获取或者设置医保代码
    /// </summary>
    [MaxLength(50)]
    [Column("ybcode", Order = 5)]
    public string YbCode { get; set; }
    /// <summary>
    /// 获取或者设置医保名称
    /// </summary>
    [MaxLength(200)]
    [Column("ybname", Order = 6)]
    public string YbName { get; set; }
    /// <summary>
    /// 获取或者设置药品治疗类别
    /// </summary>
    [MaxLength(50)]
    [Column("ypzllb", Order = 7)]
    public string YpZllb { get; set; }
    /// <summary>
    /// 获取或者设置门诊自付比例
    /// </summary>
    [Precision(14, 2)]
    [Column("mzzfbl", Order = 8)]
    public decimal? MzZfbl { get; set; }
    /// <summary>
    /// 获取或者设置住院自付比例
    /// </summary>
    [Precision(14, 2)]
    [Column("zyzfbl", Order = 9)]
    public decimal? ZyZfbl { get; set; }
    /// <summary>
    /// 获取或者设置收费等级
    /// </summary>
    [MaxLength(1)]
    [Column("sfdj", Order = 10)]
    public string Sfdj { get; set; }
    /// <summary>
    /// 获取或者设置审核状态
    /// </summary>
    [MaxLength(1)]
    [Column("shzt", Order = 11)]
    public string Shzt { get; set; }
    /// <summary>
    /// 获取或者设置开始时间
    /// </summary>
    [Column("startedate", Order = 12)]
    public DateTime? StarteDate { get; set; }
    /// <summary>
    /// 获取或者设置结束时间
    /// </summary>
    [Column("enddate", Order = 13)]
    public DateTime? EndDate { get; set; }
    /// <summary>
    /// 获取或者设置匹配时间
    /// </summary>
    [Column("matchdate", Order = 14)]
    public DateTime? MatchDate { get; set; }
    /// <summary>
    /// 获取或者设置员工标识
    /// </summary>
    [MaxLength(50)]
    [Column("empid", Order = 15)]
    public string EmpId { get; set; }
    /// <summary>
    /// 获取或者设置收费类别
    /// </summary>
    [MaxLength(3)]
    [Column("sflb", Order = 16)]
    public string Sflb { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 17)]
    public string UseFlag { get; set; }
    /// <summary>
    /// 获取或者设置his类别
    /// </summary>
    [MaxLength(50)]
    [Column("histype", Order = 18)]
    public string HisType { get; set; }
    /// <summary>
    /// 获取或者设置是否上传
    /// </summary>
    [Column("istrans", Order = 19)]
    public int? IsTrans { get; set; }
    /// <summary>
    /// 获取或者设置原因
    /// </summary>
    [MaxLength(500)]
    [Column("reason", Order = 20)]
    public string Reason { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1000)]
    [Column("CountryCode", Order = 21)]
    public string CountryCode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("CountryMatchDate", Order = 22)]
    public DateTime? CountryMatchDate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(15)]
    [Column("CountryMatchEmpid", Order = 23)]
    public string CountryMatchEmpid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("qzzf", Order = 24)]
    public string Qzzf { get; set; }
    // <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(32)]
    [Column("clcode", Order = 25)]
    public string ClCode { get; set; }
    // <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(32)]
    [Column("clCountryCode", Order = 26)]
    public string ClCountryCode { get; set; }
}