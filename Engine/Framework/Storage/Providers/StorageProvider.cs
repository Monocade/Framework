using System;

namespace Engine
{
    // Storage Provider
    public abstract unsafe class StorageProvider : IDisposable
    {
        public abstract bool IsWritable { get; }

        public abstract bool IsReadable { get; }

        public abstract bool IsReady { get; }

        internal SDL_Storage* Handle
        {
            get; private set;
        }
        
        
        internal StorageProvider(SDL_Storage* handle)
        {
            Handle = handle;
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