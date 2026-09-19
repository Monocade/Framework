using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_BlendMode SDL_ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation)
        {
            return (SDL_BlendMode)iSDL_ComposeCustomBlendMode(srcColorFactor, dstColorFactor, colorOperation, srcAlphaFactor, dstAlphaFactor, alphaOperation);
        }
    }
}