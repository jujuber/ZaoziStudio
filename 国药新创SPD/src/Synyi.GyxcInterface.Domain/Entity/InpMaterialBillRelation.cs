namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 住院物资单据关联关系
/// </summary>
[Table("HRP_WZ_ZYDJGLGX")]
[PrimaryKey(nameof(Id))]
public class InpMaterialBillRelation : EqualObject
{
    /// <summary>
    /// 获取或者设置标识
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID", Order = 1)]
    public long Id { get; set; }

    /// <summary>
    /// 获取或者设置RDN
    /// </summary>
    [Column("RDN", Order = 2)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置扩展标志 1-orderdo  2-INP_YZZXMXKZ
    /// </summary>
    [Column("KZBZ", Order = 3)]
    public int Kzbz { get; set; }
    /// <summary>
    /// 获取或者设置出库单标识
    /// </summary>
    [Column("CKDID", Order = 4)]
    public long CkdId { get; set; }

    /// <summary>
    /// 获取比较对象
    /// </summary>
    /// <returns>返回比较对象</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}
