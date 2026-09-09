using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUGraphicsPipelineTargetInfo
    {
        public SDL_GPUColorTargetDescription* Color_target_descriptions
        {
            get => color_target_descriptions;
            set => color_target_descriptions = value;
        }

        public uint Num_color_targets
        {
            get => num_color_targets;
            set => num_color_targets = value;
        }

        public SDL_GPUTextureFormat Depth_stencil_format
        {
            get => depth_stencil_format;
            set => depth_stencil_format = value;
        }

        public SDL_Bool Has_depth_stencil_target
        {
            get => has_depth_stencil_target;
            set => has_depth_stencil_target = value;
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