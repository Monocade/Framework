using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Finger
    {
        private ulong id;

        private float x;

        private float y;

        private float pressure;
    }
}