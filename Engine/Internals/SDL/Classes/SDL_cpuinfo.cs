using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_GetNumLogicalCPUCores()
        {
            return iSDL_GetNumLogicalCPUCores();
        }

        public static int SDL_GetCPUCacheLineSize()
        {
            return iSDL_GetCPUCacheLineSize();
        }

        public static bool SDL_HasAltiVec()
        {
            return iSDL_HasAltiVec();
        }

        public static bool SDL_HasMMX()
        {
            return iSDL_HasMMX();
        }

        public static bool SDL_HasSSE()
        {
            return iSDL_HasSSE();
        }

        public static bool SDL_HasSSE2()
        {
            return iSDL_HasSSE2();
        }

        public static bool SDL_HasSSE3()
        {
            return iSDL_HasSSE3();
        }

        public static bool SDL_HasSSE41()
        {
            return iSDL_HasSSE41();
        }

        public static bool SDL_HasSSE42()
        {
            return iSDL_HasSSE42();
        }

        public static bool SDL_HasAVX()
        {
            return iSDL_HasAVX();
        }

        public static bool SDL_HasAVX2()
        {
            return iSDL_HasAVX2();
        }

        public static bool SDL_HasAVX512F()
        {
            return iSDL_HasAVX512F();
        }

        public static bool SDL_HasARMSIMD()
        {
            return iSDL_HasARMSIMD();
        }

        public static bool SDL_HasNEON()
        {
            return iSDL_HasNEON();
        }

        public static bool SDL_HasSVE2()
        {
            return iSDL_HasSVE2();
        }

        public static bool SDL_HasLSX()
        {
            return iSDL_HasLSX();
        }

        public static bool SDL_HasLASX()
        {
            return iSDL_HasLASX();
        }

        public static int SDL_GetSystemRAM()
        {
            return iSDL_GetSystemRAM();
        }

        public static nuint SDL_GetSIMDAlignment()
        {
            return iSDL_GetSIMDAlignment();
        }

        public static int SDL_GetSystemPageSize()
        {
            return iSDL_GetSystemPageSize();
        }
    }
}