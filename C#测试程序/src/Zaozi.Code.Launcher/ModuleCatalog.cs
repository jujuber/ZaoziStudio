using Synyi.Framework.Kernel.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaozi.Code.TestUI;

namespace Zaozi.Code.Launcher;
public class ModuleCatalog : ModuleCatalogBase
{
    protected override IEnumerable<ModuleInfo> CreateModules()
    {
        yield return this.CreateModule<ZaoziCodeWpfModule>();
    }
}
