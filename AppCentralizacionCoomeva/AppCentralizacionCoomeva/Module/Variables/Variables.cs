using System.IO;
using AppCentralizacionCoomeva.Core.Module;

namespace AppCentralizacionCoomeva.Module.Variables
{
    public class Variables
    {
        public static string Proceso;
        public StreamWriter Escritor = null;
        public string CanalPrincipal = "1AAA";
        public int Consecutivo = 1;
        public string RutaProceso;
    }
}
