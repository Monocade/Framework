using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GUID
    {
        public _data_e__FixedBuffer Data
        {
            get => data;
            set => data = value;
        }
    }
}