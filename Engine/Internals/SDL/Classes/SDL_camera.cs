using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_GetNumCameraDrivers()
        {
            return iSDL_GetNumCameraDrivers();
        }

        public static string SDL_GetCameraDriver(int index)
        {
            return SDL_NativeToString(iSDL_GetCameraDriver(index));
        }

        public static string SDL_GetCurrentCameraDriver()
        {
            return SDL_NativeToString(iSDL_GetCurrentCameraDriver());
        }

        public static uint[] SDL_GetCameras(out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetCameras(&size), size, out count);
            }
        }

        public static SDL_CameraSpec*[] SDL_GetCameraSupportedFormats(uint cameraID, out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetCameraSupportedFormats(cameraID, &size), size, out count);
            }
        }

        public static string SDL_GetCameraName(uint cameraID)
        {
            return SDL_NativeToString(iSDL_GetCameraName(cameraID));
        }

        public static SDL_CameraPosition SDL_GetCameraPosition(uint cameraID)
        {
            return iSDL_GetCameraPosition(cameraID);
        }

        public static SDL_Camera* SDL_OpenCamera(uint cameraID, SDL_CameraSpec* spec)
        {
            return iSDL_OpenCamera(cameraID, spec);
        }

        public static SDL_CameraPermissionState SDL_GetCameraPermissionState(SDL_Camera* camera)
        {
            return iSDL_GetCameraPermissionState(camera);
        }

        public static uint SDL_GetCameraID(SDL_Camera* camera)
        {
            return iSDL_GetCameraID(camera);
        }

        public static uint SDL_GetCameraProperties(SDL_Camera* camera)
        {
            return iSDL_GetCameraProperties(camera);
        }

        public static bool SDL_GetCameraFormat(SDL_Camera* camera, out SDL_CameraSpec spec)
        {
            fixed (SDL_CameraSpec* ptr1 = &spec)
            {
                return iSDL_GetCameraFormat(camera, ptr1);
            }
        }

        public static SDL_Surface* SDL_AcquireCameraFrame(SDL_Camera* camera, out ulong timestampNS)
        {
            fixed (ulong* ptr1 = &timestampNS)
            {
                return iSDL_AcquireCameraFrame(camera, ptr1);
            }
        }

        public static void SDL_ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame)
        {
            iSDL_ReleaseCameraFrame(camera, frame);
        }

        public static void SDL_CloseCamera(SDL_Camera* camera)
        {
            iSDL_CloseCamera(camera);
        }
    }
}