using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static SDL_AsyncIO* SDL_AsyncIOFromFile(string file, string mode)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            fixed (byte* ptr2 = SDL_StringToNative(mode))
            {
                return iSDL_AsyncIOFromFile(ptr1, ptr2);
            }
        }

        public static long SDL_GetAsyncIOSize(SDL_AsyncIO* asyncio)
        {
            return iSDL_GetAsyncIOSize(asyncio);
        }

        public static bool SDL_ReadAsyncIO(SDL_AsyncIO* asyncio, IntPtr ptr, ulong offset, ulong size, SDL_AsyncIOQueue* queue, IntPtr userdata)
        {
            return iSDL_ReadAsyncIO(asyncio, ptr, offset, size, queue, userdata);
        }

        public static bool SDL_WriteAsyncIO(SDL_AsyncIO* asyncio, IntPtr ptr, ulong offset, ulong size, SDL_AsyncIOQueue* queue, IntPtr userdata)
        {
            return iSDL_WriteAsyncIO(asyncio, ptr, offset, size, queue, userdata);
        }

        public static bool SDL_CloseAsyncIO(SDL_AsyncIO* asyncio, bool flush, SDL_AsyncIOQueue* queue, IntPtr userdata)
        {
            return iSDL_CloseAsyncIO(asyncio, flush, queue, userdata);
        }

        public static SDL_AsyncIOQueue* SDL_CreateAsyncIOQueue()
        {
            return iSDL_CreateAsyncIOQueue();
        }

        public static void SDL_DestroyAsyncIOQueue(SDL_AsyncIOQueue* queue)
        {
            iSDL_DestroyAsyncIOQueue(queue);
        }

        public static bool SDL_GetAsyncIOResult(SDL_AsyncIOQueue* queue, out SDL_AsyncIOOutcome outcome)
        {
            fixed (SDL_AsyncIOOutcome* ptr1 = &outcome)
            {
                return iSDL_GetAsyncIOResult(queue, ptr1);
            }
        }

        public static bool SDL_WaitAsyncIOResult(SDL_AsyncIOQueue* queue, out SDL_AsyncIOOutcome outcome, int timeoutMS)
        {
            fixed (SDL_AsyncIOOutcome* ptr1 = &outcome)
            {
                return iSDL_WaitAsyncIOResult(queue, ptr1, timeoutMS);
            }
        }

        public static void SDL_SignalAsyncIOQueue(SDL_AsyncIOQueue* queue)
        {
            iSDL_SignalAsyncIOQueue(queue);
        }

        public static bool SDL_LoadFileAsync(string file, SDL_AsyncIOQueue* queue, IntPtr userdata)
        {
            fixed (byte* ptr1 = SDL_StringToNative(file))
            {
                return iSDL_LoadFileAsync(ptr1, queue, userdata);
            }
        }
    }
}