namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 药品操作单据主表
/// </summary>
[Table("druginouthz")]
[PrimaryKey(nameof(Rdn))]
public sealed class Druginouthz : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 100)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置操作类型
    /// </summary>
    [MaxLength(2)]
    [Column("dtype", Order = 101)]
    public string Dtype { get; set; }
    /// <summary>
    /// 获取或者设置入库编号
    /// </summary>
    [MaxLength(15)]
    [Column("rkbh", Order = 102)]
    public string Rkbh { get; set; }
    /// <summary>
    /// 获取或者设置公司
    /// </summary>
    [MaxLength(18)]
    [Column("dicompcode", Order = 103)]
    public string Dicompcode { get; set; }
    /// <summary>
    /// 获取或者设置操作日期
    /// </summary>
    [Column("dodate", Order = 104)]
    public DateTime? Dodate { get; set; }
    /// <summary>
    /// 获取或者设置实际日期
    /// </summary>
    [Column("realdate", Order = 105)]
    public DateTime? Realdate { get; set; }
    /// <summary>
    /// 获取或者设置审核日期
    /// </summary>
    [Column("auditdate", Order = 106)]
    public DateTime? Auditdate { get; set; }
    /// <summary>
    /// 获取或者设置操作人
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 107)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置去向部门经办人
    /// </summary>
    [MaxLength(20)]
    [Column("tojp", Order = 108)]
    public string Tojp { get; set; }
    /// <summary>
    /// 获取或者设置来源部门
    /// </summary>
    [MaxLength(20)]
    [Column("fromdept", Order = 109)]
    public string Fromdept { get; set; }
    /// <summary>
    /// 获取或者设置去向部门
    /// </summary>
    [MaxLength(20)]
    [Column("todept", Order = 110)]
    public string Todept { get; set; }
    /// <summary>
    /// 获取或者设置操作科室
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 111)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Column("number", Order = 112)]
    public int? Number { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(200)]
    [Column("remark", Order = 113)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置0入1出
    /// </summary>
    [MaxLength(1)]
    [Column("outflag", Order = 114)]
    public string Outflag { get; set; }
    /// <summary>
    /// 获取或者设置单据状态 （0未确认 1 已确认）
    /// </summary>
    [MaxLength(1)]
    [Column("js", Order = 115)]
    public string Js { get; set; }
    /// <summary>
    /// 获取或者设置单据归类（1：入库；2：出库；3：盘点；4：报损）
    /// </summary>
    [MaxLength(1)]
    [Column("zlys", Order = 116)]
    public string Zlys { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("zlysjp", Order = 117)]
    public string Zlysjp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("zlysdate", Order = 118)]
    public DateTime? Zlysdate { get; set; }
    /// <summary>
    /// 获取或者设置零售总价
    /// </summary>
    [Precision(19, 4)]
    [Column("tnpl", Order = 119)]
    public decimal? Tnpl { get; set; }
    /// <summary>
    /// 获取或者设置进价总价
    /// </summary>
    [Precision(19, 4)]
    [Column("tpunits", Order = 120)]
    public decimal? Tpunits { get; set; }
    /// <summary>
    /// 获取或者设置实际操作人
    /// </summary>
    [MaxLength(20)]
    [Column("realjp", Order = 121)]
    public string Realjp { get; set; }
    /// <summary>
    /// 获取或者设置删除日期
    /// </summary>
    [Column("deletedate", Order = 122)]
    public DateTime? Deletedate { get; set; }
    /// <summary>
    /// 获取或者设置删除人员
    /// </summary>
    [MaxLength(20)]
    [Column("deletejp", Order = 123)]
    public string Deletejp { get; set; }
    /// <summary>
    /// 获取或者设置审核标志
    /// </summary>
    [MaxLength(1)]
    [Column("auditflag", Order = 124)]
    public string Auditflag { get; set; }
    /// <summary>
    /// 获取或者设置院区
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 125)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置操作院区
    /// </summary>
    [MaxLength(20)]
    [Column("dohoscode", Order = 126)]
    public string Dohoscode { get; set; }
    /// <summary>
    /// 获取或者设置操作部门
    /// </summary>
    [MaxLength(20)]
    [Column("dodept", Order = 127)]
    public string Dodept { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("sqrdn", Order = 128)]
    public int? Sqrdn { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}