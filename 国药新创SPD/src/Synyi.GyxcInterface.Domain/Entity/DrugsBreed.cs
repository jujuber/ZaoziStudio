
namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 药品品种
/// </summary>
[Table("drugsbreed")]
[PrimaryKey(nameof(Id))]
public sealed class DrugsBreed : EqualObject
{
    /// <summary>
    /// 代码
    /// </summary>
    [String32]
    [Column("ID", Order = 1)]
    public string Id { get; set; }
    /// <summary>
    /// 名称
    /// </summary>
    [String64]
    [Column("NAME", Order = 2)]
    public string Name { get; set; }
    /// <summary>
    /// 拼音
    /// </summary>
    [String64]
    [Column("PY", Order = 3)]
    public string Py { get; set; }
    /// <summary>
    /// 五笔 
    /// </summary>
    [String64]
    [Column("WB", Order = 4)]
    public string Wb { get; set; }
    /// <summary>
    /// 备注
    /// </summary>
    [String512]
    [Column("MEMO", Order = 5)]
    public string Memo { get; set; }
    /// <summary>
    /// 停用标志
    /// </summary>
    [String512]
    [Column("TYBZ", Order = 6)]
    public bool Tybz { get; set; }
    /// <summary>
    /// 获取或者设置第三方系统代码
    /// </summary>
    [String32]
    [Column(Order = 7)]
    public string ThirdId { get; set; }

    /// <summary>
    /// 获取或者设置分类代码
    /// </summary>
    [String32]
    [Column(Order = 8)]
    public string FlId { get; set; }

    /// <summary>
    /// 获取或者设置账目类别代码
    /// </summary>
    [String32]
    [Column(Order = 9)]
    public string ZmlbId { get; set; }
    /// <summary>
    /// 获取或者设置药品类型
    /// </summary>
    [Column(Order = 10)]
    public int Yplx { get; set; }
    /// <summary>
    /// 获取或者设置特殊药品类型
    /// </summary>
    [String32]
    [Column(Order = 11)]
    public string Tslx { get; set; }
    /// <summary>
    /// 获取或者设置别名
    /// </summary>
    [String64]
    [Column(Order = 12)]
    public string Bm { get; set; }
    /// <summary>
    /// 获取或者设置英文名
    /// </summary>
    [String64]
    [Column(Order = 13)]
    public string Ywm { get; set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return this.Id;
    }
}
