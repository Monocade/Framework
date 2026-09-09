using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUViewport
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

        public float Min_depth
        {
            get => min_depth;
            set => min_depth = value;
        }

        public float Max_depth
        {
            get => max_depth;
            set => max_depth = value;
        }
    }
}