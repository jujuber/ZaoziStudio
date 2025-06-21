namespace Synyi.GyxcInterface.Domain.Entity;

/// <summary>
/// 产地
/// </summary>
[Table("code217")]
[PrimaryKey(nameof(Manfcode))]
public sealed class Code217 : EqualObject
{
    /// <summary>
    /// 获取或者设置产地代码
    /// </summary>
    [Required]
    [Column("manfcode", Order = 100)]
    public int Manfcode { get; set; }
    /// <summary>
    /// 获取或者设置产地
    /// </summary>
    [MaxLength(100)]
    [Column("manf", Order = 101)]
    public string Manf { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 102)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置gmp标志
    /// </summary>
    [MaxLength(1)]
    [Column("gmp", Order = 103)]
    public string Gmp { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(30)]
    [Column("py", Order = 104)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置简称
    /// </summary>
    [MaxLength(10)]
    [Column("simple", Order = 105)]
    public string Simple { get; set; }
    /// <summary>
    /// 获取或者设置进口标志
    /// </summary>
    [MaxLength(1)]
    [Column("importflag", Order = 106)]
    public string Importflag { get; set; }
    /// <summary>
    /// 获取或者设置上级代码
    /// </summary>
    [Column("lastcode", Order = 107)]
    public int? Lastcode { get; set; }
    /// <summary>
    /// 获取或者设置地区
    /// </summary>
    [MaxLength(2)]
    [Column("area", Order = 108)]
    public string Area { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(200)]
    [Column("mark", Order = 109)]
    public string Mark { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 110)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("AssetcodeFlag", Order = 111)]
    public string AssetcodeFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("DrugFlag", Order = 112)]
    public string DrugFlag { get; set; }
    /// <summary>
    /// 获取或者设置第三方代码
    /// </summary>
    [MaxLength(32)]
    [Column("thirdid", Order = 113)]
    public string ThirdId { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Manfcode;
    }
}