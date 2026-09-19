using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_UserEvent
    {
        public uint Type
        {
            get => type;
            set => type = value;
        }

        public uint Reserved
        {
            get => reserved;
            set => reserved = value;
        }

        public ulong Timestamp
        {
            get => timestamp;
            set => timestamp = value;
        }

        public uint WindowID
        {
            get => windowID;
            set => windowID = value;
        }

        public int Code
        {
            get => code;
            set => code = value;
        }

        public IntPtr Data1
        {
            get => data1;
            set => data1 = value;
        }

        public IntPtr Data2
        {
            get => data2;
            set => data2 = value;
        }
    }
}