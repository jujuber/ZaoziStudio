using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医技使用申请单明细
/// </summary>
[Table("epr_orderask")]
[PrimaryKey(nameof(Askno))]
public sealed class EprOrderask : EqualObject
{

    /// <summary>
    /// 获取或者设置医嘱号
    /// </summary>
    [Required]
    [Column("askno", Order = 101)]
    public int Askno { get; set; }

    /// <summary>
    /// 获取或者设置医嘱号
    /// </summary>
    [Required]
    [Column("orderno", Order = 102)]
    public int Orderno { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("ordercode", Order = 103)]
    public string Ordercode { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(250)]
    [Column("orderitem", Order = 104)]
    public string Orderitem { get; set; }

    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(10, 2)]
    [Column("sl", Order = 105)]
    public decimal? Sl { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("sldw", Order = 106)]
    public string Sldw { get; set; }

    /// <summary>
    /// 获取或者设置备血医嘱号
    /// </summary>
    [Column("tfbxorderno", Order = 107)]
    public int? TfbxOrderno { get; set; }

    /// <summary>
    /// 获取或者设置备血医嘱血袋号
    /// </summary>
    [MaxLength(32)]
    [Column("tfbxxdh", Order = 108)]
    public string TfbxXdh { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Askno;
    }

}
