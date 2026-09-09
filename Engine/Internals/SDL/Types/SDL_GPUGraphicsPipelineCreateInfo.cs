using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUGraphicsPipelineCreateInfo
    {
        private SDL_GPUShader* vertex_shader;

        private SDL_GPUShader* fragment_shader;

        private SDL_GPUVertexInputState vertex_input_state;

        private SDL_GPUPrimitiveType primitive_type;

        private SDL_GPURasterizerState rasterizer_state;

        private SDL_GPUMultisampleState multisample_state;

        private SDL_GPUDepthStencilState depth_stencil_state;

        private SDL_GPUGraphicsPipelineTargetInfo target_info;

        private uint props;
    }
}