using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System;

namespace Engine
{
    // Arrays
    internal static unsafe partial class Native
    {
        public static T*[] NativeToArray<T>(T** ptr, int size, out int count) where T : unmanaged
        {
            count = 0;

            if (ptr == null || size <= 0)
            {
                return [];
            }

            var result = new T*[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = ptr[i];
            }

            count = size;
            {
                return result;
            }
        }
        
        public static T[] NativeToArray<T>(T* ptr, int size, out int count) where T : unmanaged
        {
            count = 0;
            
            if (ptr == null || size <= 0)
            {
                return [];
            }

            var result = new T[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = ptr[i];
            }

            count = size;
            {
                return result;
            }
        }
        
        public static string[] NativeToStringArray(IntPtr ptr, int size, out int count)
        {
            count = 0;

            var data = (byte**)ptr;
            if (data == null || size <= 0)
            {
                return [];
            }

            var result = new string[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = NativeToString((IntPtr)data[i]);
            }

            count = size;
            {
                return result;
            }
        }
        
        public static string[] NativeToStringArray(IntPtr ptr, out int count)
        {
            count = 0;

            var data = (byte**)ptr;
            if (data == null)
            {
                return [];
            }

            var result = new List<string>();
                
            for (int i = 0; data[i] != null; i++)
            {
                result.Add(NativeToString((IntPtr)data[i]));
            }

            count = result.Count;
            {
                return result.ToArray();
            }
        }
    }

    // String
    internal static unsafe partial class Native
    {
        internal static IntPtr StringToNative(string value, NativeProvider provider)
        {
            value ??= string.Empty;
            int byteCount = Encoding.UTF8.GetByteCount(value);
            byte* ptr = (byte*)provider.Allocate((nuint)(byteCount + 1));

            if (ptr == null)
            {
                throw new OutOfMemoryException();
            }
                
            Encoding.UTF8.GetBytes(value, new Span<byte>(ptr, byteCount));
            ptr[byteCount] = 0;
            
            return (IntPtr)ptr;
        }
        
        internal static string NativeToString(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
            {
                return string.Empty;
            }

            return Marshal.PtrToStringUTF8(ptr) ?? string.Empty;
        }
    }
    
    // Callback
    internal static partial class Native
    {
        public static IntPtr CallbackToNative<T>(T value) where T : class
        {
            return GCHandle.ToIntPtr(GCHandle.Alloc(value));
        }
        
        public static T NativeToCallback<T>(IntPtr ptr) where T : class
        {
            var handle = GCHandle.FromIntPtr(ptr);

            try
            {
                return handle.Target as T;
            }
            finally
            {
                handle.Free();
            }
        }
    }
    
    // Free
    internal static partial class Native
    {
        public static void Free(IntPtr ptr, NativeProvider provider)
        {
            provider?.Free(ptr);
        }
    }
}