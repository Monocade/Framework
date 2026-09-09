using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_CameraSpec
    {
        public SDL_PixelFormat Format
        {
            get => format;
            set => format = value;
        }

        public SDL_Colorspace Colorspace
        {
            get => colorspace;
            set => colorspace = value;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public int Framerate_numerator
        {
            get => framerate_numerator;
            set => framerate_numerator = value;
        }

        public int Framerate_denominator
        {
            get => framerate_denominator;
            set => framerate_denominator = value;
        }
    }
}