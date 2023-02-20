using System;
using System.IO;



namespace Pesources
{
    public class Human: IDisposable
    {
        private string _name;
        private bool disposedValue;

        public Human(string name)
        {
            _name = name;
        }

        private void ReleaseUnmanagedResources()
        
            
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

              
        public void Dispose()
        {
           ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
        ~Human()
        {
            ReleaseUnmanagedResources ();
        }
    }
}
