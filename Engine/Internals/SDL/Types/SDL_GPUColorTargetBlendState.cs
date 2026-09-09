using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUColorTargetBlendState
    {
        private SDL_GPUBlendFactor src_color_blendfactor;

        private SDL_GPUBlendFactor dst_color_blendfactor;

        private SDL_GPUBlendOp color_blend_op;

        private SDL_GPUBlendFactor src_alpha_blendfactor;

        private SDL_GPUBlendFactor dst_alpha_blendfactor;

        private SDL_GPUBlendOp alpha_blend_op;

        private byte color_write_mask;

        private SDL_Bool enable_blend;

        private SDL_Bool enable_color_write_mask;

        private byte padding1;

        private byte padding2;
    }
}