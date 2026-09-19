using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_AssertState SDL_ReportAssertion(SDL_AssertData* data, string func, string file, int line)
        {
            var funcPtr = Native.StringToNative(func, SDL_NativeProvider);
            var filePtr = Native.StringToNative(file, SDL_NativeProvider);
            {
                var result = iSDL_ReportAssertion(data, (byte*)funcPtr, (byte*)filePtr, line);
                {
                    Native.Free(funcPtr, SDL_NativeProvider);
                    Native.Free(filePtr, SDL_NativeProvider);
                    return result;
                }
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

        public static SDL_AssertionHandler SDL_GetAssertionHandler(out IntPtr pUserData)
        {
            fixed (IntPtr* ptr1 = &pUserData)
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