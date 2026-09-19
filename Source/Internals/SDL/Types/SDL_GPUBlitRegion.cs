using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUBlitRegion
    {
        public SDL_GPUTexture* Texture
        {
            get => texture;
            set => texture = value;
        }

        public uint MipLevel
        {
            get => mip_level;
            set => mip_level = value;
        }

        public uint LayerOrDepthPlane
        {
            get => layer_or_depth_plane;
            set => layer_or_depth_plane = value;
        }

        public uint X
        {
            get => x;
            set => x = value;
        }

        public uint Y
        {
            get => y;
            set => y = value;
        }

        public uint W
        {
            get => w;
            set => w = value;
        }

        public uint H
        {
            get => h;
            set => h = value;
        }
    }
}