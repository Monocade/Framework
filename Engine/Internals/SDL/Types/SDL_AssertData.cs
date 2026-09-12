using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_AssertData
    {
        public bool AlwaysIgnore
        {
            get => always_ignore;
            set => always_ignore = value;
        }

        public uint TriggerCount
        {
            get => trigger_count;
            set => trigger_count = value;
        }

        public byte* Condition
        {
            get => condition;
            set => condition = value;
        }

        public byte* Filename
        {
            get => filename;
            set => filename = value;
        }

        public int Linenum
        {
            get => linenum;
            set => linenum = value;
        }

        public byte* Function
        {
            get => function;
            set => function = value;
        }

        public SDL_AssertData* Next
        {
            get => next;
            set => next = value;
        }
    }
}