namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 病历归档记录表
/// </summary>
[Table("emr_medrcfilelist")]
[PrimaryKey(nameof(Rdn))]
public class EmrMedrcfilelist : EqualObject
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
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(30)]
    [Column("pname", Order = 104)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置入院日期
    /// </summary>
    [Column("admid", Order = 105)]
    public DateTime? Admid { get; set; }
    /// <summary>
    /// 获取或者设置出院日期
    /// </summary>
    [Column("discd", Order = 106)]
    public DateTime? Discd { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 107)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 108)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置住院天数
    /// </summary>
    [Column("days", Order = 109)]
    public int? Days { get; set; }
    /// <summary>
    /// 获取或者设置输入日期
    /// </summary>
    [Column("indate", Order = 110)]
    public DateTime? Indate { get; set; }
    /// <summary>
    /// 获取或者设置经办
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 111)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 112)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置归档请求标志
    /// </summary>
    [MaxLength(1)]
    [Column("requestflag", Order = 113)]
    public string Requestflag { get; set; }
    /// <summary>
    /// 获取或者设置归档请求时间
    /// </summary>
    [Column("requestdate", Order = 114)]
    public DateTime? Requestdate { get; set; }
    /// <summary>
    /// 获取或者设置归档请求人
    /// </summary>
    [MaxLength(20)]
    [Column("requestjp", Order = 115)]
    public string Requestjp { get; set; }
    /// <summary>
    /// 获取或者设置归档审核标志
    /// </summary>
    [MaxLength(1)]
    [Column("checkflag", Order = 116)]
    public string Checkflag { get; set; }
    /// <summary>
    /// 获取或者设置归档审核人
    /// </summary>
    [MaxLength(50)]
    [Column("checkjp", Order = 117)]
    public string Checkjp { get; set; }
    /// <summary>
    /// 获取或者设置归档审核时间
    /// </summary>
    [Column("checkdate", Order = 118)]
    public DateTime? Checkdate { get; set; }
    /// <summary>
    /// 获取或者设置归档审核备注
    /// </summary>
    [MaxLength(100)]
    [Column("checkremark", Order = 119)]
    public string Checkremark { get; set; }
    /// <summary>
    /// 获取或者设置归档标志
    /// </summary>
    [MaxLength(1)]
    [Column("fileflag", Order = 120)]
    public string Fileflag { get; set; }
    /// <summary>
    /// 获取或者设置归档人员
    /// </summary>
    [MaxLength(50)]
    [Column("filejp", Order = 121)]
    public string Filejp { get; set; }
    /// <summary>
    /// 获取或者设置归档日期
    /// </summary>
    [Column("filedate", Order = 122)]
    public DateTime? Filedate { get; set; }
    /// <summary>
    /// 获取或者设置床位号
    /// </summary>
    [MaxLength(20)]
    [Column("bedid", Order = 123)]
    public string Bedid { get; set; }
    /// <summary>
    /// 获取或者设置住院病区
    /// </summary>
    [MaxLength(20)]
    [Column("deptbed", Order = 124)]
    public string Deptbed { get; set; }
    /// <summary>
    /// 获取或者设置死亡标志
    /// </summary>
    [MaxLength(1)]
    [Column("deathflag", Order = 125)]
    public string Deathflag { get; set; }
    /// <summary>
    /// 获取或者设置隐私标志
    /// </summary>
    [MaxLength(50)]
    [Column("privacy", Order = 126)]
    public string Privacy { get; set; }
    /// <summary>
    /// 获取或者设置存档标志
    /// </summary>
    [MaxLength(1)]
    [Column("archiveflag", Order = 127)]
    public string Archiveflag { get; set; }
    /// <summary>
    /// 获取或者设置存档人员
    /// </summary>
    [MaxLength(10)]
    [Column("archivejp", Order = 128)]
    public string Archivejp { get; set; }
    /// <summary>
    /// 获取或者设置存档备注
    /// </summary>
    [MaxLength(100)]
    [Column("archivereason", Order = 129)]
    public string Archivereason { get; set; }
    /// <summary>
    /// 获取或者设置存档日期
    /// </summary>
    [Column("archivedate", Order = 130)]
    public DateTime? Archivedate { get; set; }
    /// <summary>
    /// 获取或者设置备注类型
    /// </summary>
    [MaxLength(1)]
    [Column("notetype", Order = 131)]
    public string Notetype { get; set; }
    /// <summary>
    /// 获取或者设置备注日期
    /// </summary>
    [Column("notedate", Order = 132)]
    public DateTime? Notedate { get; set; }
    /// <summary>
    /// 获取或者设置备注人员
    /// </summary>
    [MaxLength(50)]
    [Column("notejp", Order = 133)]
    public string Notejp { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(100)]
    [Column("notes", Order = 134)]
    public string Notes { get; set; }
    /// <summary>
    /// 获取或者设置纸质文书归档时间
    /// </summary>
    [Column("paperdate", Order = 135)]
    public DateTime? Paperdate { get; set; }
    /// <summary>
    /// 获取或者设置纸质文书归档标记
    /// </summary>
    [MaxLength(1)]
    [Column("paperflag", Order = 136)]
    public string Paperflag { get; set; }
    /// <summary>
    /// 获取或者设置纸张数量
    /// </summary>
    [Column("papernum", Order = 137)]
    public int? Papernum { get; set; }
    /// <summary>
    /// 获取或者设置纸质文书归档人
    /// </summary>
    [MaxLength(50)]
    [Column("paperjp", Order = 138)]
    public string Paperjp { get; set; }
    /// <summary>
    /// 获取或者设置病历数量
    /// </summary>
    [Column("emrcount", Order = 139)]
    public int? Emrcount { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 140)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}