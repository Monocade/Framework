using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUStencilOpState
    {
        public SDL_GPUStencilOp Fail_op
        {
            get => fail_op;
            set => fail_op = value;
        }

        public SDL_GPUStencilOp Pass_op
        {
            get => pass_op;
            set => pass_op = value;
        }

        public SDL_GPUStencilOp Depth_fail_op
        {
            get => depth_fail_op;
            set => depth_fail_op = value;
        }

        public SDL_GPUCompareOp Compare_op
        {
            get => compare_op;
            set => compare_op = value;
        }
    }
}