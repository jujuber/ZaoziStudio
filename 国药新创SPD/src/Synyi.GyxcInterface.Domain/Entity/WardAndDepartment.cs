using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;
/// <summary>
/// 科室病区对应
/// </summary>
[Table("INP_KSBQDY")]
[PrimaryKey(nameof(KsId), nameof(BqId))]
public class WardAndDepartment : EqualObject
{
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [String32]
    [Column("KSID", Order = 100)]
    public string KsId { get; set; }

    /// <summary>
    /// 获取或者设置病区代码
    /// </summary>
    [String32]
    [Column("BQID", Order = 101)]
    public string BqId { get; set; }

    /// <summary>
    /// 获取比较对象
    /// </summary>
    /// <returns>返回比较对象</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return KsId;
        yield return BqId;
    }
}
