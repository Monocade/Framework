using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPURasterizerState
    {
        public SDL_GPUFillMode Fill_mode
        {
            get => fill_mode;
            set => fill_mode = value;
        }

        public SDL_GPUCullMode Cull_mode
        {
            get => cull_mode;
            set => cull_mode = value;
        }

        public SDL_GPUFrontFace Front_face
        {
            get => front_face;
            set => front_face = value;
        }

        public float Depth_bias_constant_factor
        {
            get => depth_bias_constant_factor;
            set => depth_bias_constant_factor = value;
        }

        public float Depth_bias_clamp
        {
            get => depth_bias_clamp;
            set => depth_bias_clamp = value;
        }

        public float Depth_bias_slope_factor
        {
            get => depth_bias_slope_factor;
            set => depth_bias_slope_factor = value;
        }

        public bool Enable_depth_bias
        {
            get => enable_depth_bias;
            set => enable_depth_bias = value;
        }

        public bool Enable_depth_clip
        {
            get => enable_depth_clip;
            set => enable_depth_clip = value;
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
    }
}