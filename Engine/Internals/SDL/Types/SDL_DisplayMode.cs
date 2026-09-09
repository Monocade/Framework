using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_DisplayMode
    {
        private uint displayID;

        private SDL_PixelFormat format;

        private int w;

        private int h;

        private float pixel_density;

        private float refresh_rate;

        private int refresh_rate_numerator;

        private int refresh_rate_denominator;

        private SDL_DisplayModeData* @internal;
    }
}