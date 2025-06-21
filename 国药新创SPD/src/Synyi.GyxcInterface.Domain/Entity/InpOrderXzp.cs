using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医嘱关联血袋记录
/// </summary>
[Table("INP_ORDER_XZP")]
[PrimaryKey(nameof(Id))]
public sealed class InpOrderXzp : EqualObject
{

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Required]
    [Column("ID", Order = 100)]
    public int Id { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("FEERDN", Order = 101)]
    public int? Feerdn { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("MRN", Order = 102)]
    public int Mrn { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("SERIES", Order = 103)]
    public int Series { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("HZXM", Order = 104)]
    public string Hzxm { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("XDH", Order = 105)]
    public string Xdh { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(128)]
    [Column("XDHDESC", Order = 106)]
    public string XdhDesc { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("ORDERNO", Order = 107)]
    public int? OrderNo { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("ZXZT", Order = 108)]
    public int? Zxzt { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("ZXRQ", Order = 109)]
    public DateTime? Zxrq { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(32)]
    [Column("ZXRID", Order = 110)]
    public string ZxrId { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("ZXR", Order = 111)]
    public string Zxr { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("USEFLAG", Order = 112)]
    public int? UseFlag { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("DJFLID", Order = 113)]
    public string DjflId { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("CJRQ", Order = 114)]
    public DateTime? Cjrq { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(64)]
    [Column("CJYGID", Order = 115)]
    public string CjygId { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(128)]
    [Column("XMMC", Order = 116)]
    public string Xmmc { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(128)]
    [Column("XMDM", Order = 117)]
    public string Xmdm { get; set; }

    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(128)]
    [Column("XMGG", Order = 118)]
    public string Xmgg { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}
