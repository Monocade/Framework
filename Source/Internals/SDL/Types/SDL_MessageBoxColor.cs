using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MessageBoxColor
    {
        public byte R
        {
            get => r;
            set => r = value;
        }

        public byte G
        {
            get => g;
            set => g = value;
        }

        public byte B
        {
            get => b;
            set => b = value;
        }
    }
}