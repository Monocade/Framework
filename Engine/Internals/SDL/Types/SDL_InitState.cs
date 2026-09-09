using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_InitState
    {
        public SDL_AtomicInt Status
        {
            get => status;
            set => status = value;
        }

        public ulong Thread
        {
            get => thread;
            set => thread = value;
        }

        public IntPtr Reserved
        {
            get => reserved;
            set => reserved = value;
        }
    }
}