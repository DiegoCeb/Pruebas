using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCentralizacionCoomeva.Core.Module;

namespace AppCentralizacionCoomeva.Module.Procesos.Types
{
    public class SeleccionProcesos : ModuleBase, IModule
    {

        public void Init()
        {
            Variables.Variables.Proceso = SeleccionarProceso();
            Dispose();
        }


        private static string SeleccionarProceso()
        {
            Console.WriteLine("1. Saldos Menores");
            Console.WriteLine("");
            Console.WriteLine("2. Codeudores");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el numero del proceso que desea realizar");
            Console.WriteLine("");
            string resultado = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine("");
            return resultado;
        }
    }
}
