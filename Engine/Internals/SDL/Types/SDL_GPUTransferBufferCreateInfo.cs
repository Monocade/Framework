using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTransferBufferCreateInfo
    {
        private SDL_GPUTransferBufferUsage usage;

        private uint size;

        private uint props;
    }
}