using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_PixelFormatDetails
    {
        private SDL_PixelFormat format;

        private byte bits_per_pixel;

        private byte bytes_per_pixel;

        private _padding_e__FixedBuffer padding;

        private uint Rmask;

        private uint Gmask;

        private uint Bmask;

        private uint Amask;

        private byte Rbits;

        private byte Gbits;

        private byte Bbits;

        private byte Abits;

        private byte Rshift;

        private byte Gshift;

        private byte Bshift;

        private byte Ashift;
    }
}