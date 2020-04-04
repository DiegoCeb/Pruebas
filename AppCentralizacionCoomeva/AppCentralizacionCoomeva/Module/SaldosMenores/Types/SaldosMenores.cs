using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCentralizacionCoomeva.Core.Module;

namespace AppCentralizacionCoomeva.Module.SaldosMenores.Types
{
    public class SaldosMenores : ModuleBase, IModule
    {
        private readonly Variables.Variables _instanciaVariables;

        public SaldosMenores()
        {
            _instanciaVariables = new Variables.Variables();
        }

        public void Init()
        {
            
        }




    }
}
