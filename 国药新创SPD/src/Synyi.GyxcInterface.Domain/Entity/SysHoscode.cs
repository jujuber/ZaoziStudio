namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 院区表
/// </summary>
[Table("sys_hoscode")]
[PrimaryKey(nameof(Id))]
public class SysHoscode : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("id", Order = 100)]
    public int Id { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Required]
    [Column("hoscode", Order = 101)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置院区名称
    /// </summary>
    [MaxLength(50)]
    [Column("hosname", Order = 102)]
    public string Hosname { get; set; }
    /// <summary>
    /// 获取或者设置是否使用
    /// </summary>
    [MaxLength(1)]
    [Column("isuse", Order = 103)]
    public string Isuse { get; set; }
    /// <summary>
    /// 获取或者设置默认地址
    /// </summary>
    [MaxLength(10)]
    [Column("DefaultAddress", Order = 104)]
    public string DefaultAddress { get; set; }
    /// <summary>
    /// 获取或者设置上级院区
    /// </summary>
    [MaxLength(20)]
    [Column("levelhoscode", Order = 105)]
    public string Levelhoscode { get; set; }
    /// <summary>
    /// 获取或者设置组织机构代码
    /// </summary>
    [MaxLength(50)]
    [Column("Institution", Order = 106)]
    public string Institution { get; set; }
    /// <summary>
    /// 获取或者设置全称
    /// </summary>
    [MaxLength(100)]
    [Column("fullname", Order = 107)]
    public string Fullname { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("JYhoscode", Order = 108)]
    public string JYhoscode { get; set; }
    /// <summary>
    /// 获取或者设置医院电话
    /// </summary>
    [MaxLength(20)]
    [Column("hoscodetelephone", Order = 109)]
    public string Hoscodetelephone { get; set; }
    /// <summary>
    /// 获取或者设置牵头医院
    /// </summary>
    [MaxLength(20)]
    [Column("labelType", Order = 110)]
    public string LabelType { get; set; }
    /// <summary>
    /// 获取或者设置废
    /// </summary>
    [MaxLength(1000)]
    [Column("searchcode", Order = 111)]
    public string Searchcode { get; set; }
    /// <summary>
    /// 获取或者设置合理用药医院机构编码
    /// </summary>
    [MaxLength(20)]
    [Column("hlyy_hoscode", Order = 112)]
    public string HlyyHoscode { get; set; }
    /// <summary>
    /// 获取或者设置转诊医院类型
    /// </summary>
    [MaxLength(2)]
    [Column("ReferralHosGrade", Order = 113)]
    public string ReferralHosGrade { get; set; }
    /// <summary>
    /// 获取或者设置等级
    /// </summary>
    [MaxLength(2)]
    [Column("hosgrade", Order = 114)]
    public string Hosgrade { get; set; }
    /// <summary>
    /// 获取或者设置级别
    /// </summary>
    [MaxLength(2)]
    [Column("hoslevel", Order = 115)]
    public string Hoslevel { get; set; }
    /// <summary>
    /// 获取或者设置免费用药院区代码
    /// </summary>
    [MaxLength(30)]
    [Column("freehoscode", Order = 116)]
    public string Freehoscode { get; set; }
    /// <summary>
    /// 获取或者设置省预约平台院区代码
    /// </summary>
    [MaxLength(30)]
    [Column("syyhoscode", Order = 117)]
    public string Syyhoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("checkplathoscode", Order = 118)]
    public string Checkplathoscode { get; set; }
    /// <summary>
    /// 获取或者设置医疗机构代码（杏林）
    /// </summary>
    [MaxLength(30)]
    [Column("lishoscode", Order = 119)]
    public string Lishoscode { get; set; }
    /// <summary>
    /// 获取或者设置院区代码（杏林）
    /// </summary>
    [MaxLength(30)]
    [Column("lisareacode", Order = 120)]
    public string Lisareacode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("pacshoscode", Order = 121)]
    public string Pacshoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("DzfpHoscode", Order = 122)]
    public string DzfpHoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("ShorterHosName", Order = 123)]
    public string ShorterHosName { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}