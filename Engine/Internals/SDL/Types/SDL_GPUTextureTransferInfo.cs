using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTextureTransferInfo
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

        public uint Pixels_per_row
        {
            get => pixels_per_row;
            set => pixels_per_row = value;
        }

        public uint Rows_per_layer
        {
            get => rows_per_layer;
            set => rows_per_layer = value;
        }
    }
}