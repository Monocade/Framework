using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUStorageBufferReadWriteBinding
    {
        public SDL_GPUBuffer* Buffer
        {
            get => buffer;
            set => buffer = value;
        }

        public bool Cycle
        {
            get => cycle;
            set => cycle = value;
        }
    }
}