using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Point
    {
        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }
    }
}