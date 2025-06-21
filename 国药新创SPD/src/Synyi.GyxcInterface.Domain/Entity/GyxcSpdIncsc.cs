using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Domain.Entity;
/// <summary>
///  
/// </summary>
[Table("GYXC_SPD_INCSC")]
[PrimaryKey(nameof(IncscCode))]
public class GyxcSpdIncsc : EqualObject
{
    /// <summary>
    ///  
    /// </summary>
    [Required]
    [MaxLength(32)]
    [Column("IncscCode", Order = 1)]
    public string IncscCode { get; set; }
    /// <summary>
    ///  
    /// </summary>
    [MaxLength(64)]
    [Column("IncscDesc", Order = 2)]
    public string IncscDesc { get; set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return IncscCode; 
    }
}
