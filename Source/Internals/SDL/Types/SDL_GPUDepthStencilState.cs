using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUDepthStencilState
    {
        public SDL_GPUCompareOp CompareOp
        {
            get => compare_op;
            set => compare_op = value;
        }

        public SDL_GPUStencilOpState BackStencilState
        {
            get => back_stencil_state;
            set => back_stencil_state = value;
        }

        public SDL_GPUStencilOpState FrontStencilState
        {
            get => front_stencil_state;
            set => front_stencil_state = value;
        }

        public byte CompareMask
        {
            get => compare_mask;
            set => compare_mask = value;
        }

        public byte WriteMask
        {
            get => write_mask;
            set => write_mask = value;
        }

        public bool EnableDepthTest
        {
            get => enable_depth_test;
            set => enable_depth_test = value;
        }

        public bool EnableDepthWrite
        {
            get => enable_depth_write;
            set => enable_depth_write = value;
        }

        public bool EnableStencilTest
        {
            get => enable_stencil_test;
            set => enable_stencil_test = value;
        }
    }
}