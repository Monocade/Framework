using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUStorageBufferReadWriteBinding
    {
        private SDL_GPUBuffer* buffer;

        private SDL_Bool cycle;

        private byte padding1;

        private byte padding2;

        private byte padding3;
    }
}