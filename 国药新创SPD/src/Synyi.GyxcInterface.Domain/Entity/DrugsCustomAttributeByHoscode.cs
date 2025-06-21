using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 药品属性
/// </summary>
[Table("drugs_CustomAttributeByHoscode")]
[PrimaryKey(nameof(ID))]
public class DrugsCustomAttributeByHoscode : EqualObject
{

    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [Required]
    [Column("ID", Order = 100)]
    public int ID { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("DLCG", Order = 101)]
    public string Dlcg { get; set; }

    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 102)]
    public string Hoscode { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("fieldcode", Order = 103)]
    public string Fieldcode { get; set; }

    /// <summary>
    /// 获取或者设置门诊限用
    /// </summary>
    [MaxLength(20)]
    [Column("MZXY", Order = 104)]
    public string Mzxy { get; set; }
    /// <summary>
    /// 获取或者设置住院限用
    /// </summary>
    [MaxLength(20)]
    [Column("ZYXY", Order = 105)]
    public string Zyxy { get; set; }
    /// <summary>
    /// 获取或者设置国谈品种
    /// </summary>
    [MaxLength(20)]
    [Column("GTPZ", Order = 106)]
    public string Gtpz { get; set; }
    /// <summary>
    /// 获取或者设置重点监控标志
    /// </summary>
    [MaxLength(20)]
    [Column("ZDJKBJ", Order = 107)]
    public string Zdjkbj { get; set; }
    /// <summary>
    /// 获取或者设置抗肿瘤药物标志
    /// </summary>
    [MaxLength(20)]
    [Column("SQZKZLYW", Order = 108)]
    public string Sqzkzlyw { get; set; }
    /// <summary>
    /// 获取或者设置糖皮质激素标志
    /// </summary>
    [MaxLength(20)]
    [Column("TPZJSBJ", Order = 109)]
    public string Tpzjsbj { get; set; }
    /// <summary>
    /// 获取或者设置采购类别
    /// </summary>
    [MaxLength(20)]
    [Column("CGLB", Order = 110)]
    public string Cglb { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return ID;
    }
}
