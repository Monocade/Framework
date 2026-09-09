using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUViewport
    {
        private float x;

        private float y;

        private float w;

        private float h;

        private float min_depth;

        private float max_depth;
    }
}