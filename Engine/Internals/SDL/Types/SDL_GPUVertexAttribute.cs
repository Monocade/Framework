using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVertexAttribute
    {
        public uint Location
        {
            get => location;
            set => location = value;
        }

        public uint Buffer_slot
        {
            get => buffer_slot;
            set => buffer_slot = value;
        }

        public SDL_GPUVertexElementFormat Format
        {
            get => format;
            set => format = value;
        }

        public uint Offset
        {
            get => offset;
            set => offset = value;
        }
    }
}