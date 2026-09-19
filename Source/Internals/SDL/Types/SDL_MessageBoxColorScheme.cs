using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_MessageBoxColorScheme
    {
        public _colors_e__FixedBuffer Colors
        {
            get => colors;
            set => colors = value;
        }
    }
}