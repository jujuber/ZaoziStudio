using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;
public class ManfDTO
{
    /// <summary>
    /// 厂家代码
    /// </summary>
    public string ManfCode { get; set; }
    /// <summary>
    /// 厂家名称
    /// </summary>
    public string ManfDesc { get; set; }
    /// <summary>
    /// 使用标记
    /// </summary>
    public string UseFlag { get; set; }
    /// <summary>
    /// 联系电话
    /// </summary>
    public string Tel { get; set; }
    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; }
}
