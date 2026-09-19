using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_FColor
    {
        public float R
        {
            get => r;
            set => r = value;
        }

        public float G
        {
            get => g;
            set => g = value;
        }

        public float B
        {
            get => b;
            set => b = value;
        }

        public float A
        {
            get => a;
            set => a = value;
        }
    }
}