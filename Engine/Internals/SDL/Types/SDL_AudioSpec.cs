using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_AudioSpec
    {
        private SDL_AudioFormat format;

        private int channels;

        private int freq;
    }
}