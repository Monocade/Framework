using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUDepthStencilState
    {
        private SDL_GPUCompareOp compare_op;

        private SDL_GPUStencilOpState back_stencil_state;

        private SDL_GPUStencilOpState front_stencil_state;

        private byte compare_mask;

        private byte write_mask;

        private SDL_Bool enable_depth_test;

        private SDL_Bool enable_depth_write;

        private SDL_Bool enable_stencil_test;

        private byte padding1;

        private byte padding2;

        private byte padding3;
    }
}