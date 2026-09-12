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

        public static string SDL_GetMouseNameForID(uint mouseID)
        {
            return SDL_NativeToString(iSDL_GetMouseNameForID(mouseID));
        }

        public static SDL_Window* SDL_GetMouseFocus()
        {
            return iSDL_GetMouseFocus();
        }

        public static SDL_MouseButtonFlags SDL_GetMouseState(out float x, out float y)
        {
            fixed (float* ptr1 = &x)
            fixed (float* ptr2 = &y)
            {
                return (SDL_MouseButtonFlags)iSDL_GetMouseState(ptr1, ptr2);
            }
        }

        public static SDL_MouseButtonFlags SDL_GetGlobalMouseState(out float x, out float y)
        {
            fixed (float* ptr1 = &x)
            fixed (float* ptr2 = &y)
            {
                return (SDL_MouseButtonFlags)iSDL_GetGlobalMouseState(ptr1, ptr2);
            }
        }

        public static SDL_MouseButtonFlags SDL_GetRelativeMouseState(out float x, out float y)
        {
            fixed (float* ptr1 = &x)
            fixed (float* ptr2 = &y)
            {
                return (SDL_MouseButtonFlags)iSDL_GetRelativeMouseState(ptr1, ptr2);
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

        public static SDL_Cursor* SDL_CreateCursor(IntPtr data, IntPtr mask, int w, int h, int hotX, int hotY)
        {
            return iSDL_CreateCursor((byte*)data, (byte*)mask, w, h, hotX, hotY);
        }

        public static SDL_Cursor* SDL_CreateColorCursor(SDL_Surface* surface, int hotX, int hotY)
        {
            return iSDL_CreateColorCursor(surface, hotX, hotY);
        }

        public static SDL_Cursor* SDL_CreateAnimatedCursor(SDL_CursorFrameInfo[] frames, int frameCount, int hotX, int hotY)
        {
            fixed (SDL_CursorFrameInfo* ptr1 = frames)
            {
                return iSDL_CreateAnimatedCursor(ptr1, frameCount, hotX, hotY);
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