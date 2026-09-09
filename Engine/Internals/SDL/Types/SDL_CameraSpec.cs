using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_CameraSpec
    {
        private SDL_PixelFormat format;

        private SDL_Colorspace colorspace;

        private int width;

        private int height;

        private int framerate_numerator;

        private int framerate_denominator;
    }
}