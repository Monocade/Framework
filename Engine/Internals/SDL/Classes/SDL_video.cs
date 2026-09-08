using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_GetNumVideoDrivers()
        {
            return iSDL_GetNumVideoDrivers();
        }

        public static string SDL_GetVideoDriver(int index)
        {
            return SDL_NativeToString(iSDL_GetVideoDriver(index));
        }

        public static string SDL_GetCurrentVideoDriver()
        {
            return SDL_NativeToString(iSDL_GetCurrentVideoDriver());
        }

        public static SDL_SystemTheme SDL_GetSystemTheme()
        {
            return iSDL_GetSystemTheme();
        }

        public static uint[] SDL_GetDisplays(out int count)
        {
            return SDL_NativeToArray(iSDL_GetDisplays(null), out count);
        }

        public static uint SDL_GetPrimaryDisplay()
        {
            return iSDL_GetPrimaryDisplay();
        }

        public static uint SDL_GetDisplayProperties(uint displayID)
        {
            return iSDL_GetDisplayProperties(displayID);
        }

        public static string SDL_GetDisplayName(uint displayID)
        {
            return SDL_NativeToString(iSDL_GetDisplayName(displayID));
        }

        public static bool SDL_GetDisplayBounds(uint displayID, out SDL_Rect rect)
        {
            fixed (SDL_Rect* ptr1 = &rect)
            {
                return iSDL_GetDisplayBounds(displayID, ptr1);
            }
        }

        public static bool SDL_GetDisplayUsableBounds(uint displayID, out SDL_Rect rect)
        {
            fixed (SDL_Rect* ptr1 = &rect)
            {
                return iSDL_GetDisplayUsableBounds(displayID, ptr1);
            }
        }

        public static SDL_DisplayOrientation SDL_GetNaturalDisplayOrientation(uint displayID)
        {
            return iSDL_GetNaturalDisplayOrientation(displayID);
        }

        public static SDL_DisplayOrientation SDL_GetCurrentDisplayOrientation(uint displayID)
        {
            return iSDL_GetCurrentDisplayOrientation(displayID);
        }

        public static float SDL_GetDisplayContentScale(uint displayID)
        {
            return iSDL_GetDisplayContentScale(displayID);
        }

        public static SDL_DisplayMode*[] SDL_GetFullscreenDisplayModes(uint displayID, out int count)
        {
            return SDL_NativeToArray(iSDL_GetFullscreenDisplayModes(displayID, null), out count);
        }

        public static bool SDL_GetClosestFullscreenDisplayMode(uint displayID, int w, int h, float refresh_rate, bool include_high_density_modes, out SDL_DisplayMode closest)
        {
            fixed (SDL_DisplayMode* ptr1 = &closest)
            {
                return iSDL_GetClosestFullscreenDisplayMode(displayID, w, h, refresh_rate, include_high_density_modes, ptr1);
            }
        }

        public static SDL_DisplayMode* SDL_GetDesktopDisplayMode(uint displayID)
        {
            return iSDL_GetDesktopDisplayMode(displayID);
        }

        public static SDL_DisplayMode* SDL_GetCurrentDisplayMode(uint displayID)
        {
            return iSDL_GetCurrentDisplayMode(displayID);
        }

        public static uint SDL_GetDisplayForPoint(SDL_Point* point)
        {
            return iSDL_GetDisplayForPoint(point);
        }

        public static uint SDL_GetDisplayForRect(SDL_Rect* rect)
        {
            return iSDL_GetDisplayForRect(rect);
        }

        public static uint SDL_GetDisplayForWindow(SDL_Window* window)
        {
            return iSDL_GetDisplayForWindow(window);
        }

        public static float SDL_GetWindowPixelDensity(SDL_Window* window)
        {
            return iSDL_GetWindowPixelDensity(window);
        }

        public static float SDL_GetWindowDisplayScale(SDL_Window* window)
        {
            return iSDL_GetWindowDisplayScale(window);
        }

        public static bool SDL_SetWindowFullscreenMode(SDL_Window* window, SDL_DisplayMode* mode)
        {
            return iSDL_SetWindowFullscreenMode(window, mode);
        }

        public static SDL_DisplayMode* SDL_GetWindowFullscreenMode(SDL_Window* window)
        {
            return iSDL_GetWindowFullscreenMode(window);
        }

        public static IntPtr SDL_GetWindowICCProfile(SDL_Window* window, out UIntPtr size)
        {
            fixed (UIntPtr* ptr = &size)
            {
                return iSDL_GetWindowICCProfile(window, ptr);
            }
        }

        public static SDL_PixelFormat SDL_GetWindowPixelFormat(SDL_Window* window)
        {
            return iSDL_GetWindowPixelFormat(window);
        }

        public static SDL_Window*[] SDL_GetWindows(out int count)
        {
            return SDL_NativeToArray(iSDL_GetWindows(null), out count);
        }

        public static SDL_Window* SDL_CreateWindow(string title, int w, int h, ulong flags)
        {
            fixed (byte* ptr1 = SDL_StringToNative(title))
            {
                return iSDL_CreateWindow(ptr1, w, h, flags);
            }
        }

        public static SDL_Window* SDL_CreatePopupWindow(SDL_Window* parent, int offset_x, int offset_y, int w, int h, ulong flags)
        {
            return iSDL_CreatePopupWindow(parent, offset_x, offset_y, w, h, flags);
        }

        public static SDL_Window* SDL_CreateWindowWithProperties(uint props)
        {
            return iSDL_CreateWindowWithProperties(props);
        }

        public static uint SDL_GetWindowID(SDL_Window* window)
        {
            return iSDL_GetWindowID(window);
        }

        public static SDL_Window* SDL_GetWindowFromID(uint id)
        {
            return iSDL_GetWindowFromID(id);
        }

        public static SDL_Window* SDL_GetWindowParent(SDL_Window* window)
        {
            return iSDL_GetWindowParent(window);
        }

        public static uint SDL_GetWindowProperties(SDL_Window* window)
        {
            return iSDL_GetWindowProperties(window);
        }

        public static ulong SDL_GetWindowFlags(SDL_Window* window)
        {
            return iSDL_GetWindowFlags(window);
        }

        public static bool SDL_SetWindowTitle(SDL_Window* window, string title)
        {
            fixed (byte* ptr1 = SDL_StringToNative(title))
            {
                return iSDL_SetWindowTitle(window, ptr1);
            }
        }

        public static string SDL_GetWindowTitle(SDL_Window* window)
        {
            return SDL_NativeToString(iSDL_GetWindowTitle(window));
        }

        public static bool SDL_SetWindowIcon(SDL_Window* window, SDL_Surface* icon)
        {
            return iSDL_SetWindowIcon(window, icon);
        }

        public static bool SDL_SetWindowPosition(SDL_Window* window, int x, int y)
        {
            return iSDL_SetWindowPosition(window, x, y);
        }

        public static bool SDL_GetWindowPosition(SDL_Window* window, out int x, out int y)
        {
            fixed (int* ptr1 = &x)
            fixed (int* ptr2 = &y)
            {
                return iSDL_GetWindowPosition(window, ptr1, ptr2);
            }
        }

        public static bool SDL_SetWindowSize(SDL_Window* window, int w, int h)
        {
            return iSDL_SetWindowSize(window, w, h);
        }

        public static bool SDL_GetWindowSize(SDL_Window* window, out int w, out int h)
        {
            fixed (int* ptr1 = &w)
            fixed (int* ptr2 = &h)
            {
                return iSDL_GetWindowSize(window, ptr1, ptr2);
            }
        }

        public static bool SDL_GetWindowSafeArea(SDL_Window* window, out SDL_Rect rect)
        {
            fixed (SDL_Rect* ptr1 = &rect)
            {
                return iSDL_GetWindowSafeArea(window, ptr1);
            }
        }

        public static bool SDL_SetWindowAspectRatio(SDL_Window* window, float min_aspect, float max_aspect)
        {
            return iSDL_SetWindowAspectRatio(window, min_aspect, max_aspect);
        }

        public static bool SDL_GetWindowAspectRatio(SDL_Window* window, out float min_aspect, out float max_aspect)
        {
            fixed (float* ptr1 = &min_aspect)
            fixed (float* ptr2 = &max_aspect)
            {
                return iSDL_GetWindowAspectRatio(window, ptr1, ptr2);
            }
        }

        public static bool SDL_GetWindowBordersSize(SDL_Window* window, out int top, out int left, out int bottom, out int right)
        {
            fixed (int* ptr1 = &top)
            fixed (int* ptr2 = &left)
            fixed (int* ptr3 = &bottom)
            fixed (int* ptr4 = &right)
            {
                return iSDL_GetWindowBordersSize(window, ptr1, ptr2, ptr3, ptr4);
            }
        }

        public static bool SDL_GetWindowSizeInPixels(SDL_Window* window, out int w, out int h)
        {
            fixed (int* ptr1 = &w)
            fixed (int* ptr2 = &h)
            {
                return iSDL_GetWindowSizeInPixels(window, ptr1, ptr2);
            }
        }

        public static bool SDL_SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h)
        {
            return iSDL_SetWindowMinimumSize(window, min_w, min_h);
        }

        public static bool SDL_GetWindowMinimumSize(SDL_Window* window, out int w, out int h)
        {
            fixed (int* ptr1 = &w)
            fixed (int* ptr2 = &h)
            {
                return iSDL_GetWindowMinimumSize(window, ptr1, ptr2);
            }
        }

        public static bool SDL_SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h)
        {
            return iSDL_SetWindowMaximumSize(window, max_w, max_h);
        }

        public static bool SDL_GetWindowMaximumSize(SDL_Window* window, out int w, out int h)
        {
            fixed (int* ptr1 = &w)
            fixed (int* ptr2 = &h)
            {
                return iSDL_GetWindowMaximumSize(window, ptr1, ptr2);
            }
        }

        public static bool SDL_SetWindowBordered(SDL_Window* window, bool bordered)
        {
            return iSDL_SetWindowBordered(window, bordered);
        }

        public static bool SDL_SetWindowResizable(SDL_Window* window, bool resizable)
        {
            return iSDL_SetWindowResizable(window, resizable);
        }

        public static bool SDL_SetWindowAlwaysOnTop(SDL_Window* window, bool on_top)
        {
            return iSDL_SetWindowAlwaysOnTop(window, on_top);
        }

        public static bool SDL_SetWindowFillDocument(SDL_Window* window, bool fill)
        {
            return iSDL_SetWindowFillDocument(window, fill);
        }

        public static bool SDL_ShowWindow(SDL_Window* window)
        {
            return iSDL_ShowWindow(window);
        }

        public static bool SDL_HideWindow(SDL_Window* window)
        {
            return iSDL_HideWindow(window);
        }

        public static bool SDL_RaiseWindow(SDL_Window* window)
        {
            return iSDL_RaiseWindow(window);
        }

        public static bool SDL_MaximizeWindow(SDL_Window* window)
        {
            return iSDL_MaximizeWindow(window);
        }

        public static bool SDL_MinimizeWindow(SDL_Window* window)
        {
            return iSDL_MinimizeWindow(window);
        }

        public static bool SDL_RestoreWindow(SDL_Window* window)
        {
            return iSDL_RestoreWindow(window);
        }

        public static bool SDL_SetWindowFullscreen(SDL_Window* window, bool fullscreen)
        {
            return iSDL_SetWindowFullscreen(window, fullscreen);
        }

        public static bool SDL_SyncWindow(SDL_Window* window)
        {
            return iSDL_SyncWindow(window);
        }

        public static bool SDL_WindowHasSurface(SDL_Window* window)
        {
            return iSDL_WindowHasSurface(window);
        }

        public static SDL_Surface* SDL_GetWindowSurface(SDL_Window* window)
        {
            return iSDL_GetWindowSurface(window);
        }

        public static bool SDL_SetWindowSurfaceVSync(SDL_Window* window, int vsync)
        {
            return iSDL_SetWindowSurfaceVSync(window, vsync);
        }

        public static bool SDL_GetWindowSurfaceVSync(SDL_Window* window, out int vsync)
        {
            fixed (int* ptr1 = &vsync)
            {
                return iSDL_GetWindowSurfaceVSync(window, ptr1);
            }
        }

        public static bool SDL_UpdateWindowSurface(SDL_Window* window)
        {
            return iSDL_UpdateWindowSurface(window);
        }

        public static bool SDL_UpdateWindowSurfaceRects(SDL_Window* window, SDL_Rect[] rects, int numrects)
        {
            fixed (SDL_Rect* ptr1 = rects)
            {
                return iSDL_UpdateWindowSurfaceRects(window, ptr1, numrects);
            }
        }

        public static bool SDL_DestroyWindowSurface(SDL_Window* window)
        {
            return iSDL_DestroyWindowSurface(window);
        }

        public static bool SDL_SetWindowKeyboardGrab(SDL_Window* window, bool grabbed)
        {
            return iSDL_SetWindowKeyboardGrab(window, grabbed);
        }

        public static bool SDL_SetWindowMouseGrab(SDL_Window* window, bool grabbed)
        {
            return iSDL_SetWindowMouseGrab(window, grabbed);
        }

        public static bool SDL_GetWindowKeyboardGrab(SDL_Window* window)
        {
            return iSDL_GetWindowKeyboardGrab(window);
        }

        public static bool SDL_GetWindowMouseGrab(SDL_Window* window)
        {
            return iSDL_GetWindowMouseGrab(window);
        }

        public static SDL_Window* SDL_GetGrabbedWindow()
        {
            return iSDL_GetGrabbedWindow();
        }

        public static bool SDL_SetWindowMouseRect(SDL_Window* window, SDL_Rect* rect)
        {
            return iSDL_SetWindowMouseRect(window, rect);
        }

        public static SDL_Rect* SDL_GetWindowMouseRect(SDL_Window* window)
        {
            return iSDL_GetWindowMouseRect(window);
        }

        public static bool SDL_SetWindowOpacity(SDL_Window* window, float opacity)
        {
            return iSDL_SetWindowOpacity(window, opacity);
        }

        public static float SDL_GetWindowOpacity(SDL_Window* window)
        {
            return iSDL_GetWindowOpacity(window);
        }

        public static bool SDL_SetWindowParent(SDL_Window* window, SDL_Window* parent)
        {
            return iSDL_SetWindowParent(window, parent);
        }

        public static bool SDL_SetWindowModal(SDL_Window* window, bool modal)
        {
            return iSDL_SetWindowModal(window, modal);
        }

        public static bool SDL_SetWindowFocusable(SDL_Window* window, bool focusable)
        {
            return iSDL_SetWindowFocusable(window, focusable);
        }

        public static bool SDL_ShowWindowSystemMenu(SDL_Window* window, int x, int y)
        {
            return iSDL_ShowWindowSystemMenu(window, x, y);
        }

        public static bool SDL_SetWindowHitTest(SDL_Window* window, SDL_HitTest callback, IntPtr callback_data)
        {
            return iSDL_SetWindowHitTest(window, Marshal.GetFunctionPointerForDelegate(callback), callback_data);
        }

        public static bool SDL_SetWindowShape(SDL_Window* window, SDL_Surface* shape)
        {
            return iSDL_SetWindowShape(window, shape);
        }

        public static bool SDL_FlashWindow(SDL_Window* window, SDL_FlashOperation operation)
        {
            return iSDL_FlashWindow(window, operation);
        }

        public static bool SDL_SetWindowProgressState(SDL_Window* window, SDL_ProgressState state)
        {
            return iSDL_SetWindowProgressState(window, state);
        }

        public static SDL_ProgressState SDL_GetWindowProgressState(SDL_Window* window)
        {
            return iSDL_GetWindowProgressState(window);
        }

        public static bool SDL_SetWindowProgressValue(SDL_Window* window, float value)
        {
            return iSDL_SetWindowProgressValue(window, value);
        }

        public static float SDL_GetWindowProgressValue(SDL_Window* window)
        {
            return iSDL_GetWindowProgressValue(window);
        }

        public static void SDL_DestroyWindow(SDL_Window* window)
        {
            iSDL_DestroyWindow(window);
        }

        public static bool SDL_ScreenSaverEnabled()
        {
            return iSDL_ScreenSaverEnabled();
        }

        public static bool SDL_EnableScreenSaver()
        {
            return iSDL_EnableScreenSaver();
        }

        public static bool SDL_DisableScreenSaver()
        {
            return iSDL_DisableScreenSaver();
        }

        public static bool SDL_GL_LoadLibrary(string path)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            {
                return iSDL_GL_LoadLibrary(ptr1);
            }
        }

        public static IntPtr SDL_GL_GetProcAddress(string proc)
        {
            fixed (byte* ptr1 = SDL_StringToNative(proc))
            {
                return iSDL_GL_GetProcAddress(ptr1);
            }
        }

        public static IntPtr SDL_EGL_GetProcAddress(string proc)
        {
            fixed (byte* ptr1 = SDL_StringToNative(proc))
            {
                return iSDL_EGL_GetProcAddress(ptr1);
            }
        }

        public static void SDL_GL_UnloadLibrary()
        {
            iSDL_GL_UnloadLibrary();
        }

        public static bool SDL_GL_ExtensionSupported(string extension)
        {
            fixed (byte* ptr1 = SDL_StringToNative(extension))
            {
                return iSDL_GL_ExtensionSupported(ptr1);
            }
        }

        public static void SDL_GL_ResetAttributes()
        {
            iSDL_GL_ResetAttributes();
        }

        public static bool SDL_GL_SetAttribute(SDL_GLAttr attr, int value)
        {
            return iSDL_GL_SetAttribute(attr, value);
        }

        public static bool SDL_GL_GetAttribute(SDL_GLAttr attr, out int value)
        {
            fixed (int* ptr1 = &value)
            {
                return iSDL_GL_GetAttribute(attr, ptr1);
            }
        }

        public static SDL_GLContextState* SDL_GL_CreateContext(SDL_Window* window)
        {
            return iSDL_GL_CreateContext(window);
        }

        public static bool SDL_GL_MakeCurrent(SDL_Window* window, SDL_GLContextState* context)
        {
            return iSDL_GL_MakeCurrent(window, context);
        }

        public static SDL_Window* SDL_GL_GetCurrentWindow()
        {
            return iSDL_GL_GetCurrentWindow();
        }

        public static SDL_GLContextState* SDL_GL_GetCurrentContext()
        {
            return iSDL_GL_GetCurrentContext();
        }

        public static IntPtr SDL_EGL_GetCurrentDisplay()
        {
            return iSDL_EGL_GetCurrentDisplay();
        }

        public static IntPtr SDL_EGL_GetCurrentConfig()
        {
            return iSDL_EGL_GetCurrentConfig();
        }

        public static IntPtr SDL_EGL_GetWindowSurface(SDL_Window* window)
        {
            return iSDL_EGL_GetWindowSurface(window);
        }

        public static void SDL_EGL_SetAttributeCallbacks(SDL_EGLAttribArrayCallback platformAttribCallback, SDL_EGLIntArrayCallback surfaceAttribCallback, SDL_EGLIntArrayCallback contextAttribCallback, IntPtr userdata)
        {
            iSDL_EGL_SetAttributeCallbacks(Marshal.GetFunctionPointerForDelegate(platformAttribCallback), Marshal.GetFunctionPointerForDelegate(surfaceAttribCallback), Marshal.GetFunctionPointerForDelegate(contextAttribCallback), userdata);
        }

        public static bool SDL_GL_SetSwapInterval(int interval)
        {
            return iSDL_GL_SetSwapInterval(interval);
        }

        public static bool SDL_GL_GetSwapInterval(out int interval)
        {
            fixed (int* ptr1 = &interval)
            {
                return iSDL_GL_GetSwapInterval(ptr1);
            }
        }

        public static bool SDL_GL_SwapWindow(SDL_Window* window)
        {
            return iSDL_GL_SwapWindow(window);
        }

        public static bool SDL_GL_DestroyContext(SDL_GLContextState* context)
        {
            return iSDL_GL_DestroyContext(context);
        }
    }
}