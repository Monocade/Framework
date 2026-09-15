using System;

namespace Engine
{
    // Storage Provider
    public abstract unsafe class StorageContainer : IDisposable
    {
        public abstract bool IsWritable { get; }

        public abstract bool IsReadable { get; }

        public abstract bool IsReady { get; }

        internal SDL_Storage* Handle
        {
            get; private set;
        }
        
        
        internal StorageContainer(SDL_Storage* handle)
        {
            this.Handle = handle;
        }

        ~StorageContainer()
        {
            Dispose();
        }
        
        
        public void Dispose()
        {
            if (Handle != null)
            {
                SDL_CloseStorage(Handle);
            }
        }
    }
}