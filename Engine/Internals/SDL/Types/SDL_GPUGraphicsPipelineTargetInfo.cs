using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUGraphicsPipelineTargetInfo
    {
        private SDL_GPUColorTargetDescription* color_target_descriptions;

        private uint num_color_targets;

        private SDL_GPUTextureFormat depth_stencil_format;

        private SDL_Bool has_depth_stencil_target;

        private byte padding1;

        private byte padding2;

        private byte padding3;
    }
}