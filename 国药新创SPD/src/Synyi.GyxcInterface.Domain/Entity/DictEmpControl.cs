namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 人员对应科室
/// </summary>
[Table("Dict_EmpControl")]
[PrimaryKey(nameof(Rdn))]
public sealed class DictEmpControl : EqualObject
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
    [MaxLength(20)]
    [Column("deptid", Order = 102)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("isuse", Order = 103)]
    public string Isuse { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("createdate", Order = 104)]
    public DateTime Createdate { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("createuser", Order = 105)]
    public string Createuser { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(16)]
    [Column("emppermission", Order = 106)]
    public string Emppermission { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rdn;
    }
}