using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPURasterizerState
    {
        private SDL_GPUFillMode fill_mode;

        private SDL_GPUCullMode cull_mode;

        private SDL_GPUFrontFace front_face;

        private float depth_bias_constant_factor;

        private float depth_bias_clamp;

        private float depth_bias_slope_factor;

        private SDL_Bool enable_depth_bias;

        private SDL_Bool enable_depth_clip;

        private byte padding1;

        private byte padding2;
    }
}