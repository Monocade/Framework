using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_WindowEvent
    {
        public SDL_EventType Type
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

        public int Data1
        {
            get => data1;
            set => data1 = value;
        }

        public int Data2
        {
            get => data2;
            set => data2 = value;
        }
    }
}