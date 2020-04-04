using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AppCentralizacionCoomeva.Core.Module;
using AppCentralizacionCoomeva.Module.Utilidades;

namespace AppCentralizacionCoomeva.Module.Codeudores.Types
{
    public class Codeudores : ModuleBase, IModule
    {
        private readonly Variables.Variables _instanciaVariables;
        private readonly Genericos _instanciaUtilidades;
        private List<string> _datosBase = new List<string>();
        private string _nombreArchivo;
        public Codeudores()
        {
            _instanciaVariables = new Variables.Variables();
            _instanciaUtilidades = new Genericos();

            Console.WriteLine("Ingrese la ruta donde se encuentra el Excel del proceso");
            Console.WriteLine("");
            _instanciaVariables.RutaProceso = Console.ReadLine();
        }

        public void Init()
        {
            try
            {
                CargarBase(_instanciaVariables.RutaProceso);
                GenerarSalida();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void CargarBase(string ruta)
        {
            IEnumerable<string> archivo = from excel in Directory.GetFiles(ruta)
                          where Path.GetExtension(excel) == ".xls"
                          select excel;

            // ReSharper disable once PossibleMultipleEnumeration
            _datosBase = _instanciaUtilidades.ConvertirExcel(archivo.First());

            // ReSharper disable once PossibleMultipleEnumeration
            _nombreArchivo = Path.GetFileNameWithoutExtension(archivo.First());
        }

        private void GenerarSalida()
        {
            _instanciaVariables.Escritor = new StreamWriter($"{_instanciaVariables.RutaProceso}\\{_nombreArchivo}.sal", false, Encoding.Default);

            foreach (var lineaFinal in _datosBase)
            {
                _instanciaVariables.Escritor.WriteLine($"{_instanciaVariables.CanalPrincipal}|{_instanciaVariables.Consecutivo}|{lineaFinal}");
                _instanciaVariables.Escritor.Flush();
                _instanciaVariables.Consecutivo++;
            }

            _instanciaVariables.Escritor.Close();
        }

    }
}
