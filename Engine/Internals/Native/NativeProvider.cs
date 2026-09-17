using System;

namespace Engine
{
    internal abstract unsafe class NativeProvider
    {
        public abstract byte* Allocate(nuint size);
        
        public abstract void Free(byte* ptr);
    }
}