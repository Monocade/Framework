using System;

namespace Engine
{
    // Title Storage Provider
    internal sealed unsafe class TitleStorageContainer(SDL_Storage* handle) : StorageContainer(handle)
    {
        public override bool IsReady => SDL_StorageReady(Handle);
        
        public override bool IsWritable => false;

        public override bool IsReadable => true;
    }
}