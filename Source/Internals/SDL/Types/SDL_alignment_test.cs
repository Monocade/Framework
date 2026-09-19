using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_alignment_test
    {
        public byte A
        {
            get => a;
            set => a = value;
        }

        public IntPtr B
        {
            get => b;
            set => b = value;
        }
    }
}