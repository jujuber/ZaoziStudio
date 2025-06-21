namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 排班主表
/// </summary>
[Table("o_restrict_actual")]
[PrimaryKey(nameof(Id))]
public sealed class ORestrictActual : EqualObject
{
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 100)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置看诊类型
    /// </summary>
    [MaxLength(1)]
    [Column("classid", Order = 101)]
    public string Classid { get; set; }
    /// <summary>
    /// 获取或者设置星期几
    /// </summary>
    [Required]
    [Column("dayofweek", Order = 102)]
    public byte Dayofweek { get; set; }
    /// <summary>
    /// 获取或者设置员工代码
    /// </summary>
    [MaxLength(20)]
    [Column("empid", Order = 103)]
    public string Empid { get; set; }
    /// <summary>
    /// 获取或者设置上午号源数
    /// </summary>
    [Required]
    [Column("total1", Order = 104)]
    public int Total1 { get; set; }
    /// <summary>
    /// 获取或者设置上午可加号源数
    /// </summary>
    [Required]
    [Column("add1", Order = 105)]
    public int Add1 { get; set; }
    /// <summary>
    /// 获取或者设置下午号源数
    /// </summary>
    [Required]
    [Column("total2", Order = 106)]
    public int Total2 { get; set; }
    /// <summary>
    /// 获取或者设置下午可加号源数
    /// </summary>
    [Required]
    [Column("add2", Order = 107)]
    public int Add2 { get; set; }
    /// <summary>
    /// 获取或者设置上午已预约人数
    /// </summary>
    [Required]
    [Column("poppeople", Order = 108)]
    public int Poppeople { get; set; }
    /// <summary>
    /// 获取或者设置上午已加号数
    /// </summary>
    [Required]
    [Column("popnum", Order = 109)]
    public int Popnum { get; set; }
    /// <summary>
    /// 获取或者设置下午已预约人数
    /// </summary>
    [Required]
    [Column("poppeople2", Order = 110)]
    public int Poppeople2 { get; set; }
    /// <summary>
    /// 获取或者设置下午已加号数
    /// </summary>
    [Required]
    [Column("popnum2", Order = 111)]
    public int Popnum2 { get; set; }
    /// <summary>
    /// 获取或者设置上午看诊标记 1看诊 0 停诊
    /// </summary>
    [MaxLength(3)]
    [Column("active1", Order = 112)]
    public string Active1 { get; set; }
    /// <summary>
    /// 获取或者设置下午看诊标记 1看诊 0 停诊
    /// </summary>
    [MaxLength(3)]
    [Column("active2", Order = 113)]
    public string Active2 { get; set; }
    /// <summary>
    /// 获取或者设置限号标志 0 不限 1 限号
    /// </summary>
    [MaxLength(1)]
    [Column("addflag", Order = 114)]
    public string Addflag { get; set; }
    /// <summary>
    /// 获取或者设置挂号费
    /// </summary>
    [Precision(8, 2)]
    [Column("ghfee", Order = 115)]
    public decimal? Ghfee { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(7)]
    [Column("forward", Order = 116)]
    public string Forward { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("app1", Order = 117)]
    public int? App1 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("app2", Order = 118)]
    public int? App2 { get; set; }
    /// <summary>
    /// 获取或者设置日期
    /// </summary>
    [Column("dodate", Order = 119)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("app1xh", Order = 120)]
    public int? App1xh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("app2xh", Order = 121)]
    public int? App2xh { get; set; }
    /// <summary>
    /// 获取或者设置等候区
    /// </summary>
    [MaxLength(100)]
    [Column("nStation", Order = 122)]
    public string NStation { get; set; }
    /// <summary>
    /// 获取或者设置医生类型
    /// </summary>
    [MaxLength(1)]
    [Column("Drflag", Order = 123)]
    public string Drflag { get; set; }
    /// <summary>
    /// 获取或者设置预约类型
    /// </summary>
    [MaxLength(1)]
    [Column("ghtype", Order = 124)]
    public string Ghtype { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("needEMR", Order = 125)]
    public string NeedEMR { get; set; }
    /// <summary>
    /// 获取或者设置排班序号
    /// </summary>
    [Required]
    [Column("orid", Order = 126)]
    public int Orid { get; set; }
    /// <summary>
    /// 获取或者设置排序
    /// </summary>
    [MaxLength(10)]
    [Column("iseries", Order = 127)]
    public string Iseries { get; set; }
    /// <summary>
    /// 获取或者设置自助机号源标志
    /// </summary>
    [MaxLength(1)]
    [Column("mechineFlag", Order = 128)]
    public string MechineFlag { get; set; }
    /// <summary>
    /// 获取或者设置自助机周几号源
    /// </summary>
    [Column("mechineweek", Order = 129)]
    public int? Mechineweek { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("prelimit1", Order = 130)]
    public int? Prelimit1 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("prelimit2", Order = 131)]
    public int? Prelimit2 { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hosicode", Order = 132)]
    public string Hosicode { get; set; }
    /// <summary>
    /// 获取或者设置挂号费收费代码
    /// </summary>
    [MaxLength(30)]
    [Column("regfcode", Order = 133)]
    public string Regfcode { get; set; }
    /// <summary>
    /// 获取或者设置医生停诊标记
    /// </summary>
    [MaxLength(1)]
    [Column("stopDocFlag", Order = 134)]
    public string StopDocFlag { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("id", Order = 135)]
    public int Id { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("pbdate", Order = 136)]
    public DateTime? Pbdate { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 137)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置限制标志1
    /// </summary>
    [MaxLength(1)]
    [Column("limit1flag", Order = 138)]
    public string Limit1flag { get; set; }
    /// <summary>
    /// 获取或者设置限制标志2
    /// </summary>
    [MaxLength(1)]
    [Column("limit2flag", Order = 139)]
    public string Limit2flag { get; set; }
    /// <summary>
    /// 获取或者设置开始时间1
    /// </summary>
    [MaxLength(10)]
    [Column("startime1", Order = 140)]
    public string Startime1 { get; set; }
    /// <summary>
    /// 获取或者设置开始时间2
    /// </summary>
    [MaxLength(10)]
    [Column("startime2", Order = 141)]
    public string Startime2 { get; set; }
    /// <summary>
    /// 获取或者设置结束时间1
    /// </summary>
    [MaxLength(10)]
    [Column("endtime1", Order = 142)]
    public string Endtime1 { get; set; }
    /// <summary>
    /// 获取或者设置结束时间2
    /// </summary>
    [MaxLength(10)]
    [Column("endtime2", Order = 143)]
    public string Endtime2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("platformUploadFlagAM", Order = 144)]
    public string PlatformUploadFlagAM { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("platformUploadFlagPM", Order = 145)]
    public string PlatformUploadFlagPM { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}