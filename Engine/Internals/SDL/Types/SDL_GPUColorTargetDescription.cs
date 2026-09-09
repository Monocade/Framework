using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUColorTargetDescription
    {
        public SDL_GPUTextureFormat Format
        {
            get => format;
            set => format = value;
        }

        public SDL_GPUColorTargetBlendState Blend_state
        {
            get => blend_state;
            set => blend_state = value;
        }
    }
}