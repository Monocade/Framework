using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_UserEvent
    {
        private uint type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private int code;

        private IntPtr data1;

        private IntPtr data2;
    }
}