using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static bool SDL_HasRectIntersection(SDL_Rect* A, SDL_Rect* B)
        {
            return iSDL_HasRectIntersection(A, B);
        }

        public static bool SDL_GetRectIntersection(SDL_Rect* A, SDL_Rect* B, out SDL_Rect result)
        {
            fixed (SDL_Rect* ptr1 = &result)
            {
                return iSDL_GetRectIntersection(A, B, ptr1);
            }
        }

        public static bool SDL_GetRectUnion(SDL_Rect* A, SDL_Rect* B, out SDL_Rect result)
        {
            fixed (SDL_Rect* ptr1 = &result)
            {
                return iSDL_GetRectUnion(A, B, ptr1);
            }
        }

        public static bool SDL_GetRectEnclosingPoints(SDL_Point[] points, int count, SDL_Rect* clip, out SDL_Rect result)
        {
            fixed (SDL_Point* ptr1 = points)
            fixed (SDL_Rect* ptr2 = &result)
            {
                return iSDL_GetRectEnclosingPoints(ptr1, count, clip, ptr2);
            }
        }

        public static bool SDL_GetRectAndLineIntersection(SDL_Rect* rect, ref int X1, ref int Y1, ref int X2, ref int Y2)
        {
            fixed (int* ptr1 = &X1)
            fixed (int* ptr2 = &Y1)
            fixed (int* ptr3 = &X2)
            fixed (int* ptr4 = &Y2)
            {
                return iSDL_GetRectAndLineIntersection(rect, ptr1, ptr2, ptr3, ptr4);
            }
        }

        public static bool SDL_HasRectIntersectionFloat(SDL_FRect* A, SDL_FRect* B)
        {
            return iSDL_HasRectIntersectionFloat(A, B);
        }

        public static bool SDL_GetRectIntersectionFloat(SDL_FRect* A, SDL_FRect* B, out SDL_FRect result)
        {
            fixed (SDL_FRect* ptr1 = &result)
            {
                return iSDL_GetRectIntersectionFloat(A, B, ptr1);
            }
        }

        public static bool SDL_GetRectUnionFloat(SDL_FRect* A, SDL_FRect* B, out SDL_FRect result)
        {
            fixed (SDL_FRect* ptr1 = &result)
            {
                return iSDL_GetRectUnionFloat(A, B, ptr1);
            }
        }

        public static bool SDL_GetRectEnclosingPointsFloat(SDL_FPoint[] points, int count, SDL_FRect* clip, out SDL_FRect result)
        {
            fixed (SDL_FPoint* ptr1 = points)
            fixed (SDL_FRect* ptr2 = &result)
            {
                return iSDL_GetRectEnclosingPointsFloat(ptr1, count, clip, ptr2);
            }
        }

        public static bool SDL_GetRectAndLineIntersectionFloat(SDL_FRect* rect, ref float X1, ref float Y1, ref float X2, ref float Y2)
        {
            fixed (float* ptr1 = &X1)
            fixed (float* ptr2 = &Y1)
            fixed (float* ptr3 = &X2)
            fixed (float* ptr4 = &Y2)
            {
                return iSDL_GetRectAndLineIntersectionFloat(rect, ptr1, ptr2, ptr3, ptr4);
            }
        }
    }
}