using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_HasMouse()
        {
            return iSDL_HasMouse();
        }

        public static uint[] SDL_GetMice(out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetMice(&size), size, out count);
            }
        }

        public static string SDL_GetMouseNameForID(uint instance_id)
        {
            return SDL_NativeToString(iSDL_GetMouseNameForID(instance_id));
        }

        public static SDL_Window* SDL_GetMouseFocus()
        {
            return iSDL_GetMouseFocus();
        }

        public static uint SDL_GetMouseState(out float x, out float y)
        {
            fixed (float* ptr1 = &x)
            fixed (float* ptr2 = &y)
            {
                return iSDL_GetMouseState(ptr1, ptr2);
            }
        }

        public static uint SDL_GetGlobalMouseState(out float x, out float y)
        {
            fixed (float* ptr1 = &x)
            fixed (float* ptr2 = &y)
            {
                return iSDL_GetGlobalMouseState(ptr1, ptr2);
            }
        }

        public static uint SDL_GetRelativeMouseState(out float x, out float y)
        {
            fixed (float* ptr1 = &x)
            fixed (float* ptr2 = &y)
            {
                return iSDL_GetRelativeMouseState(ptr1, ptr2);
            }
        }

        public static void SDL_WarpMouseInWindow(SDL_Window* window, float x, float y)
        {
            iSDL_WarpMouseInWindow(window, x, y);
        }

        public static bool SDL_WarpMouseGlobal(float x, float y)
        {
            return iSDL_WarpMouseGlobal(x, y);
        }

        public static bool SDL_SetRelativeMouseTransform(SDL_MouseMotionTransformCallback callback, IntPtr userdata)
        {
            return iSDL_SetRelativeMouseTransform(Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static bool SDL_SetWindowRelativeMouseMode(SDL_Window* window, bool enabled)
        {
            return iSDL_SetWindowRelativeMouseMode(window, enabled);
        }

        public static bool SDL_GetWindowRelativeMouseMode(SDL_Window* window)
        {
            return iSDL_GetWindowRelativeMouseMode(window);
        }

        public static bool SDL_CaptureMouse(bool enabled)
        {
            return iSDL_CaptureMouse(enabled);
        }

        public static SDL_Cursor* SDL_CreateCursor(IntPtr data, IntPtr mask, int w, int h, int hot_x, int hot_y)
        {
            return iSDL_CreateCursor((byte*)data, (byte*)mask, w, h, hot_x, hot_y);
        }

        public static SDL_Cursor* SDL_CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y)
        {
            return iSDL_CreateColorCursor(surface, hot_x, hot_y);
        }

        public static SDL_Cursor* SDL_CreateAnimatedCursor(SDL_CursorFrameInfo[] frames, int frame_count, int hot_x, int hot_y)
        {
            fixed (SDL_CursorFrameInfo* ptr1 = frames)
            {
                return iSDL_CreateAnimatedCursor(ptr1, frame_count, hot_x, hot_y);
            }
        }

        public static SDL_Cursor* SDL_CreateSystemCursor(SDL_SystemCursor id)
        {
            return iSDL_CreateSystemCursor(id);
        }

        public static bool SDL_SetCursor(SDL_Cursor* cursor)
        {
            return iSDL_SetCursor(cursor);
        }

        public static SDL_Cursor* SDL_GetCursor()
        {
            return iSDL_GetCursor();
        }

        public static SDL_Cursor* SDL_GetDefaultCursor()
        {
            return iSDL_GetDefaultCursor();
        }

        public static void SDL_DestroyCursor(SDL_Cursor* cursor)
        {
            iSDL_DestroyCursor(cursor);
        }

        public static bool SDL_ShowCursor()
        {
            return iSDL_ShowCursor();
        }

        public static bool SDL_HideCursor()
        {
            return iSDL_HideCursor();
        }

        public static bool SDL_CursorVisible()
        {
            return iSDL_CursorVisible();
        }
    }
}