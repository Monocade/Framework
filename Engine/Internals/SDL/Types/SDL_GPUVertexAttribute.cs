using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUVertexAttribute
    {
        private uint location;

        private uint buffer_slot;

        private SDL_GPUVertexElementFormat format;

        private uint offset;
    }
}