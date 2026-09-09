using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Rect
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

        public int W
        {
            get => w;
            set => w = value;
        }

        public int H
        {
            get => h;
            set => h = value;
        }
    }
}