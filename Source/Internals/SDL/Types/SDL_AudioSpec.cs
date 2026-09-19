using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_AudioSpec
    {
        public SDL_AudioFormat Format
        {
            get => format;
            set => format = value;
        }

        public int Channels
        {
            get => channels;
            set => channels = value;
        }

        public int Freq
        {
            get => freq;
            set => freq = value;
        }
    }
}