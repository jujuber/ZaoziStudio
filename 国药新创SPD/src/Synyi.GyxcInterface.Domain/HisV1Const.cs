using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Domain;
internal class HisV1Const
{
    /// <summary>
    /// 数据库名称
    /// </summary>
    public const string DbName = "Hill";

    /// <summary>
    /// 医保数据库链接名称
    /// </summary>
    public const string MedicalInsuranceConnectionName = "Hill_MedicalInsurance";

    /// <summary>
    /// 病历链接名称
    /// </summary>
    public const string EmrConnectionName = "EMR";

    /// <summary>
    /// 获取模块名称
    /// </summary>
    public static string ModuleName { get { return KernelFacade.Module.GetModuleName(typeof(HisV1Const)); } }
}
