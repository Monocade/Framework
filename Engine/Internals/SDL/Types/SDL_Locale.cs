using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_Locale
    {
        public byte* Language
        {
            get => language;
            set => language = value;
        }

        public byte* Country
        {
            get => country;
            set => country = value;
        }
    }
}