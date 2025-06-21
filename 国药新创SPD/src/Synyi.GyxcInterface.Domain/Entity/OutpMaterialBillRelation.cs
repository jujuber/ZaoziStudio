namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 门诊物资单据关联关系
/// </summary>
[Table("HRP_WZ_MZDJGLGX")]
[PrimaryKey(nameof(Id))]
public class OutpMaterialBillRelation : EqualObject
{
    /// <summary>
    /// 获取或者设置标识
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ID", Order = 1)]
    public long Id { get; set; }

    /// <summary>
    /// 获取或者设置就诊类别
    /// </summary>
    [String32]
    [Column("STAY", Order = 2)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置RDN
    /// </summary>
    [Column("RDN", Order = 3)]
    public int Rdn { get; set; }
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
