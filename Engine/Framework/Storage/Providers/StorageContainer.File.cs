using System;

namespace Engine
{
    // File Storage Provider
    internal sealed unsafe class FileStorageContainer(SDL_Storage* handle) : StorageContainer(handle)
    {
        public override bool IsReady => SDL_StorageReady(Handle);
        
        public override bool IsWritable => true;

        public override bool IsReadable => true;
    }
}