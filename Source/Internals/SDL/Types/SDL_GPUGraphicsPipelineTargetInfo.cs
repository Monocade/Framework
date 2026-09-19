using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUGraphicsPipelineTargetInfo
    {
        public SDL_GPUColorTargetDescription* ColorTargetDescriptions
        {
            get => color_target_descriptions;
            set => color_target_descriptions = value;
        }

        public uint NumColorTargets
        {
            get => num_color_targets;
            set => num_color_targets = value;
        }

        public SDL_GPUTextureFormat DepthStencilFormat
        {
            get => depth_stencil_format;
            set => depth_stencil_format = value;
        }

        public bool HasDepthStencilTarget
        {
            get => has_depth_stencil_target;
            set => has_depth_stencil_target = value;
        }
    }
}