using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUGraphicsPipelineCreateInfo
    {
        public SDL_GPUShader* Vertex_shader
        {
            get => vertex_shader;
            set => vertex_shader = value;
        }

        public SDL_GPUShader* Fragment_shader
        {
            get => fragment_shader;
            set => fragment_shader = value;
        }

        public SDL_GPUVertexInputState Vertex_input_state
        {
            get => vertex_input_state;
            set => vertex_input_state = value;
        }

        public SDL_GPUPrimitiveType Primitive_type
        {
            get => primitive_type;
            set => primitive_type = value;
        }

        public SDL_GPURasterizerState Rasterizer_state
        {
            get => rasterizer_state;
            set => rasterizer_state = value;
        }

        public SDL_GPUMultisampleState Multisample_state
        {
            get => multisample_state;
            set => multisample_state = value;
        }

        public SDL_GPUDepthStencilState Depth_stencil_state
        {
            get => depth_stencil_state;
            set => depth_stencil_state = value;
        }

        public SDL_GPUGraphicsPipelineTargetInfo Target_info
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