namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 
/// </summary>
[Table("sys_basesub")]
[PrimaryKey(nameof(Id))]
public sealed class SysBasesub : EqualObject
{
    /// <summary>
    /// 获取或者设置免费药匹配编码
    /// </summary>
    [MaxLength(50)]
    [Column("freeCodeBasesub", Order = 100)]
    public string FreeCodeBasesub { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id", Order = 101)]
    public int Id { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Required]
    [Column("tablename", Order = 102)]
    public string Tablename { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Required]
    [Column("itemcode", Order = 103)]
    public string Itemcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(200)]
    [Required]
    [Column("itemname", Order = 104)]
    public string Itemname { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Required]
    [Column("hoscode", Order = 105)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Required]
    [Column("useflag", Order = 106)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("createdate", Order = 107)]
    public DateTime? Createdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("createuser", Order = 108)]
    public string Createuser { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("defaultdept", Order = 109)]
    public string Defaultdept { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("npl", Order = 110)]
    public decimal? Npl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("childnpl", Order = 111)]
    public decimal? Childnpl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(18, 4)]
    [Column("punits", Order = 112)]
    public decimal? Punits { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("drugpackrdn", Order = 113)]
    public int? Drugpackrdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("zxksdeptlist", Order = 114)]
    public string Zxksdeptlist { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}