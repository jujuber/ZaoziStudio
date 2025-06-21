namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 病人预约信息表
/// </summary>
[Table("o_precontract")]
[PrimaryKey(nameof(Id))]
public sealed class OPrecontract : EqualObject
{
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Required]
    [Column("mrn", Order = 100)]
    public int Mrn { get; set; }
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
    /// 获取或者设置就诊日期
    /// </summary>
    [Required]
    [Column("predate", Order = 103)]
    public DateTime Predate { get; set; }
    /// <summary>
    /// 获取或者设置标志 0 已就诊 1 正常 N 删除
    /// </summary>
    [MaxLength(1)]
    [Column("active", Order = 104)]
    public string Active { get; set; }
    /// <summary>
    /// 获取或者设置特殊预约费
    /// </summary>
    [Column("feenum", Order = 105)]
    public int? Feenum { get; set; }
    /// <summary>
    /// 获取或者设置预约医生
    /// </summary>
    [MaxLength(20)]
    [Column("dr", Order = 106)]
    public string Dr { get; set; }
    /// <summary>
    /// 获取或者设置操作员
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 107)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置录入日期
    /// </summary>
    [Required]
    [Column("regdate", Order = 108)]
    public DateTime Regdate { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("id", Order = 109)]
    public int Id { get; set; }
    /// <summary>
    /// 获取或者设置操作科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptjp", Order = 110)]
    public string Deptjp { get; set; }
    /// <summary>
    /// 获取或者设置加号标志
    /// </summary>
    [MaxLength(1)]
    [Column("addflag", Order = 111)]
    public string Addflag { get; set; }
    /// <summary>
    /// 获取或者设置挂号类别
    /// </summary>
    [MaxLength(2)]
    [Column("rectype", Order = 112)]
    public string Rectype { get; set; }
    /// <summary>
    /// 获取或者设置挂号时间
    /// </summary>
    [Column("recdt", Order = 113)]
    public DateTime? Recdt { get; set; }
    /// <summary>
    /// 获取或者设置挂号操作员
    /// </summary>
    [MaxLength(20)]
    [Column("recjp", Order = 114)]
    public string Recjp { get; set; }
    /// <summary>
    /// 获取或者设置回复标志
    /// </summary>
    [MaxLength(1)]
    [Column("replyflag", Order = 115)]
    public string Replyflag { get; set; }
    /// <summary>
    /// 获取或者设置回复时间
    /// </summary>
    [Column("replydt", Order = 116)]
    public DateTime? Replydt { get; set; }
    /// <summary>
    /// 获取或者设置回复挂号操作员
    /// </summary>
    [MaxLength(10)]
    [Column("replyjp", Order = 117)]
    public string Replyjp { get; set; }
    /// <summary>
    /// 获取或者设置回复内容
    /// </summary>
    [MaxLength(200)]
    [Column("replyremark", Order = 118)]
    public string Replyremark { get; set; }
    /// <summary>
    /// 获取或者设置删除标志
    /// </summary>
    [MaxLength(1)]
    [Column("deleteflag", Order = 119)]
    public string Deleteflag { get; set; }
    /// <summary>
    /// 获取或者设置删除时间
    /// </summary>
    [Column("deletedt", Order = 120)]
    public DateTime? Deletedt { get; set; }
    /// <summary>
    /// 获取或者设置删除挂号操作员
    /// </summary>
    [MaxLength(10)]
    [Column("deletejp", Order = 121)]
    public string Deletejp { get; set; }
    /// <summary>
    /// 获取或者设置删除备注
    /// </summary>
    [MaxLength(200)]
    [Column("deleteremark", Order = 122)]
    public string Deleteremark { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(2)]
    [Column("Doflag", Order = 123)]
    public string Doflag { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(100)]
    [Column("pname", Order = 124)]
    public string Pname { get; set; }
    /// <summary>
    /// 获取或者设置地址
    /// </summary>
    [MaxLength(170)]
    [Column("paddress", Order = 125)]
    public string Paddress { get; set; }
    /// <summary>
    /// 获取或者设置联系方式
    /// </summary>
    [MaxLength(20)]
    [Column("handphone", Order = 126)]
    public string Handphone { get; set; }
    /// <summary>
    /// 获取或者设置证号
    /// </summary>
    [MaxLength(20)]
    [Column("PID", Order = 127)]
    public string PID { get; set; }
    /// <summary>
    /// 获取或者设置就诊序号
    /// </summary>
    [Column("regno", Order = 128)]
    public int? Regno { get; set; }
    /// <summary>
    /// 获取或者设置排班主键
    /// </summary>
    [Column("orid", Order = 129)]
    public int? Orid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("randcode", Order = 130)]
    public string Randcode { get; set; }
    /// <summary>
    /// 获取或者设置就诊病历号
    /// </summary>
    [Column("ghmrn", Order = 131)]
    public int? Ghmrn { get; set; }
    /// <summary>
    /// 获取或者设置就诊病历次数
    /// </summary>
    [Column("ghseries", Order = 132)]
    public int? Ghseries { get; set; }
    /// <summary>
    /// 获取或者设置关联挂号reg_trade.inter_id主键
    /// </summary>
    [Column("kregrdn", Order = 133)]
    public int? Kregrdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("smsflag", Order = 134)]
    public string Smsflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("smsdt", Order = 135)]
    public DateTime? Smsdt { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("smslog", Order = 136)]
    public string Smslog { get; set; }
    /// <summary>
    /// 获取或者设置校验护士
    /// </summary>
    [MaxLength(1)]
    [Column("nurse_check", Order = 137)]
    public string NurseCheck { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("dtsmsflag", Order = 138)]
    public string Dtsmsflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("dtsmsdt", Order = 139)]
    public DateTime? Dtsmsdt { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hosicode", Order = 140)]
    public string Hosicode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("regid", Order = 141)]
    public string Regid { get; set; }
    /// <summary>
    /// 获取或者设置执行院区
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 142)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("sourceid", Order = 143)]
    public int? Sourceid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("outyylsh", Order = 144)]
    public string Outyylsh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Column("referralnum", Order = 145)]
    public string Referralnum { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}