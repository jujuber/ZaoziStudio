using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Application.Abstractions.Catalog.DTO;
public class SPC101Response
{
    /// <summary>
    /// 返回代码 0成功，其他失败
    /// </summary>
    public int ReturnCode { get; set; }

    /// <summary>
    /// 返回信息
    /// </summary>
    public string ResultContent { get; set; }
}
