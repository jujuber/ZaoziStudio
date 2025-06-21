namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 药品库存批次信息
/// </summary>
[Table("dihtime")]
[PrimaryKey(nameof(Rdn))]
public sealed class Dihtime : EqualObject
{
    /// <summary>
    /// 获取或者设置计价代码
    /// </summary>
    [Column("drugmanfrdn", Order = 100)]
    public int? Drugmanfrdn { get; set; }
    /// <summary>
    /// 获取或者设置入库单据主键
    /// </summary>
    [Column("druginouthz_rdn", Order = 101)]
    public int? DruginouthzRdn { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 102)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置药品代码
    /// </summary>
    [MaxLength(18)]
    [Required]
    [Column("drcode", Order = 103)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("packunit", Order = 104)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装规格
    /// </summary>
    [Required]
    [Column("pack", Order = 105)]
    public int Pack { get; set; }
    /// <summary>
    /// 获取或者设置产地代码
    /// </summary>
    [Required]
    [Column("drmanfcode", Order = 106)]
    public int Drmanfcode { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 107)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置批号
    /// </summary>
    [MaxLength(30)]
    [Column("dilotn", Order = 108)]
    public string Dilotn { get; set; }
    /// <summary>
    /// 获取或者设置效期
    /// </summary>
    [Column("expierdate", Order = 109)]
    public DateTime? Expierdate { get; set; }
    /// <summary>
    /// 获取或者设置库存数量（最小单位）
    /// </summary>
    [Precision(18, 4)]
    [Column("tmnumb", Order = 110)]
    public decimal? Tmnumb { get; set; }
    /// <summary>
    /// 获取或者设置进价(包装)
    /// </summary>
    [Precision(18, 4)]
    [Column("punits", Order = 111)]
    public decimal? Punits { get; set; }
    /// <summary>
    /// 获取或者设置结算标志
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 112)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置初始数量（最小单位）
    /// </summary>
    [Precision(18, 4)]
    [Column("prenumb", Order = 113)]
    public decimal? Prenumb { get; set; }
    /// <summary>
    /// 获取或者设置最后更新时间
    /// </summary>
    [Column("lastdate", Order = 114)]
    public DateTime? Lastdate { get; set; }
    /// <summary>
    /// 获取或者设置预扣库存
    /// </summary>
    [Precision(18, 4)]
    [Column("tmpnumb", Order = 115)]
    public decimal? Tmpnumb { get; set; }
    /// <summary>
    /// 获取或者设置入库单号
    /// </summary>
    [MaxLength(15)]
    [Column("rkbh", Order = 116)]
    public string Rkbh { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("screenflag", Order = 117)]
    public int? Screenflag { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}