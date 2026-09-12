using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_PinchFingerEvent
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

        public float Scale
        {
            get => scale;
            set => scale = value;
        }

        public uint WindowID
        {
            get => windowID;
            set => windowID = value;
        }

        public float SpanX
        {
            get => span_x;
            set => span_x = value;
        }

        public float SpanY
        {
            get => span_y;
            set => span_y = value;
        }

        public float FocusX
        {
            get => focus_x;
            set => focus_x = value;
        }

        public float FocusY
        {
            get => focus_y;
            set => focus_y = value;
        }
    }
}