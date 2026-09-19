using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTextureSamplerBinding
    {
        public SDL_GPUTexture* Texture
        {
            get => texture;
            set => texture = value;
        }

        public SDL_GPUSampler* Sampler
        {
            get => sampler;
            set => sampler = value;
        }
    }
}