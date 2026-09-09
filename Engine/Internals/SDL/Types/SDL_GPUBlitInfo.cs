using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUBlitInfo
    {
        private SDL_GPUBlitRegion source;

        private SDL_GPUBlitRegion destination;

        private SDL_GPULoadOp load_op;

        private SDL_FColor clear_color;

        private SDL_FlipMode flip_mode;

        private SDL_GPUFilter filter;

        private SDL_Bool cycle;

        private byte padding1;

        private byte padding2;

        private byte padding3;
    }
}