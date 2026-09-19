using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUBufferCreateInfo
    {
        public SDL_GPUBufferUsageFlags Usage
        {
            get => (SDL_GPUBufferUsageFlags)usage;
            set => usage = (uint)value;
        }

        public uint Size
        {
            get => size;
            set => size = value;
        }

        public uint Props
        {
            get => props;
            set => props = value;
        }
    }
}