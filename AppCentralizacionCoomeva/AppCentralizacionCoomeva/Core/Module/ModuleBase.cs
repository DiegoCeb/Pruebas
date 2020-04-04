using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCentralizacionCoomeva.Module.Variables;

namespace AppCentralizacionCoomeva.Core.Module
{
    public abstract class ModuleBase : IDisposable
    {
        // Flag: Has Dispose already been called?
        private bool _disposed = false;

        protected ModuleBase()
        {
            Console.WriteLine("");
            Console.WriteLine($"Inicia la ejecucion del modulo {this.GetType()}");
            Console.WriteLine("");
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            _disposed = true;
        }

    }
}
