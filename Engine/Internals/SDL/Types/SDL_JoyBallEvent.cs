using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_JoyBallEvent
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

        public uint Which
        {
            get => which;
            set => which = value;
        }

        public byte Ball
        {
            get => ball;
            set => ball = value;
        }

        public byte Padding1
        {
            get => padding1;
            set => padding1 = value;
        }

        public byte Padding2
        {
            get => padding2;
            set => padding2 = value;
        }

        public byte Padding3
        {
            get => padding3;
            set => padding3 = value;
        }

        public short Xrel
        {
            get => xrel;
            set => xrel = value;
        }

        public short Yrel
        {
            get => yrel;
            set => yrel = value;
        }
    }
}