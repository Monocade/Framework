using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_DialogFileFilter
    {
        public byte* Name
        {
            get => name;
            set => name = value;
        }

        public byte* Pattern
        {
            get => pattern;
            set => pattern = value;
        }
    }
}