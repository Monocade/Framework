using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal unsafe partial struct SDL_GPUTextureRegion
    {
        public SDL_GPUTexture* Texture
        {
            get => texture;
            set => texture = value;
        }

        public uint Mip_level
        {
            get => mip_level;
            set => mip_level = value;
        }

        public uint Layer
        {
            get => layer;
            set => layer = value;
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

        public uint Z
        {
            get => z;
            set => z = value;
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

        public uint D
        {
            get => d;
            set => d = value;
        }
    }
}