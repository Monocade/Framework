using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUBufferCreateInfo
    {
        public uint Usage
        {
            get => usage;
            set => usage = value;
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