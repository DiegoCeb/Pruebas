using System;
using System.Diagnostics;
using System.Reflection;
using AppCentralizacionCoomeva.Module.Codeudores.Types;
using AppCentralizacionCoomeva.Module.Procesos.Types;
using AppCentralizacionCoomeva.Module.SaldosMenores.Types;
using AppCentralizacionCoomeva.Module.Variables;

namespace AppCentralizacionCoomeva
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assem = Assembly.GetEntryAssembly();
            AssemblyName assemName = assem?.GetName();
            Version ver = assemName?.Version;

            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly()?.Location ?? throw new InvalidOperationException());

            string companyName = versionInfo.CompanyName;

            string version = ver?.ToString();

            Console.WriteLine("");
            Console.WriteLine(" **************");
            Console.WriteLine(" *    *****   *");
            Console.WriteLine(" *   **   **  *      " + "Procesador Procesos Coomeva");
            Console.WriteLine(" *  **        *      " + "Nombre:\tProcesos Coomeva");
            Console.WriteLine(" *  **        *      " + "Version:\t" + version);
            Console.WriteLine(" *   **   **  *      " + "Compañia:\t" + companyName);
            Console.WriteLine(" *    *****   *");
            Console.WriteLine(" **************");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Title = "Procesos Coomeva " + version;

            using (var module = new SeleccionProcesos())
            {
                module.Init();
            }

            switch (Variables.Proceso)
            {
                case "1":
                    using (var module = new SaldosMenores())
                    {
                        module.Init();
                    }
                    break;

                case "2":
                    using (var module = new Codeudores())
                    {
                        module.Init();
                    }
                    break;

                case "3":
                    break;

            }
        }
    }
}
