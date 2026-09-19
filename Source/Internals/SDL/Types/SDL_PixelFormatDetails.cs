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

        public byte BitsPerPixel
        {
            get => bits_per_pixel;
            set => bits_per_pixel = value;
        }

        public byte BytesPerPixel
        {
            get => bytes_per_pixel;
            set => bytes_per_pixel = value;
        }

        public uint RMask
        {
            get => Rmask;
            set => Rmask = value;
        }

        public uint GMask
        {
            get => Gmask;
            set => Gmask = value;
        }

        public uint BMask
        {
            get => Bmask;
            set => Bmask = value;
        }

        public uint AMask
        {
            get => Amask;
            set => Amask = value;
        }

        public byte RBits
        {
            get => Rbits;
            set => Rbits = value;
        }

        public byte GBits
        {
            get => Gbits;
            set => Gbits = value;
        }

        public byte BBits
        {
            get => Bbits;
            set => Bbits = value;
        }

        public byte ABits
        {
            get => Abits;
            set => Abits = value;
        }

        public byte RShift
        {
            get => Rshift;
            set => Rshift = value;
        }

        public byte GShift
        {
            get => Gshift;
            set => Gshift = value;
        }

        public byte BShift
        {
            get => Bshift;
            set => Bshift = value;
        }

        public byte AShift
        {
            get => Ashift;
            set => Ashift = value;
        }
    }
}