namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 费用类别
/// </summary>
[Table("code201")]
[PrimaryKey(nameof(Code))]
public sealed class Code201 : EqualObject
{
    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [MaxLength(2)]
    [Required]
    [Column("code", Order = 100)]
    public string Code { get; set; }
    /// <summary>
    /// 获取或者设置费用类别
    /// </summary>
    [MaxLength(20)]
    [Column("remark", Order = 101)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置归类住院
    /// </summary>
    [MaxLength(2)]
    [Column("clinicorder", Order = 102)]
    public string Clinicorder { get; set; }
    /// <summary>
    /// 获取或者设置收费
    /// </summary>
    [MaxLength(1)]
    [Column("charge", Order = 103)]
    public string Charge { get; set; }
    /// <summary>
    /// 获取或者设置门诊报表
    /// </summary>
    [MaxLength(2)]
    [Column("cliniccode", Order = 104)]
    public string Cliniccode { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 105)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置核算类别代码
    /// </summary>
    [MaxLength(2)]
    [Column("accountcode", Order = 106)]
    public string Accountcode { get; set; }
    /// <summary>
    /// 获取或者设置医保归类（门诊）
    /// </summary>
    [MaxLength(3)]
    [Column("ybcode", Order = 107)]
    public string Ybcode { get; set; }
    /// <summary>
    /// 获取或者设置消息必须
    /// </summary>
    [MaxLength(1)]
    [Column("needmessage", Order = 108)]
    public string Needmessage { get; set; }
    /// <summary>
    /// 获取或者设置门诊（类型名称）
    /// </summary>
    [MaxLength(20)]
    [Column("opname", Order = 109)]
    public string Opname { get; set; }
    /// <summary>
    /// 获取或者设置归类门诊
    /// </summary>
    [MaxLength(2)]
    [Column("clinicordermz", Order = 110)]
    public string Clinicordermz { get; set; }
    /// <summary>
    /// 获取或者设置医保归类（住院）
    /// </summary>
    [MaxLength(3)]
    [Column("ybcodei", Order = 111)]
    public string Ybcodei { get; set; }
    /// <summary>
    /// 获取或者设置核算类别代码新
    /// </summary>
    [MaxLength(10)]
    [Column("accountcodenew", Order = 112)]
    public string Accountcodenew { get; set; }
    /// <summary>
    /// 获取或者设置排序
    /// </summary>
    [Column("sort", Order = 113)]
    public int? Sort { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("DZFPCode", Order = 114)]
    public string DZFPCode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("DZFPCodeMZ", Order = 115)]
    public string DZFPCodeMZ { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }
}