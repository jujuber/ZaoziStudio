namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 系统参数表
/// </summary>
[Table("hissys")]
[PrimaryKey(nameof(Rdn), nameof(Hoscode))]
public class Hissys : EqualObject
{
    /// <summary>
    /// 获取或者设置输入框分类
    /// </summary>
    [MaxLength(5)]
    [Column("inputtype", Order = 100)]
    public string Inputtype { get; set; }
    /// <summary>
    /// 获取或者设置参数类别(1 文本，2开关 3 下拉框单选， 4 下拉框多选)
    /// </summary>
    [MaxLength(2)]
    [Column("parametertype", Order = 101)]
    public string Parametertype { get; set; }
    /// <summary>
    /// 获取或者设置上线必须
    /// </summary>
    [MaxLength(1)]
    [Column("onlineneed", Order = 102)]
    public string Onlineneed { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rdn", Order = 103)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置整形参数
    /// </summary>
    [Column("sysp1", Order = 104)]
    public int? Sysp1 { get; set; }
    /// <summary>
    /// 获取或者设置字符参数
    /// </summary>
    [MaxLength(1000)]
    [Column("sysp2", Order = 105)]
    public string Sysp2 { get; set; }
    /// <summary>
    /// 获取或者设置日期参数
    /// </summary>
    [Column("sysp3", Order = 106)]
    public DateTime? Sysp3 { get; set; }
    /// <summary>
    /// 获取或者设置浮点参数
    /// </summary>
    [Column("sysp4", Order = 107)]
    public double Sysp4 { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(200)]
    [Column("remark", Order = 108)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置机构代码
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("hoscode", Order = 109)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("usesystem", Order = 110)]
    public string Usesystem { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("effectiveall", Order = 111)]
    public string Effectiveall { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("usemenu", Order = 112)]
    public string Usemenu { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("explain", Order = 113)]
    public string Explain { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("dropitem", Order = 114)]
    public string Dropitem { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
        yield return Hoscode;
    }
}