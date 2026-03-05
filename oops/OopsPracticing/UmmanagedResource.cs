using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracticing
{
    public class UmmanagedResource : IDisposable
    {
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //Write Code Here to Destroy the Managed Resources
                    Console.WriteLine("Managed Resources Destroyed by Dispose Method");
                }

                //Write Code Here to Destroy the Umanaged Resources
                Console.WriteLine("Unmanaged Resources Destroyed by Dispose Method");
                disposedValue = true;
            }
            else
            {
                Console.WriteLine("Resources are Already Destroyed by Dispose Method");
            }
        }

        ~UmmanagedResource()
        {
            //Write Code here to Destroy the Object
            Console.WriteLine("Request Comes to Destructor to Destroy the Resources");
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            //Write Code here to Destroy the Object
            Console.WriteLine("Request Comes to Dispose Method to Destroy the Resources");
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }

    public class ResourceHolder : IDisposable
    {
        // To track whether Dispose has been called.
        private bool _disposed = false;

        // Constructor
        public ResourceHolder()
        {
            // Allocate or initialize an unmanaged resource.
            Console.WriteLine("Unmanaged resource allocated.");
        }

        // Implementing Dispose method from IDisposable interface
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Prevent finalizer from being called.
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Free any other managed objects here.
                    Console.WriteLine("Free other managed objects");
                }

                // Free unmanaged resources here.
                Console.WriteLine("Unmanaged resource released.");
                _disposed = true;
            }
        }

        // Finalizer is nothing but the destructor
        ~ResourceHolder()
        {
            Dispose(false);
            Console.WriteLine("Finalizer called.");
        }
    }

}
