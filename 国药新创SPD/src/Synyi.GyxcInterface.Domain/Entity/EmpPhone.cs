namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 员工联系方式
/// </summary>
[Table("emp_phone")]
[PrimaryKey(nameof(Empid))]
public sealed class EmpPhone : EqualObject
{
    /// <summary>
    /// 获取或者设置员工代码
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("empid", Order = 100)]
    public string Empid { get; set; }
    /// <summary>
    /// 获取或者设置姓名
    /// </summary>
    [MaxLength(20)]
    [Column("name", Order = 101)]
    public string Name { get; set; }
    /// <summary>
    /// 获取或者设置座机
    /// </summary>
    [MaxLength(20)]
    [Column("netphone", Order = 102)]
    public string Netphone { get; set; }
    /// <summary>
    /// 获取或者设置移动电话
    /// </summary>
    [MaxLength(20)]
    [Column("cellphone", Order = 103)]
    public string Cellphone { get; set; }
    /// <summary>
    /// 获取或者设置家庭号码
    /// </summary>
    [MaxLength(20)]
    [Column("homephone", Order = 104)]
    public string Homephone { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 105)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置科室名称
    /// </summary>
    [MaxLength(50)]
    [Column("deptname", Order = 106)]
    public string Deptname { get; set; }
    /// <summary>
    /// 获取或者设置状态
    /// </summary>
    [MaxLength(5)]
    [Column("status", Order = 107)]
    public string Status { get; set; }
    /// <summary>
    /// 获取或者设置修改日期
    /// </summary>
    [Column("modifydt", Order = 108)]
    public DateTime? Modifydt { get; set; }
    /// <summary>
    /// 获取或者设置审核日期
    /// </summary>
    [Column("checkdt", Order = 109)]
    public DateTime? Checkdt { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 110)]
    public string Useflag { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Empid;
    }
}