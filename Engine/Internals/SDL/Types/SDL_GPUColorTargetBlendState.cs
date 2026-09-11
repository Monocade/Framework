using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUColorTargetBlendState
    {
        public SDL_GPUBlendFactor Src_color_blendfactor
        {
            get => src_color_blendfactor;
            set => src_color_blendfactor = value;
        }

        public SDL_GPUBlendFactor Dst_color_blendfactor
        {
            get => dst_color_blendfactor;
            set => dst_color_blendfactor = value;
        }

        public SDL_GPUBlendOp Color_blend_op
        {
            get => color_blend_op;
            set => color_blend_op = value;
        }

        public SDL_GPUBlendFactor Src_alpha_blendfactor
        {
            get => src_alpha_blendfactor;
            set => src_alpha_blendfactor = value;
        }

        public SDL_GPUBlendFactor Dst_alpha_blendfactor
        {
            get => dst_alpha_blendfactor;
            set => dst_alpha_blendfactor = value;
        }

        public SDL_GPUBlendOp Alpha_blend_op
        {
            get => alpha_blend_op;
            set => alpha_blend_op = value;
        }

        public SDL_GPUColorComponentFlags Color_write_mask
        {
            get => (SDL_GPUColorComponentFlags)color_write_mask;
            set => color_write_mask = (byte)value;
        }

        public bool Enable_blend
        {
            get => enable_blend;
            set => enable_blend = value;
        }

        public bool Enable_color_write_mask
        {
            get => enable_color_write_mask;
            set => enable_color_write_mask = value;
        }
    }
}