using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTextureTransferInfo
    {
        private SDL_GPUTransferBuffer* transfer_buffer;

        private uint offset;

        private uint pixels_per_row;

        private uint rows_per_layer;
    }
}