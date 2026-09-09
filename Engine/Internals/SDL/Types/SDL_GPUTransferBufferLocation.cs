using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTransferBufferLocation
    {
        public SDL_GPUTransferBuffer* Transfer_buffer
        {
            get => transfer_buffer;
            set => transfer_buffer = value;
        }

        public uint Offset
        {
            get => offset;
            set => offset = value;
        }
    }
}