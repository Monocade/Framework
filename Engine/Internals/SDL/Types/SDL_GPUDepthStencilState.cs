using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUDepthStencilState
    {
        public SDL_GPUCompareOp Compare_op
        {
            get => compare_op;
            set => compare_op = value;
        }

        public SDL_GPUStencilOpState Back_stencil_state
        {
            get => back_stencil_state;
            set => back_stencil_state = value;
        }

        public SDL_GPUStencilOpState Front_stencil_state
        {
            get => front_stencil_state;
            set => front_stencil_state = value;
        }

        public byte Compare_mask
        {
            get => compare_mask;
            set => compare_mask = value;
        }

        public byte Write_mask
        {
            get => write_mask;
            set => write_mask = value;
        }

        public SDL_Bool Enable_depth_test
        {
            get => enable_depth_test;
            set => enable_depth_test = value;
        }

        public SDL_Bool Enable_depth_write
        {
            get => enable_depth_write;
            set => enable_depth_write = value;
        }

        public SDL_Bool Enable_stencil_test
        {
            get => enable_stencil_test;
            set => enable_stencil_test = value;
        }

        public byte Padding1
        {
            get => padding1;
            set => padding1 = value;
        }

        public byte Padding2
        {
            get => padding2;
            set => padding2 = value;
        }

        public byte Padding3
        {
            get => padding3;
            set => padding3 = value;
        }
    }
}