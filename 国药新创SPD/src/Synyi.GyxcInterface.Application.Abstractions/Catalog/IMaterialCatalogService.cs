using Synyi.Framework.Application.Edit;
using Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;
using Synyi.GyxcInterface.Application.Abstractions.Catalog.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Application.Abstractions.Catalog;
public interface IMaterialCatalogService : IEditApplicationService
{
    Task<ResultCataLog> SyncData(List<CatalogDTO> values);

    Task<bool> SyncYbMatch();
}
