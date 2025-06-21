using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Synyi.Framework.Kernel;
using Synyi.GyxcInterface.Application.Abstractions.Basics;
using Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;
using Synyi.GyxcInterface.Application.Abstractions.Catalog;
using Synyi.GyxcInterface.Application.Abstractions.Catalog.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.WebApi;
/// <summary>
/// 
/// </summary>
[ApiController]
[Route("ToHis/[controller]")]
public class BasicsController : ControllerBase
{
    private readonly ISaveManfDataService saveManfDataService;
    private readonly ISaveVendorDataService saveVendorDataService;
    private readonly ISynIncscDataService synIncscDataService;
    private readonly IMaterialCatalogService materialCatalogService;
    /// <summary>
    ///  
    /// </summary>
    private readonly IBasicService service;
    public BasicsController(IBasicService service, 
        ISynIncscDataService synIncscDataService,
        ISaveVendorDataService saveVendorDataService,
        ISaveManfDataService saveManfDataService,
        IMaterialCatalogService materialCatalogService)
    {
        this.service = service;
        this.synIncscDataService = synIncscDataService;
        this.saveVendorDataService = saveVendorDataService;
        this.saveManfDataService = saveManfDataService;
        this.materialCatalogService = materialCatalogService;
    }

    /// <summary>
    /// 获取字典
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [HttpPost("[action]")]
    [AllowAnonymous]
    public async Task<ResultData<List<Code217DTO>>> GetDicts(GetInputDTO value)
    {
        var data = await this.service.GetDicts(value);

        return new ResultData<List<Code217DTO>>
        {
            IsSucceed = true,
            Data = data,
        };
    }

    [HttpPost("[action]")]
    [AllowAnonymous]
    public async Task<ResultData<bool>> SynIncscData(List<GyxcSpdIncscDTO> data)
    {
        InputIncscsDTO input = new InputIncscsDTO { Datas = data };

        var result = await this.synIncscDataService.SynIncscData(input);

        return new ResultData<bool>
        {
            IsSucceed = true,
            Data = result,
        };
    }

    [HttpPost("[action]")]
    [AllowAnonymous]
    public async Task<ResultData<bool>> SaveVendorData(List<VendorDTO> data)
    {
        var result = await this.saveVendorDataService.SaveVendorData(data);

        return new ResultData<bool>
        {
            IsSucceed = true,
            Data = result,
        };
    }
    [HttpPost("[action]")]
    [AllowAnonymous]
    public async Task<ResultData<bool>> SaveManfData(List<ManfDTO> data)
    {
        var result = await this.saveManfDataService.SaveManfData(data);

        return new ResultData<bool>
        {
            IsSucceed = true,
            Data = result,
        };
    }

    [HttpPost("[action]")]
    [AllowAnonymous]
    public async Task<ResultData<bool>> SyncYbMatch()
    {
        var result = await this.materialCatalogService.SyncYbMatch();

        return new ResultData<bool>
        {
            IsSucceed = true,
            Data = result,
        };
    }

    [HttpPost("[action]")]
    [AllowAnonymous]
    public async Task<ResultData<ResultCataLog>> SyncData(List<CatalogDTO> values)
    {
        var result = await this.materialCatalogService.SyncData(values);

        return new ResultData<ResultCataLog>
        {
            IsSucceed = true,
            Data = result,
        };
    }
}
