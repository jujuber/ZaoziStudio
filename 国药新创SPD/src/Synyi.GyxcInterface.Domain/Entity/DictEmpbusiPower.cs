namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医师角色表
/// </summary>
[Table("Dict_empbusiPower")]
[PrimaryKey(nameof(Rdn))]
public class DictEmpbusiPower : EqualObject
{
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("rdn", Order = 100)]
    public int Rdn { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("empid", Order = 101)]
    public string Empid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(7)]
    [Required]
    [Column("busino", Order = 102)]
    public string Busino { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("ctcode", Order = 103)]
    public string Ctcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isuse", Order = 104)]
    public string Isuse { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("createDate", Order = 105)]
    public DateTime CreateDate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("createuser", Order = 106)]
    public string Createuser { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}