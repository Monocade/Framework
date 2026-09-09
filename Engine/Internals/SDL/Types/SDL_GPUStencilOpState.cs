using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUStencilOpState
    {
        private SDL_GPUStencilOp fail_op;

        private SDL_GPUStencilOp pass_op;

        private SDL_GPUStencilOp depth_fail_op;

        private SDL_GPUCompareOp compare_op;
    }
}