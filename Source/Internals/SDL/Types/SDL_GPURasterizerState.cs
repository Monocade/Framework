using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPURasterizerState
    {
        public SDL_GPUFillMode FillMode
        {
            get => fill_mode;
            set => fill_mode = value;
        }

        public SDL_GPUCullMode CullMode
        {
            get => cull_mode;
            set => cull_mode = value;
        }

        public SDL_GPUFrontFace FrontFace
        {
            get => front_face;
            set => front_face = value;
        }

        public float DepthBiasConstantFactor
        {
            get => depth_bias_constant_factor;
            set => depth_bias_constant_factor = value;
        }

        public float DepthBiasClamp
        {
            get => depth_bias_clamp;
            set => depth_bias_clamp = value;
        }

        public float DepthBiasSlopeFactor
        {
            get => depth_bias_slope_factor;
            set => depth_bias_slope_factor = value;
        }

        public bool EnableDepthBias
        {
            get => enable_depth_bias;
            set => enable_depth_bias = value;
        }

        public bool EnableDepthClip
        {
            get => enable_depth_clip;
            set => enable_depth_clip = value;
        }
    }
}