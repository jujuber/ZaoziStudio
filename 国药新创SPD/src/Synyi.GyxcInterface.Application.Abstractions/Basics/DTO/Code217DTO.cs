using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;
public class Code217DTO
{
    /// <summary>
    /// 获取或者设置产地代码
    /// </summary>
    public int Manfcode { get; set; }
    /// <summary>
    /// 获取或者设置产地
    /// </summary>
    public string Manf { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置gmp标志
    /// </summary>
    public string Gmp { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置简称
    /// </summary>
    public string Simple { get; set; }
    /// <summary>
    /// 获取或者设置进口标志
    /// </summary>
    public string Importflag { get; set; }
    /// <summary>
    /// 获取或者设置上级代码
    /// </summary>
    public int? Lastcode { get; set; }
    /// <summary>
    /// 获取或者设置地区
    /// </summary>
    public string Area { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    public string Mark { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    public string AssetcodeFlag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    public string DrugFlag { get; set; }
    /// <summary>
    /// 获取或者设置第三方代码
    /// </summary>
    public string ThirdId { get; set; }
}
