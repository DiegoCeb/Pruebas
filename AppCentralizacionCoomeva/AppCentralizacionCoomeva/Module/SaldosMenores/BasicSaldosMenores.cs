using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCentralizacionCoomeva.Core;
using AppCentralizacionCoomeva.Core.Module;

namespace AppCentralizacionCoomeva.Module.SaldosMenores
{
    public class BasicSaldosMenores : ModuleNestedBase, IModule
    {
        public BasicSaldosMenores() : base(new Collection<IModule>() { new Types.SaldosMenores()})
        {
            
        }
    }
}
