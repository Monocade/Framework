using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUColorTargetBlendState
    {
        public SDL_GPUBlendFactor SrcColorBlendfactor
        {
            get => src_color_blendfactor;
            set => src_color_blendfactor = value;
        }

        public SDL_GPUBlendFactor DstColorBlendfactor
        {
            get => dst_color_blendfactor;
            set => dst_color_blendfactor = value;
        }

        public SDL_GPUBlendOp ColorBlendOp
        {
            get => color_blend_op;
            set => color_blend_op = value;
        }

        public SDL_GPUBlendFactor SrcAlphaBlendfactor
        {
            get => src_alpha_blendfactor;
            set => src_alpha_blendfactor = value;
        }

        public SDL_GPUBlendFactor DstAlphaBlendfactor
        {
            get => dst_alpha_blendfactor;
            set => dst_alpha_blendfactor = value;
        }

        public SDL_GPUBlendOp AlphaBlendOp
        {
            get => alpha_blend_op;
            set => alpha_blend_op = value;
        }

        public SDL_GPUColorComponentFlags ColorWriteMask
        {
            get => (SDL_GPUColorComponentFlags)color_write_mask;
            set => color_write_mask = (byte)value;
        }

        public bool EnableBlend
        {
            get => enable_blend;
            set => enable_blend = value;
        }

        public bool Enable_colorWriteMask
        {
            get => enable_color_write_mask;
            set => enable_color_write_mask = value;
        }
    }
}