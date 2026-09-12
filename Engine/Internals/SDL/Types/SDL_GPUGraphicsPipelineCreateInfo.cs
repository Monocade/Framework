using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUGraphicsPipelineCreateInfo
    {
        public SDL_GPUShader* VertexShader
        {
            get => vertex_shader;
            set => vertex_shader = value;
        }

        public SDL_GPUShader* FragmentShader
        {
            get => fragment_shader;
            set => fragment_shader = value;
        }

        public SDL_GPUVertexInputState VertexInputState
        {
            get => vertex_input_state;
            set => vertex_input_state = value;
        }

        public SDL_GPUPrimitiveType PrimitiveType
        {
            get => primitive_type;
            set => primitive_type = value;
        }

        public SDL_GPURasterizerState RasterizerState
        {
            get => rasterizer_state;
            set => rasterizer_state = value;
        }

        public SDL_GPUMultisampleState MultisampleState
        {
            get => multisample_state;
            set => multisample_state = value;
        }

        public SDL_GPUDepthStencilState DepthStencilState
        {
            get => depth_stencil_state;
            set => depth_stencil_state = value;
        }

        public SDL_GPUGraphicsPipelineTargetInfo TargetInfo
        {
            get => target_info;
            set => target_info = value;
        }

        public uint Props
        {
            get => props;
            set => props = value;
        }
    }
}