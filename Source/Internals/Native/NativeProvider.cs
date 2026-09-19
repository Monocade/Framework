using System;

namespace Engine
{
    internal abstract unsafe class NativeProvider
    {
        public abstract IntPtr Allocate(UIntPtr size);

        public abstract void Free(IntPtr ptr);
    }
}