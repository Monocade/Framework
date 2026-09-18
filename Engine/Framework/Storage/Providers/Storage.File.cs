using System;

namespace Engine
{
    // File Storage Provider
    internal sealed unsafe class FileStorage(SDL_Storage* handle) : Storage(handle)
    {
        public override bool IsReady => SDL_StorageReady(Handle);
        
        public override bool IsWritable => true;

        public override bool IsReadable => true;
    }
}