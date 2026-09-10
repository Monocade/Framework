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

        public byte Padding1
        {
            get => padding1;
            set => padding1 = value;
        }

        public byte Padding2
        {
            get => padding2;
            set => padding2 = value;
        }

        public byte Padding3
        {
            get => padding3;
            set => padding3 = value;
        }
    }
}