using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_GetNumRenderDrivers()
        {
            return iSDL_GetNumRenderDrivers();
        }

        public static string SDL_GetRenderDriver(int index)
        {
            return SDL_NativeToString(iSDL_GetRenderDriver(index));
        }

        public static bool SDL_CreateWindowAndRenderer(string title, int width, int height, ulong window_flags, out SDL_Window* window, out SDL_Renderer* renderer)
        {
            fixed (byte* ptr1 = SDL_StringToNative(title))
            {
                SDL_Window* ptr2 = null;
                SDL_Renderer* ptr3 = null;
                
                var result = iSDL_CreateWindowAndRenderer(ptr1, width, height, window_flags, &ptr2, &ptr3);
                window = ptr2;
                renderer = ptr3;
                
                return result;
            }
        }

        public static SDL_Renderer* SDL_CreateRenderer(SDL_Window* window, string name)
        {
            fixed (byte* ptr1 = SDL_StringToNative(name))
            {
                return iSDL_CreateRenderer(window, ptr1);
            }
        }

        public static SDL_Renderer* SDL_CreateRendererWithProperties(uint props)
        {
            return iSDL_CreateRendererWithProperties(props);
        }

        public static SDL_Renderer* SDL_CreateGPURenderer(SDL_GPUDevice* device, SDL_Window* window)
        {
            return iSDL_CreateGPURenderer(device, window);
        }

        public static SDL_GPUDevice* SDL_GetGPURendererDevice(SDL_Renderer* renderer)
        {
            return iSDL_GetGPURendererDevice(renderer);
        }

        public static SDL_Renderer* SDL_CreateSoftwareRenderer(SDL_Surface* surface)
        {
            return iSDL_CreateSoftwareRenderer(surface);
        }

        public static SDL_Renderer* SDL_GetRenderer(SDL_Window* window)
        {
            return iSDL_GetRenderer(window);
        }

        public static SDL_Window* SDL_GetRenderWindow(SDL_Renderer* renderer)
        {
            return iSDL_GetRenderWindow(renderer);
        }

        public static string SDL_GetRendererName(SDL_Renderer* renderer)
        {
            return SDL_NativeToString(iSDL_GetRendererName(renderer));
        }

        public static uint SDL_GetRendererProperties(SDL_Renderer* renderer)
        {
            return iSDL_GetRendererProperties(renderer);
        }

        public static bool SDL_GetRenderOutputSize(SDL_Renderer* renderer, out int w, out int h)
        {
            fixed (int* ptr1 = &w)
            fixed (int* ptr2 = &h)
            {
                return iSDL_GetRenderOutputSize(renderer, ptr1, ptr2);
            }
        }

        public static bool SDL_GetCurrentRenderOutputSize(SDL_Renderer* renderer, out int w, out int h)
        {
            fixed (int* ptr1 = &w)
            fixed (int* ptr2 = &h)
            {
                return iSDL_GetCurrentRenderOutputSize(renderer, ptr1, ptr2);
            }
        }

        public static SDL_Texture* SDL_CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int w, int h)
        {
            return iSDL_CreateTexture(renderer, format, access, w, h);
        }

        public static SDL_Texture* SDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface)
        {
            return iSDL_CreateTextureFromSurface(renderer, surface);
        }

        public static SDL_Texture* SDL_CreateTextureWithProperties(SDL_Renderer* renderer, uint props)
        {
            return iSDL_CreateTextureWithProperties(renderer, props);
        }

        public static uint SDL_GetTextureProperties(SDL_Texture* texture)
        {
            return iSDL_GetTextureProperties(texture);
        }

        public static SDL_Renderer* SDL_GetRendererFromTexture(SDL_Texture* texture)
        {
            return iSDL_GetRendererFromTexture(texture);
        }

        public static bool SDL_GetTextureSize(SDL_Texture* texture, out float w, out float h)
        {
            fixed (float* ptr1 = &w)
            fixed (float* ptr2 = &h)
            {
                return iSDL_GetTextureSize(texture, ptr1, ptr2);
            }
        }

        public static bool SDL_SetTexturePalette(SDL_Texture* texture, SDL_Palette* palette)
        {
            return iSDL_SetTexturePalette(texture, palette);
        }

        public static SDL_Palette* SDL_GetTexturePalette(SDL_Texture* texture)
        {
            return iSDL_GetTexturePalette(texture);
        }

        public static bool SDL_SetTextureColorMod(SDL_Texture* texture, byte r, byte g, byte b)
        {
            return iSDL_SetTextureColorMod(texture, r, g, b);
        }

        public static bool SDL_SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b)
        {
            return iSDL_SetTextureColorModFloat(texture, r, g, b);
        }

        public static bool SDL_GetTextureColorMod(SDL_Texture* texture, out byte r, out byte g, out byte b)
        {
            fixed (byte* ptr1 = &r)
            fixed (byte* ptr2 = &g)
            fixed (byte* ptr3 = &b)
            {
                return iSDL_GetTextureColorMod(texture, ptr1, ptr2, ptr3);
            }
        }

        public static bool SDL_GetTextureColorModFloat(SDL_Texture* texture, out float r, out float g, out float b)
        {
            fixed (float* ptr1 = &r)
            fixed (float* ptr2 = &g)
            fixed (float* ptr3 = &b)
            {
                return iSDL_GetTextureColorModFloat(texture, ptr1, ptr2, ptr3);
            }
        }

        public static bool SDL_SetTextureAlphaMod(SDL_Texture* texture, byte alpha)
        {
            return iSDL_SetTextureAlphaMod(texture, alpha);
        }

        public static bool SDL_SetTextureAlphaModFloat(SDL_Texture* texture, float alpha)
        {
            return iSDL_SetTextureAlphaModFloat(texture, alpha);
        }

        public static bool SDL_GetTextureAlphaMod(SDL_Texture* texture, out byte alpha)
        {
            fixed (byte* ptr1 = &alpha)
            {
                return iSDL_GetTextureAlphaMod(texture, ptr1);
            }
        }

        public static bool SDL_GetTextureAlphaModFloat(SDL_Texture* texture, out float alpha)
        {
            fixed (float* ptr1 = &alpha)
            {
                return iSDL_GetTextureAlphaModFloat(texture, ptr1);
            }
        }

        public static bool SDL_SetTextureBlendMode(SDL_Texture* texture, uint blendMode)
        {
            return iSDL_SetTextureBlendMode(texture, blendMode);
        }

        public static bool SDL_GetTextureBlendMode(SDL_Texture* texture, out uint blendMode)
        {
            fixed (uint* ptr1 = &blendMode)
            {
                return iSDL_GetTextureBlendMode(texture, ptr1);
            }
        }

        public static bool SDL_SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode)
        {
            return iSDL_SetTextureScaleMode(texture, scaleMode);
        }

        public static bool SDL_GetTextureScaleMode(SDL_Texture* texture, out SDL_ScaleMode scaleMode)
        {
            fixed (SDL_ScaleMode* ptr1 = &scaleMode)
            {
                return iSDL_GetTextureScaleMode(texture, ptr1);
            }
        }

        public static bool SDL_UpdateTexture(SDL_Texture* texture, SDL_Rect* rect, IntPtr pixels, int pitch)
        {
            return iSDL_UpdateTexture(texture, rect, pixels, pitch);
        }

        public static bool SDL_UpdateYUVTexture(SDL_Texture* texture, SDL_Rect* rect, IntPtr Yplane, int Ypitch, IntPtr Uplane, int Upitch, IntPtr Vplane, int Vpitch)
        {
            return iSDL_UpdateYUVTexture(texture, rect, (byte*)Yplane, Ypitch, (byte*)Uplane, Upitch, (byte*)Vplane, Vpitch);
        }

        public static bool SDL_UpdateNVTexture(SDL_Texture* texture, SDL_Rect* rect, IntPtr Yplane, int Ypitch, IntPtr UVplane, int UVpitch)
        {
            return iSDL_UpdateNVTexture(texture, rect, (byte*)Yplane, Ypitch, (byte*)UVplane, UVpitch);
        }

        public static bool SDL_LockTexture(SDL_Texture* texture, SDL_Rect* rect, out IntPtr pixels, out int pitch)
        {
            fixed (IntPtr* ptr1 = &pixels)
            fixed (int* ptr2 = &pitch)
            {
                return iSDL_LockTexture(texture, rect, ptr1, ptr2);
            }
        }

        public static bool SDL_LockTextureToSurface(SDL_Texture* texture, SDL_Rect* rect, out SDL_Surface* surface)
        {
            SDL_Surface* ptr1;
            var result = iSDL_LockTextureToSurface(texture, rect, &ptr1);
            surface = ptr1;
            return result;
        }

        public static void SDL_UnlockTexture(SDL_Texture* texture)
        {
            iSDL_UnlockTexture(texture);
        }

        public static bool SDL_SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture)
        {
            return iSDL_SetRenderTarget(renderer, texture);
        }

        public static SDL_Texture* SDL_GetRenderTarget(SDL_Renderer* renderer)
        {
            return iSDL_GetRenderTarget(renderer);
        }

        public static bool SDL_SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode)
        {
            return iSDL_SetRenderLogicalPresentation(renderer, w, h, mode);
        }

        public static bool SDL_GetRenderLogicalPresentation(SDL_Renderer* renderer, out int w, out int h, out SDL_RendererLogicalPresentation mode)
        {
            fixed (int* ptr1 = &w)
            fixed (int* ptr2 = &h)
            fixed (SDL_RendererLogicalPresentation* ptr3 = &mode)
            {
                return iSDL_GetRenderLogicalPresentation(renderer, ptr1, ptr2, ptr3);
            }
        }

        public static bool SDL_GetRenderLogicalPresentationRect(SDL_Renderer* renderer, out SDL_FRect rect)
        {
            fixed (SDL_FRect* ptr1 = &rect)
            {
                return iSDL_GetRenderLogicalPresentationRect(renderer, ptr1);
            }
        }

        public static bool SDL_RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, out float x, out float y)
        {
            fixed (float* ptr1 = &x)
            fixed (float* ptr2 = &y)
            {
                return iSDL_RenderCoordinatesFromWindow(renderer, window_x, window_y, ptr1, ptr2);
            }
        }

        public static bool SDL_RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, out float window_x, out float window_y)
        {
            fixed (float* ptr1 = &window_x)
            fixed (float* ptr2 = &window_y)
            {
                return iSDL_RenderCoordinatesToWindow(renderer, x, y, ptr1, ptr2);
            }
        }

        public static bool SDL_ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event)
        {
            return iSDL_ConvertEventToRenderCoordinates(renderer, @event);
        }

        public static bool SDL_SetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_SetRenderViewport(renderer, rect);
        }

        public static bool SDL_GetRenderViewport(SDL_Renderer* renderer, out SDL_Rect rect)
        {
            fixed (SDL_Rect* ptr1 = &rect)
            {
                return iSDL_GetRenderViewport(renderer, ptr1);
            }
        }

        public static bool SDL_RenderViewportSet(SDL_Renderer* renderer)
        {
            return iSDL_RenderViewportSet(renderer);
        }

        public static bool SDL_GetRenderSafeArea(SDL_Renderer* renderer, out SDL_Rect rect)
        {
            fixed (SDL_Rect* ptr1 = &rect)
            {
                return iSDL_GetRenderSafeArea(renderer, ptr1);
            }
        }

        public static bool SDL_SetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_SetRenderClipRect(renderer, rect);
        }

        public static bool SDL_GetRenderClipRect(SDL_Renderer* renderer, out SDL_Rect rect)
        {
            fixed (SDL_Rect* ptr1 = &rect)
            {
                return iSDL_GetRenderClipRect(renderer, ptr1);
            }
        }

        public static bool SDL_RenderClipEnabled(SDL_Renderer* renderer)
        {
            return iSDL_RenderClipEnabled(renderer);
        }

        public static bool SDL_SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY)
        {
            return iSDL_SetRenderScale(renderer, scaleX, scaleY);
        }

        public static bool SDL_GetRenderScale(SDL_Renderer* renderer, out float scaleX, out float scaleY)
        {
            fixed (float* ptr1 = &scaleX)
            fixed (float* ptr2 = &scaleY)
            {
                return iSDL_GetRenderScale(renderer, ptr1, ptr2);
            }
        }

        public static bool SDL_SetRenderDrawColor(SDL_Renderer* renderer, byte r, byte g, byte b, byte a)
        {
            return iSDL_SetRenderDrawColor(renderer, r, g, b, a);
        }

        public static bool SDL_SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a)
        {
            return iSDL_SetRenderDrawColorFloat(renderer, r, g, b, a);
        }

        public static bool SDL_GetRenderDrawColor(SDL_Renderer* renderer, out byte r, out byte g, out byte b, out byte a)
        {
            fixed (byte* ptr1 = &r)
            fixed (byte* ptr2 = &g)
            fixed (byte* ptr3 = &b)
            fixed (byte* ptr4 = &a)
            {
                return iSDL_GetRenderDrawColor(renderer, ptr1, ptr2, ptr3, ptr4);
            }
        }

        public static bool SDL_GetRenderDrawColorFloat(SDL_Renderer* renderer, out float r, out float g, out float b, out float a)
        {
            fixed (float* ptr1 = &r)
            fixed (float* ptr2 = &g)
            fixed (float* ptr3 = &b)
            fixed (float* ptr4 = &a)
            {
                return iSDL_GetRenderDrawColorFloat(renderer, ptr1, ptr2, ptr3, ptr4);
            }
        }

        public static bool SDL_SetRenderColorScale(SDL_Renderer* renderer, float scale)
        {
            return iSDL_SetRenderColorScale(renderer, scale);
        }

        public static bool SDL_GetRenderColorScale(SDL_Renderer* renderer, out float scale)
        {
            fixed (float* ptr1 = &scale)
            {
                return iSDL_GetRenderColorScale(renderer, ptr1);
            }
        }

        public static bool SDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, uint blendMode)
        {
            return iSDL_SetRenderDrawBlendMode(renderer, blendMode);
        }

        public static bool SDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, out uint blendMode)
        {
            fixed (uint* ptr1 = &blendMode)
            {
                return iSDL_GetRenderDrawBlendMode(renderer, ptr1);
            }
        }

        public static bool SDL_RenderClear(SDL_Renderer* renderer)
        {
            return iSDL_RenderClear(renderer);
        }

        public static bool SDL_RenderPoint(SDL_Renderer* renderer, float x, float y)
        {
            return iSDL_RenderPoint(renderer, x, y);
        }

        public static bool SDL_RenderPoints(SDL_Renderer* renderer, SDL_FPoint[] points, int count)
        {
            fixed (SDL_FPoint* ptr1 = points)
            {
                return iSDL_RenderPoints(renderer, ptr1, count);
            }
        }

        public static bool SDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2)
        {
            return iSDL_RenderLine(renderer, x1, y1, x2, y2);
        }

        public static bool SDL_RenderLines(SDL_Renderer* renderer, SDL_FPoint[] points, int count)
        {
            fixed (SDL_FPoint* ptr1 = points)
            {
                return iSDL_RenderLines(renderer, ptr1, count);
            }
        }

        public static bool SDL_RenderRect(SDL_Renderer* renderer, SDL_FRect* rect)
        {
            return iSDL_RenderRect(renderer, rect);
        }

        public static bool SDL_RenderRects(SDL_Renderer* renderer, SDL_FRect[] rects, int count)
        {
            fixed (SDL_FRect* ptr1 = rects)
            {
                return iSDL_RenderRects(renderer, ptr1, count);
            }
        }

        public static bool SDL_RenderFillRect(SDL_Renderer* renderer, SDL_FRect* rect)
        {
            return iSDL_RenderFillRect(renderer, rect);
        }

        public static bool SDL_RenderFillRects(SDL_Renderer* renderer, SDL_FRect[] rects, int count)
        {
            fixed (SDL_FRect* ptr1 = rects)
            {
                return iSDL_RenderFillRects(renderer, ptr1, count);
            }
        }

        public static bool SDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FRect* dstrect)
        {
            return iSDL_RenderTexture(renderer, texture, srcrect, dstrect);
        }

        public static bool SDL_RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FRect* dstrect, double angle, SDL_FPoint* center, SDL_FlipMode flip)
        {
            return iSDL_RenderTextureRotated(renderer, texture, srcrect, dstrect, angle, center, flip);
        }

        public static bool SDL_RenderTextureAffine(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FPoint* origin, SDL_FPoint* right, SDL_FPoint* down)
        {
            return iSDL_RenderTextureAffine(renderer, texture, srcrect, origin, right, down);
        }

        public static bool SDL_RenderTextureTiled(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float scale, SDL_FRect* dstrect)
        {
            return iSDL_RenderTextureTiled(renderer, texture, srcrect, scale, dstrect);
        }

        public static bool SDL_RenderTexture9Grid(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, SDL_FRect* dstrect)
        {
            return iSDL_RenderTexture9Grid(renderer, texture, srcrect, left_width, right_width, top_height, bottom_height, scale, dstrect);
        }

        public static bool SDL_RenderTexture9GridTiled(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, SDL_FRect* dstrect, float tileScale)
        {
            return iSDL_RenderTexture9GridTiled(renderer, texture, srcrect, left_width, right_width, top_height, bottom_height, scale, dstrect, tileScale);
        }

        public static bool SDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Vertex[] vertices, int num_vertices, int[] indices, int num_indices)
        {
            fixed (SDL_Vertex* ptr1 = vertices)
            fixed (int* ptr2 = indices)
            {
                return iSDL_RenderGeometry(renderer, texture, ptr1, num_vertices, ptr2, num_indices);
            }
        }

        public static bool SDL_RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, float[] positions, int position_stride, SDL_FColor[] colors, int color_stride, float[] uvs, int uv_stride, int num_vertices, int[] indices, int num_indices)
        {
            fixed (float* ptr1 = positions)
            fixed (SDL_FColor* ptr2 = colors)
            fixed (float* ptr3 = uvs)
            fixed (int* ptr4 = indices)
            {
                return iSDL_RenderGeometryRaw(renderer, texture, ptr1, position_stride, ptr2, color_stride, ptr3, uv_stride, num_vertices, (IntPtr)ptr4, num_indices, sizeof(int));
            }
        }

        public static bool SDL_SetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode u_mode, SDL_TextureAddressMode v_mode)
        {
            return iSDL_SetRenderTextureAddressMode(renderer, u_mode, v_mode);
        }

        public static bool SDL_GetRenderTextureAddressMode(SDL_Renderer* renderer, out SDL_TextureAddressMode u_mode, out SDL_TextureAddressMode v_mode)
        {
            fixed (SDL_TextureAddressMode* ptr1 = &u_mode)
            fixed (SDL_TextureAddressMode* ptr2 = &v_mode)
            {
                return iSDL_GetRenderTextureAddressMode(renderer, ptr1, ptr2);
            }
        }

        public static SDL_Surface* SDL_RenderReadPixels(SDL_Renderer* renderer, SDL_Rect* rect)
        {
            return iSDL_RenderReadPixels(renderer, rect);
        }

        public static bool SDL_RenderPresent(SDL_Renderer* renderer)
        {
            return iSDL_RenderPresent(renderer);
        }

        public static void SDL_DestroyTexture(SDL_Texture* texture)
        {
            iSDL_DestroyTexture(texture);
        }

        public static void SDL_DestroyRenderer(SDL_Renderer* renderer)
        {
            iSDL_DestroyRenderer(renderer);
        }

        public static bool SDL_FlushRenderer(SDL_Renderer* renderer)
        {
            return iSDL_FlushRenderer(renderer);
        }

        public static IntPtr SDL_GetRenderMetalLayer(SDL_Renderer* renderer)
        {
            return iSDL_GetRenderMetalLayer(renderer);
        }

        public static IntPtr SDL_GetRenderMetalCommandEncoder(SDL_Renderer* renderer)
        {
            return iSDL_GetRenderMetalCommandEncoder(renderer);
        }

        public static bool SDL_AddVulkanRenderSemaphores(SDL_Renderer* renderer, uint wait_stage_mask, long wait_semaphore, long signal_semaphore)
        {
            return iSDL_AddVulkanRenderSemaphores(renderer, wait_stage_mask, wait_semaphore, signal_semaphore);
        }

        public static bool SDL_SetRenderVSync(SDL_Renderer* renderer, int vsync)
        {
            return iSDL_SetRenderVSync(renderer, vsync);
        }

        public static bool SDL_GetRenderVSync(SDL_Renderer* renderer, out int vsync)
        {
            fixed (int* ptr1 = &vsync)
            {
                return iSDL_GetRenderVSync(renderer, ptr1);
            }
        }

        public static bool SDL_RenderDebugText(SDL_Renderer* renderer, float x, float y, string str)
        {
            fixed (byte* ptr1 = SDL_StringToNative(str))
            {
                return iSDL_RenderDebugText(renderer, x, y, ptr1);
            }
        }

        public static bool SDL_RenderDebugTextFormat(SDL_Renderer* renderer, float x, float y, string fmt)
        {
            fixed (byte* ptr1 = SDL_StringToNative(fmt))
            {
                return iSDL_RenderDebugTextFormat(renderer, x, y, ptr1);
            }
        }

        public static bool SDL_SetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode scale_mode)
        {
            return iSDL_SetDefaultTextureScaleMode(renderer, scale_mode);
        }

        public static bool SDL_GetDefaultTextureScaleMode(SDL_Renderer* renderer, out SDL_ScaleMode scale_mode)
        {
            fixed (SDL_ScaleMode* ptr1 = &scale_mode)
            {
                return iSDL_GetDefaultTextureScaleMode(renderer, ptr1);
            }
        }

        public static SDL_GPURenderState* SDL_CreateGPURenderState(SDL_Renderer* renderer, SDL_GPURenderStateCreateInfo* createinfo)
        {
            return iSDL_CreateGPURenderState(renderer, createinfo);
        }

        public static bool SDL_SetGPURenderStateSamplerBindings(SDL_GPURenderState* state, int num_sampler_bindings, SDL_GPUTextureSamplerBinding[] sampler_bindings)
        {
            fixed (SDL_GPUTextureSamplerBinding* ptr1 = sampler_bindings)
            {
                return iSDL_SetGPURenderStateSamplerBindings(state, num_sampler_bindings, ptr1);
            }
        }

        public static bool SDL_SetGPURenderStateStorageTextures(SDL_GPURenderState* state, int num_storage_textures, SDL_GPUTexture*[] storage_textures)
        {
            fixed (SDL_GPUTexture** ptr1 = storage_textures)
            {
                return iSDL_SetGPURenderStateStorageTextures(state, num_storage_textures, ptr1);
            }
        }

        public static bool SDL_SetGPURenderStateStorageBuffers(SDL_GPURenderState* state, int num_storage_buffers, SDL_GPUBuffer*[] storage_buffers)
        {
            fixed (SDL_GPUBuffer** ptr1 = storage_buffers)
            {
                return iSDL_SetGPURenderStateStorageBuffers(state, num_storage_buffers, ptr1);
            }
        }

        public static bool SDL_SetGPURenderStateFragmentUniforms(SDL_GPURenderState* state, uint slot_index, IntPtr data, uint length)
        {
            return iSDL_SetGPURenderStateFragmentUniforms(state, slot_index, data, length);
        }

        public static bool SDL_SetGPURenderState(SDL_Renderer* renderer, SDL_GPURenderState* state)
        {
            return iSDL_SetGPURenderState(renderer, state);
        }

        public static void SDL_DestroyGPURenderState(SDL_GPURenderState* state)
        {
            iSDL_DestroyGPURenderState(state);
        }
    }
}