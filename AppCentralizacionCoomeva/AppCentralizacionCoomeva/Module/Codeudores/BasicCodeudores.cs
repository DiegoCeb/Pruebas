using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCentralizacionCoomeva.Core.Module;

namespace AppCentralizacionCoomeva.Module.Codeudores
{
    public class BasicCodeudores : ModuleNestedBase, IModule
    {
        public BasicCodeudores() : base(new Collection<IModule>() { new Types.Codeudores() })
        {

        }
    }
}
