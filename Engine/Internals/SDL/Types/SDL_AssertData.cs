using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_AssertData
    {
        private SDL_Bool always_ignore;

        private uint trigger_count;

        private byte* condition;

        private byte* filename;

        private int linenum;

        private byte* function;

        private SDL_AssertData* next;
    }
}