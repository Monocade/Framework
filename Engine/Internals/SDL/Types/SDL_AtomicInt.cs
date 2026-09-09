using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_AtomicInt
    {
        public int Value
        {
            get => this.value;
            set => this.value = value;
        }
    }
}