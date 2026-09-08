using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_AssertState SDL_ReportAssertion(SDL_AssertData* data, string func, string file, int line)
        {
            fixed (byte* ptr1 = SDL_StringToNative(func))
            fixed (byte* ptr2 = SDL_StringToNative(file))
            {
                return iSDL_ReportAssertion(data, ptr1, ptr2, line);
            }
        }

        public static void SDL_SetAssertionHandler(SDL_AssertionHandler handler, IntPtr userdata)
        {
            iSDL_SetAssertionHandler(Marshal.GetFunctionPointerForDelegate(handler), userdata);
        }

        public static SDL_AssertionHandler SDL_GetDefaultAssertionHandler()
        {
            return Marshal.GetDelegateForFunctionPointer<SDL_AssertionHandler>(iSDL_GetDefaultAssertionHandler());
        }

        public static SDL_AssertionHandler SDL_GetAssertionHandler(out IntPtr puserdata)
        {
            fixed (IntPtr* ptr1 = &puserdata)
            {
                return Marshal.GetDelegateForFunctionPointer<SDL_AssertionHandler>(iSDL_GetAssertionHandler(ptr1));
            }
        }

        public static SDL_AssertData* SDL_GetAssertionReport()
        {
            return iSDL_GetAssertionReport();
        }

        public static void SDL_ResetAssertionReport()
        {
            iSDL_ResetAssertionReport();
        }
    }
}