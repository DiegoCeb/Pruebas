using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCentralizacionCoomeva.Core.Module;
using AppCentralizacionCoomeva.Module.Procesos.Types;

namespace AppCentralizacionCoomeva.Module.Procesos
{
    public class BasicSeleccionProcesos : ModuleNestedBase, IModule
    {
        public BasicSeleccionProcesos(Collection<IModule> innerModules) : base(new Collection<IModule>() { new SeleccionProcesos() })
        {

        }
    }
}
