using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUBufferBinding
    {
        public SDL_GPUBuffer* Buffer
        {
            get => buffer;
            set => buffer = value;
        }

        public uint Offset
        {
            get => offset;
            set => offset = value;
        }
    }
}