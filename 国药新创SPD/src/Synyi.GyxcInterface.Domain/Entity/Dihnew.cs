namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 药品库存当前账页
/// </summary>
[Table("dihnew")]
[PrimaryKey(nameof(Rdn))]
public sealed class Dihnew : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 100)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置药品代码
    /// </summary>
    [MaxLength(18)]
    [Required]
    [Column("drcode", Order = 101)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(3)]
    [Required]
    [Column("packunit", Order = 102)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装规格
    /// </summary>
    [Required]
    [Column("pack", Order = 103)]
    public int Pack { get; set; }
    /// <summary>
    /// 获取或者设置产地代码
    /// </summary>
    [Required]
    [Column("drmanfcode", Order = 104)]
    public int Drmanfcode { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("deptid", Order = 105)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置库存数量（最小单位计）
    /// </summary>
    [Precision(16, 4)]
    [Column("dnumb", Order = 106)]
    public decimal? Dnumb { get; set; }
    /// <summary>
    /// 获取或者设置库存账页类别
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("fieldcode", Order = 107)]
    public string Fieldcode { get; set; }
    /// <summary>
    /// 获取或者设置开始日期
    /// </summary>
    [Column("startdate", Order = 108)]
    public DateTime? Startdate { get; set; }
    /// <summary>
    /// 获取或者设置结束日期
    /// </summary>
    [Column("enddate", Order = 109)]
    public DateTime? Enddate { get; set; }
    /// <summary>
    /// 获取或者设置账页号
    /// </summary>
    [Column("abc", Order = 110)]
    public int? Abc { get; set; }
    /// <summary>
    /// 获取或者设置计价主键
    /// </summary>
    [Column("drugmanfrdn", Order = 111)]
    public int? Drugmanfrdn { get; set; }
    /// <summary>
    /// 获取或者设置结算标志
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 112)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置账页说明
    /// </summary>
    [MaxLength(1)]
    [Column("title", Order = 113)]
    public string Title { get; set; }
    /// <summary>
    /// 获取或者设置经办
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 114)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(100)]
    [Column("remark", Order = 115)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置药品大类
    /// </summary>
    [MaxLength(2)]
    [Column("drchina", Order = 116)]
    public string Drchina { get; set; }
    /// <summary>
    /// 获取或者设置零售总价
    /// </summary>
    [Precision(19, 4)]
    [Column("tnpl", Order = 117)]
    public decimal? Tnpl { get; set; }
    /// <summary>
    /// 获取或者设置进价总价
    /// </summary>
    [Precision(19, 4)]
    [Column("trealp", Order = 118)]
    public decimal? Trealp { get; set; }
    /// <summary>
    /// 获取或者设置批发价总价
    /// </summary>
    [Precision(19, 4)]
    [Column("tpp", Order = 119)]
    public decimal? Tpp { get; set; }
    /// <summary>
    /// 获取或者设置最小单位
    /// </summary>
    [MaxLength(3)]
    [Column("drunit", Order = 120)]
    public string Drunit { get; set; }
    /// <summary>
    /// 获取或者设置原始数量
    /// </summary>
    [Precision(19, 4)]
    [Column("sub_dnumb", Order = 121)]
    public decimal? SubDnumb { get; set; }
    /// <summary>
    /// 获取或者设置原始零售总价
    /// </summary>
    [Precision(19, 4)]
    [Column("sub_tnpl", Order = 122)]
    public decimal? SubTnpl { get; set; }
    /// <summary>
    /// 获取或者设置原始进价总价
    /// </summary>
    [Precision(19, 4)]
    [Column("sub_trealp", Order = 123)]
    public decimal? SubTrealp { get; set; }
    /// <summary>
    /// 获取或者设置预扣库存数
    /// </summary>
    [Precision(18, 4)]
    [Column("tmpnumb", Order = 124)]
    public decimal? Tmpnumb { get; set; }
    /// <summary>
    /// 获取或者设置是否屏蔽药品 1屏蔽
    /// </summary>
    [Column("screenflag", Order = 125)]
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