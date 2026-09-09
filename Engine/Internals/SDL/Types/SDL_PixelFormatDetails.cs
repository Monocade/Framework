using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_PixelFormatDetails
    {
        public SDL_PixelFormat Format
        {
            get => format;
            set => format = value;
        }

        public byte Bits_per_pixel
        {
            get => bits_per_pixel;
            set => bits_per_pixel = value;
        }

        public byte Bytes_per_pixel
        {
            get => bytes_per_pixel;
            set => bytes_per_pixel = value;
        }

        public _padding_e__FixedBuffer Padding
        {
            get => padding;
            set => padding = value;
        }

        public uint rmask
        {
            get => Rmask;
            set => Rmask = value;
        }

        public uint gmask
        {
            get => Gmask;
            set => Gmask = value;
        }

        public uint bmask
        {
            get => Bmask;
            set => Bmask = value;
        }

        public uint amask
        {
            get => Amask;
            set => Amask = value;
        }

        public byte rbits
        {
            get => Rbits;
            set => Rbits = value;
        }

        public byte gbits
        {
            get => Gbits;
            set => Gbits = value;
        }

        public byte bbits
        {
            get => Bbits;
            set => Bbits = value;
        }

        public byte abits
        {
            get => Abits;
            set => Abits = value;
        }

        public byte rshift
        {
            get => Rshift;
            set => Rshift = value;
        }

        public byte gshift
        {
            get => Gshift;
            set => Gshift = value;
        }

        public byte bshift
        {
            get => Bshift;
            set => Bshift = value;
        }

        public byte ashift
        {
            get => Ashift;
            set => Ashift = value;
        }
    }
}