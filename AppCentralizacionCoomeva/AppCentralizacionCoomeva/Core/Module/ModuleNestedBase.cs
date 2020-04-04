using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCentralizacionCoomeva.Module.Variables;

namespace AppCentralizacionCoomeva.Core.Module
{
    public abstract class ModuleNestedBase : IDisposable
    {
        // Flag: Has Dispose already been called?
        public bool Disposed = false;
        public readonly Collection<IModule> InnerModules;

        protected ModuleNestedBase(Collection<IModule> innerModules)
        {
            InnerModules = innerModules;
        }

        public virtual void Init()
        {
            foreach (IModule module in InnerModules)
            {
                module.Init();
            }
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (Disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
            }

            // Free any unmanaged objects here.
            Disposed = true;
        }
    }
}
