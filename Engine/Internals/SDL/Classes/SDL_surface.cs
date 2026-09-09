using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_Surface* SDL_CreateSurface(int width, int height, SDL_PixelFormat format)
        {
            return iSDL_CreateSurface(width, height, format);
        }

        public static SDL_Surface* SDL_CreateSurfaceFrom(int width, int height, SDL_PixelFormat format, IntPtr pixels, int pitch)
        {
            return iSDL_CreateSurfaceFrom(width, height, format, pixels, pitch);
        }

        public static void SDL_DestroySurface(SDL_Surface* surface)
        {
            iSDL_DestroySurface(surface);
        }

        public static uint SDL_GetSurfaceProperties(SDL_Surface* surface)
        {
            return iSDL_GetSurfaceProperties(surface);
        }

        public static bool SDL_SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace)
        {
            return iSDL_SetSurfaceColorspace(surface, colorspace);
        }

        public static SDL_Colorspace SDL_GetSurfaceColorspace(SDL_Surface* surface)
        {
            return iSDL_GetSurfaceColorspace(surface);
        }

        public static SDL_Palette* SDL_CreateSurfacePalette(SDL_Surface* surface)
        {
            return iSDL_CreateSurfacePalette(surface);
        }

        public static bool SDL_SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette)
        {
            return iSDL_SetSurfacePalette(surface, palette);
        }

        public static SDL_Palette* SDL_GetSurfacePalette(SDL_Surface* surface)
        {
            return iSDL_GetSurfacePalette(surface);
        }

        public static bool SDL_AddSurfaceAlternateImage(SDL_Surface* surface, SDL_Surface* image)
        {
            return iSDL_AddSurfaceAlternateImage(surface, image);
        }

        public static bool SDL_SurfaceHasAlternateImages(SDL_Surface* surface)
        {
            return iSDL_SurfaceHasAlternateImages(surface);
        }

        public static SDL_Surface*[] SDL_GetSurfaceImages(SDL_Surface* surface, out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetSurfaceImages(surface, &size), size, out count);
            }
        }

        public static void SDL_RemoveSurfaceAlternateImages(SDL_Surface* surface)
        {
            iSDL_RemoveSurfaceAlternateImages(surface);
        }

        public static bool SDL_LockSurface(SDL_Surface* surface)
        {
            return iSDL_LockSurface(surface);
        }

        public static void SDL_UnlockSurface(SDL_Surface* surface)
        {
            iSDL_UnlockSurface(surface);
        }

        public static SDL_Surface* SDL_LoadSurface_IO(SDL_IOStream* src, bool closeio)
        {
            return iSDL_LoadSurface_IO(src, closeio);
        }

        public static SDL_Surface* SDL_LoadSurface(string file)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_LoadSurface(ptr1);
            }
        }

        public static SDL_Surface* SDL_LoadBMP_IO(SDL_IOStream* src, bool closeio)
        {
            return iSDL_LoadBMP_IO(src, closeio);
        }

        public static SDL_Surface* SDL_LoadBMP(string file)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_LoadBMP(ptr1);
            }
        }

        public static bool SDL_SaveBMP_IO(SDL_Surface* surface, SDL_IOStream* dst, bool closeio)
        {
            return iSDL_SaveBMP_IO(surface, dst, closeio);
        }

        public static bool SDL_SaveBMP(SDL_Surface* surface, string file)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_SaveBMP(surface, ptr1);
            }
        }

        public static SDL_Surface* SDL_LoadPNG_IO(SDL_IOStream* src, bool closeio)
        {
            return iSDL_LoadPNG_IO(src, closeio);
        }

        public static SDL_Surface* SDL_LoadPNG(string file)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_LoadPNG(ptr1);
            }
        }

        public static bool SDL_SavePNG_IO(SDL_Surface* surface, SDL_IOStream* dst, bool closeio)
        {
            return iSDL_SavePNG_IO(surface, dst, closeio);
        }

        public static bool SDL_SavePNG(SDL_Surface* surface, string file)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_SavePNG(surface, ptr1);
            }
        }

        public static SDL_Surface* SDL_LoadJPG_IO(SDL_IOStream* src, bool closeio)
        {
            return iSDL_LoadJPG_IO(src, closeio);
        }

        public static SDL_Surface* SDL_LoadJPG(string file)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_LoadJPG(ptr1);
            }
        }

        public static bool SDL_SetSurfaceRLE(SDL_Surface* surface, bool enabled)
        {
            return iSDL_SetSurfaceRLE(surface, enabled);
        }

        public static bool SDL_SurfaceHasRLE(SDL_Surface* surface)
        {
            return iSDL_SurfaceHasRLE(surface);
        }

        public static bool SDL_SetSurfaceColorKey(SDL_Surface* surface, bool enabled, uint key)
        {
            return iSDL_SetSurfaceColorKey(surface, enabled, key);
        }

        public static bool SDL_SurfaceHasColorKey(SDL_Surface* surface)
        {
            return iSDL_SurfaceHasColorKey(surface);
        }

        public static bool SDL_GetSurfaceColorKey(SDL_Surface* surface, out uint key)
        {
            fixed (uint* ptr1 = &key)
            {
                return iSDL_GetSurfaceColorKey(surface, ptr1);
            }
        }

        public static bool SDL_SetSurfaceColorMod(SDL_Surface* surface, byte r, byte g, byte b)
        {
            return iSDL_SetSurfaceColorMod(surface, r, g, b);
        }

        public static bool SDL_GetSurfaceColorMod(SDL_Surface* surface, out byte r, out byte g, out byte b)
        {
            fixed (byte* ptr1 = &r)
            fixed (byte* ptr2 = &g)
            fixed (byte* ptr3 = &b)
            {
                return iSDL_GetSurfaceColorMod(surface, ptr1, ptr2, ptr3);
            }
        }

        public static bool SDL_SetSurfaceAlphaMod(SDL_Surface* surface, byte alpha)
        {
            return iSDL_SetSurfaceAlphaMod(surface, alpha);
        }

        public static bool SDL_GetSurfaceAlphaMod(SDL_Surface* surface, out byte alpha)
        {
            fixed (byte* ptr1 = &alpha)
            {
                return iSDL_GetSurfaceAlphaMod(surface, ptr1);
            }
        }

        public static bool SDL_SetSurfaceBlendMode(SDL_Surface* surface, uint blendMode)
        {
            return iSDL_SetSurfaceBlendMode(surface, blendMode);
        }

        public static bool SDL_GetSurfaceBlendMode(SDL_Surface* surface, out uint blendMode)
        {
            fixed (uint* ptr1 = &blendMode)
            {
                return iSDL_GetSurfaceBlendMode(surface, ptr1);
            }
        }

        public static bool SDL_SetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect)
        {
            return iSDL_SetSurfaceClipRect(surface, rect);
        }

        public static bool SDL_GetSurfaceClipRect(SDL_Surface* surface, out SDL_Rect rect)
        {
            fixed (SDL_Rect* ptr1 = &rect)
            {
                return iSDL_GetSurfaceClipRect(surface, ptr1);
            }
        }

        public static bool SDL_FlipSurface(SDL_Surface* surface, SDL_FlipMode flip)
        {
            return iSDL_FlipSurface(surface, flip);
        }

        public static SDL_Surface* SDL_RotateSurface(SDL_Surface* surface, float angle)
        {
            return iSDL_RotateSurface(surface, angle);
        }

        public static SDL_Surface* SDL_DuplicateSurface(SDL_Surface* surface)
        {
            return iSDL_DuplicateSurface(surface);
        }

        public static SDL_Surface* SDL_ScaleSurface(SDL_Surface* surface, int width, int height, SDL_ScaleMode scaleMode)
        {
            return iSDL_ScaleSurface(surface, width, height, scaleMode);
        }

        public static SDL_Surface* SDL_ConvertSurface(SDL_Surface* surface, SDL_PixelFormat format)
        {
            return iSDL_ConvertSurface(surface, format);
        }

        public static SDL_Surface* SDL_ConvertSurfaceAndColorspace(SDL_Surface* surface, SDL_PixelFormat format, SDL_Palette* palette, SDL_Colorspace colorspace, uint props)
        {
            return iSDL_ConvertSurfaceAndColorspace(surface, format, palette, colorspace, props);
        }

        public static bool SDL_ConvertPixels(int width, int height, SDL_PixelFormat src_format, IntPtr src, int src_pitch, SDL_PixelFormat dst_format, IntPtr dst, int dst_pitch)
        {
            return iSDL_ConvertPixels(width, height, src_format, src, src_pitch, dst_format, dst, dst_pitch);
        }

        public static bool SDL_ConvertPixelsAndColorspace(int width, int height, SDL_PixelFormat src_format, SDL_Colorspace src_colorspace, uint src_properties, IntPtr src, int src_pitch, SDL_PixelFormat dst_format, SDL_Colorspace dst_colorspace, uint dst_properties, IntPtr dst, int dst_pitch)
        {
            return iSDL_ConvertPixelsAndColorspace(width, height, src_format, src_colorspace, src_properties, src, src_pitch, dst_format, dst_colorspace, dst_properties, dst, dst_pitch);
        }

        public static bool SDL_PremultiplyAlpha(int width, int height, SDL_PixelFormat src_format, IntPtr src, int src_pitch, SDL_PixelFormat dst_format, IntPtr dst, int dst_pitch, bool linear)
        {
            return iSDL_PremultiplyAlpha(width, height, src_format, src, src_pitch, dst_format, dst, dst_pitch, linear);
        }

        public static bool SDL_PremultiplySurfaceAlpha(SDL_Surface* surface, bool linear)
        {
            return iSDL_PremultiplySurfaceAlpha(surface, linear);
        }

        public static bool SDL_ClearSurface(SDL_Surface* surface, float r, float g, float b, float a)
        {
            return iSDL_ClearSurface(surface, r, g, b, a);
        }

        public static bool SDL_FillSurfaceRect(SDL_Surface* dst, SDL_Rect* rect, uint color)
        {
            return iSDL_FillSurfaceRect(dst, rect, color);
        }

        public static bool SDL_FillSurfaceRects(SDL_Surface* dst, SDL_Rect[] rects, int count, uint color)
        {
            fixed (SDL_Rect* ptr1 = rects)
            {
                return iSDL_FillSurfaceRects(dst, ptr1, count, color);
            }
        }

        public static bool SDL_BlitSurface(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect)
        {
            return iSDL_BlitSurface(src, srcrect, dst, dstrect);
        }

        public static bool SDL_BlitSurfaceUnchecked(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect)
        {
            return iSDL_BlitSurfaceUnchecked(src, srcrect, dst, dstrect);
        }

        public static bool SDL_BlitSurfaceScaled(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect, SDL_ScaleMode scaleMode)
        {
            return iSDL_BlitSurfaceScaled(src, srcrect, dst, dstrect, scaleMode);
        }

        public static bool SDL_BlitSurfaceUncheckedScaled(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect, SDL_ScaleMode scaleMode)
        {
            return iSDL_BlitSurfaceUncheckedScaled(src, srcrect, dst, dstrect, scaleMode);
        }

        public static bool SDL_StretchSurface(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect, SDL_ScaleMode scaleMode)
        {
            return iSDL_StretchSurface(src, srcrect, dst, dstrect, scaleMode);
        }

        public static bool SDL_BlitSurfaceTiled(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect)
        {
            return iSDL_BlitSurfaceTiled(src, srcrect, dst, dstrect);
        }

        public static bool SDL_BlitSurfaceTiledWithScale(SDL_Surface* src, SDL_Rect* srcrect, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, SDL_Rect* dstrect)
        {
            return iSDL_BlitSurfaceTiledWithScale(src, srcrect, scale, scaleMode, dst, dstrect);
        }

        public static bool SDL_BlitSurface9Grid(SDL_Surface* src, SDL_Rect* srcrect, int left_width, int right_width, int top_height, int bottom_height, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, SDL_Rect* dstrect)
        {
            return iSDL_BlitSurface9Grid(src, srcrect, left_width, right_width, top_height, bottom_height, scale, scaleMode, dst, dstrect);
        }

        public static uint SDL_MapSurfaceRGB(SDL_Surface* surface, byte r, byte g, byte b)
        {
            return iSDL_MapSurfaceRGB(surface, r, g, b);
        }

        public static uint SDL_MapSurfaceRGBA(SDL_Surface* surface, byte r, byte g, byte b, byte a)
        {
            return iSDL_MapSurfaceRGBA(surface, r, g, b, a);
        }

        public static bool SDL_ReadSurfacePixel(SDL_Surface* surface, int x, int y, out byte r, out byte g, out byte b, out byte a)
        {
            fixed (byte* ptr1 = &r)
            fixed (byte* ptr2 = &g)
            fixed (byte* ptr3 = &b)
            fixed (byte* ptr4 = &a)
            {
                return iSDL_ReadSurfacePixel(surface, x, y, ptr1, ptr2, ptr3, ptr4);
            }
        }

        public static bool SDL_ReadSurfacePixelFloat(SDL_Surface* surface, int x, int y, out float r, out float g, out float b, out float a)
        {
            fixed (float* ptr1 = &r)
            fixed (float* ptr2 = &g)
            fixed (float* ptr3 = &b)
            fixed (float* ptr4 = &a)
            {
                return iSDL_ReadSurfacePixelFloat(surface, x, y, ptr1, ptr2, ptr3, ptr4);
            }
        }

        public static bool SDL_WriteSurfacePixel(SDL_Surface* surface, int x, int y, byte r, byte g, byte b, byte a)
        {
            return iSDL_WriteSurfacePixel(surface, x, y, r, g, b, a);
        }

        public static bool SDL_WriteSurfacePixelFloat(SDL_Surface* surface, int x, int y, float r, float g, float b, float a)
        {
            return iSDL_WriteSurfacePixelFloat(surface, x, y, r, g, b, a);
        }
    }
}