using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Application.Abstractions.Catalog.DTO;

public class CatalogDTO
{ 
    /// <summary>
    /// 物资代码 要求唯一
    /// </summary>
    public string InciCode { get; set; }

    /// <summary>
    /// 物资名称
    /// </summary>
    public string InciDesc { get; set; }

    /// <summary>
    /// 入库单位描述
    /// </summary>
    public string PUomDesc { get; set; }

    /// <summary>
    /// 基本单位描述
    /// </summary>
    public string BUomDesc { get; set; }

    /// <summary>
    /// 库存分类  参考对照约定(可线下对应)
    /// </summary>
    public string IncscDesc { get; set; }

    /// <summary>
    /// 规格
    /// </summary>
    public string Spec { get; set; }
    /// <summary>
    /// 品牌
    /// </summary>
    public string Brand { get; set; }
    /// <summary>
    /// 型号
    /// </summary>
    public string Model { get; set; }
    /// <summary>
    /// 简称
    /// </summary>
    public string Abbrev { get; set; }
    /// <summary>
    /// 科室对照代码  参考对照约定(建议用id)
    /// </summary>
    public string LocCode { get; set; }
    /// <summary>
    /// 用户对照代码 参考对照约定(一般是工号)
    /// </summary>
    public string UserCode { get; set; }
    /// <summary>
    /// 收费标记 只有库存项的,传"N";  传”Y”时,需要医嘱项信息; ??
    /// </summary>
    public string ChargeFlag { get; set; }
    /// <summary>
    /// 进价  对应入库单位 Float
    /// </summary>
    public string Rp { get; set; }
    /// <summary>
    /// 售价 对应入库单位 Float
    /// </summary>
    public string Sp { get; set; }
    /// <summary>
    /// 注册证号   
    /// </summary>
    public string RegCertNo { get; set; }
    /// <summary>
    /// 注册证日期 YYYY-mm-dd
    /// </summary>
    public string RegCertExpDate { get; set; }
    /// <summary>
    /// 供应商代码 参考对照约定
    /// </summary>
    public string VenCode { get; set; }
    /// <summary>
    /// 厂商代码 参考对照约定
    /// </summary>
    public string ManfCode { get; set; }
    /// <summary>
    /// 医保分类代码
    /// </summary>
    public string MatInsuCode { get; set; }
    /// <summary>
    /// 高值标记 Y/N
    /// </summary>
    public string HVFlag { get; set; }
    /// <summary>
    /// 进口国产 1-进口,2-国产
    /// </summary>
    public string ImpFlag { get; set; }
    /// <summary>
    /// 使用标记 Y/N
    /// </summary>
    public string UseFlag { get; set; }
    /// <summary>
    /// 医嘱项Object  如ChargeFlag=”Y”,注意ArcInfo内的必填项
    /// </summary>
    public ArcInfo ArcInfo { get; set; }

}

public class ArcInfo
{
    /// <summary>
    /// 医嘱项代码  一般与库存项代码一致
    /// </summary>
    public string ArcCode { get; set; }
    /// <summary>
    /// 医嘱项名称 一般与库存项名称一致
    /// </summary>
    public string ArcDesc { get; set; }
    /// <summary>
    /// 计价单位  入库单位或基本单位
    /// </summary>
    public string BillUomDesc { get; set; }
    /// <summary>
    /// 医嘱子类 1、高值耗材SPD 2、低值耗材SPD
    /// </summary>
    public string OrdSubCat { get; set; }
    /// <summary>
    /// 费用子类
    /// </summary>
    public string BillSubCat { get; set; }
    /// <summary>
    /// 独立医嘱标记 Y/N
    /// </summary>
    public string OwnFlag { get; set; }
    /// <summary>
    /// 医嘱优先级
    /// </summary>
    public string Priority { get; set; }
    /// <summary>
    /// 无库存医嘱标记 Y/N
    /// </summary>
    public string WoStock { get; set; }
    /// <summary>
    /// 收费项代码  一般与库存项,医嘱项代码 保持一致
    /// </summary>
    public string TariCode { get; set; }
    /// <summary>
    /// 收费项名称 一般与库存项,医嘱项名称 保持一致
    /// </summary>
    public string TariDesc { get; set; }
    /// <summary>
    /// 收费项目子分类  材料费
    /// </summary>
    public string TarSubCat { get; set; }
    /// <summary>
    /// 收费项目住院子分类  材料费
    /// </summary>
    public string TarInpatCat { get; set; }
    /// <summary> 
    /// 收费项目门诊子分类 材料费
    /// </summary>
    public string TarOutpatCat { get; set; }
    /// <summary>
    /// 收费项目核算子分类  材料费
    /// </summary>
    public string TarEMCCat { get; set; }
    /// <summary>
    /// 收费项目会计子分类  卫生材料收入
    /// </summary>
    public string TarAcctCat { get; set; }
    /// <summary>
    /// 收费项目病历首页子分类 1、治疗用一次性医用材料费 2、检查用一次性医用材料费 3、手术用一次性医用材料费
    /// </summary>
    public string TarMRCat { get; set; }
    /// <summary>
    /// 收费项目新病历首页子分类 1、治疗用一次性医用材料费 2、检查用一次性医用材料费 3、手术用一次性医用材料费
    /// </summary>
    public string TarNewMRCat { get; set; }
    /// <summary>
    /// 收费依据
    /// </summary>
    public string ChargeBasis { get; set; }
} 
