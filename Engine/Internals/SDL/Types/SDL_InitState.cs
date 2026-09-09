using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_InitState
    {
        private SDL_AtomicInt status;

        private ulong thread;

        private IntPtr reserved;
    }
}