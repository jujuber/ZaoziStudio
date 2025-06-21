namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 卡号表
/// </summary>
[Table("card")]
[PrimaryKey(nameof(Cardid))]
public sealed class Card : EqualObject
{
    /// <summary>
    /// 获取或者设置卡号
    /// </summary>
    [MaxLength(50)]
    [Required]
    [Column("cardid", Order = 100)]
    public string Cardid { get; set; }
    /// <summary>
    /// 获取或者设置病历号
    /// </summary>
    [Column("mrn", Order = 101)]
    public int? Mrn { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 102)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置进班
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 103)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置日期
    /// </summary>
    [Column("dodate", Order = 104)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置卡片类型
    /// </summary>
    [MaxLength(20)]
    [Column("cardtype", Order = 105)]
    public string Cardtype { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 106)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置转院日期
    /// </summary>
    [Column("hostrandt", Order = 107)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置转院标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 108)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Cardid;
    }
}