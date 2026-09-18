using System;

namespace Engine
{
    // User Storage Provider
    internal sealed unsafe class UserStorageProvider(SDL_Storage* handle) : StorageProvider(handle)
    {
        public override bool IsReady => SDL_StorageReady(Handle);
        
        public override bool IsWritable => true;

        public override bool IsReadable => true;
    }
}