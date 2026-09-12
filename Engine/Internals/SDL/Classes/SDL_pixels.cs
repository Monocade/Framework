using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static string SDL_GetPixelFormatName(SDL_PixelFormat format)
        {
            return SDL_NativeToString(iSDL_GetPixelFormatName(format));
        }

        public static bool SDL_GetMasksForPixelFormat(SDL_PixelFormat format, out int bpp, out uint RMask, out uint GMask, out uint BMask, out uint AMask)
        {
            fixed (int* ptr1 = &bpp)
            fixed (uint* ptr2 = &RMask)
            fixed (uint* ptr3 = &GMask)
            fixed (uint* ptr4 = &BMask)
            fixed (uint* ptr5 = &AMask)
            {
                return iSDL_GetMasksForPixelFormat(format, ptr1, ptr2, ptr3, ptr4, ptr5);
            }
        }

        public static SDL_PixelFormat SDL_GetPixelFormatForMasks(int bpp, uint RMask, uint GMask, uint BMask, uint AMask)
        {
            return iSDL_GetPixelFormatForMasks(bpp, RMask, GMask, BMask, AMask);
        }

        public static SDL_PixelFormatDetails* SDL_GetPixelFormatDetails(SDL_PixelFormat format)
        {
            return iSDL_GetPixelFormatDetails(format);
        }

        public static SDL_Palette* SDL_CreatePalette(int numColors)
        {
            return iSDL_CreatePalette(numColors);
        }

        public static bool SDL_SetPaletteColors(SDL_Palette* palette, SDL_Color[] colors, int firstColor, int numColors)
        {
            fixed (SDL_Color* ptr1 = colors)
            {
                return iSDL_SetPaletteColors(palette, ptr1, firstColor, numColors);
            }
        }

        public static void SDL_DestroyPalette(SDL_Palette* palette)
        {
            iSDL_DestroyPalette(palette);
        }

        public static uint SDL_MapRGB(SDL_PixelFormatDetails* format, SDL_Palette* palette, byte r, byte g, byte b)
        {
            return iSDL_MapRGB(format, palette, r, g, b);
        }

        public static uint SDL_MapRGBA(SDL_PixelFormatDetails* format, SDL_Palette* palette, byte r, byte g, byte b, byte a)
        {
            return iSDL_MapRGBA(format, palette, r, g, b, a);
        }

        public static void SDL_GetRGB(uint pixelValue, SDL_PixelFormatDetails* format, SDL_Palette* palette, out byte r, out byte g, out byte b)
        {
            fixed (byte* ptr1 = &r)
            fixed (byte* ptr2 = &g)
            fixed (byte* ptr3 = &b)
            {
                iSDL_GetRGB(pixelValue, format, palette, ptr1, ptr2, ptr3);
            }
        }

        public static void SDL_GetRGBA(uint pixelValue, SDL_PixelFormatDetails* format, SDL_Palette* palette, out byte r, out byte g, out byte b, out byte a)
        {
            fixed (byte* ptr1 = &r)
            fixed (byte* ptr2 = &g)
            fixed (byte* ptr3 = &b)
            fixed (byte* ptr4 = &a)
            {
                iSDL_GetRGBA(pixelValue, format, palette, ptr1, ptr2, ptr3, ptr4);
            }
        }
    }
}