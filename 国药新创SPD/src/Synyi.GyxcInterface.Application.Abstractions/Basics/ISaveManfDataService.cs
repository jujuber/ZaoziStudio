using Synyi.Framework.Application.Edit;
using Synyi.GyxcInterface.Application.Abstractions.Basics.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Application.Abstractions.Basics;
public interface ISaveManfDataService : IEditApplicationService
{
    Task<bool> SaveManfData(List<ManfDTO> data);
}
