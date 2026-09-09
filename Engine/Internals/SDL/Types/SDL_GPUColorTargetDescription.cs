using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUColorTargetDescription
    {
        private SDL_GPUTextureFormat format;

        private SDL_GPUColorTargetBlendState blend_state;
    }
}