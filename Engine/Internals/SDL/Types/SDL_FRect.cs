using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_FRect
    {
        public float X
        {
            get => x;
            set => x = value;
        }

        public float Y
        {
            get => y;
            set => y = value;
        }

        public float W
        {
            get => w;
            set => w = value;
        }

        public float H
        {
            get => h;
            set => h = value;
        }
    }
}