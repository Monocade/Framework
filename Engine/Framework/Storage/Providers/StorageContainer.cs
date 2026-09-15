using System;

namespace Engine
{
    // Storage Provider
    public abstract unsafe class StorageContainer : IDisposable
    {
        internal SDL_Storage* Handle
        {
            get;
        }

        public abstract bool IsWritable { get; }

        public abstract bool IsReadable { get; }

        public abstract bool IsReady { get; }

        
        internal StorageContainer(SDL_Storage* handle)
        {
            this.Handle = handle;
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