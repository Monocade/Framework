using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUStencilOpState
    {
        public SDL_GPUStencilOp FailOp
        {
            get => fail_op;
            set => fail_op = value;
        }

        public SDL_GPUStencilOp PassOp
        {
            get => pass_op;
            set => pass_op = value;
        }

        public SDL_GPUStencilOp DepthFailOp
        {
            get => depth_fail_op;
            set => depth_fail_op = value;
        }

        public SDL_GPUCompareOp CompareOp
        {
            get => compare_op;
            set => compare_op = value;
        }
    }
}