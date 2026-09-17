using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;
using System;

namespace Engine
{
    // T* Array
    internal static unsafe partial class Native
    {
        public static T** ArrayToNative<T>(T*[] array, NativeProvider provider) where T : unmanaged
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

            var count = array.Length;

            var ptr = (T**)provider.Allocate((nuint)((count + 1) * sizeof(T*)));

            if (ptr == null)
            {
                throw new OutOfMemoryException();
            }

            for (int i = 0; i < count; i++)
            {
                ptr[i] = array[i];
            }

            ptr[count] = null;

            return ptr;
        }

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

        public static T*[] NativeToArray<T>(T** ptr, out int count) where T : unmanaged
        {
            count = 0;

            if (ptr == null)
            {
                return [];
            }

            while (ptr[count] != null)
            {
                count++;
            }

            var result = new T*[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = ptr[i];
            }

            return result;
        }
    }
    
    // T Array
    internal static unsafe partial class Native
    {
        public static T* ArrayToNative<T>(T[] array, NativeProvider provider) where T : unmanaged
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

            var ptr = (T*)provider.Allocate((nuint)(array.Length * sizeof(T)));

            if (ptr == null)
            {
                throw new OutOfMemoryException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                ptr[i] = array[i];
            }

            return ptr;
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

        public static T[] NativeToArray<T>(T* ptr, out int count) where T : unmanaged
        {
            count = 0;

            if (ptr == null)
            {
                return [];
            }

            while (!EqualityComparer<T>.Default.Equals(ptr[count], default))
            {
                count++;
            }

            var result = new T[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = ptr[i];
            }

            return result;
        }
    }
    
    // String Array
    internal static unsafe partial class Native
    {
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

            while (data[count] != null)
            {
                count++;
            }

            var result = new string[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = NativeToString((IntPtr)data[i]);
            }

            return result;
        }
    }

    // String
    internal static unsafe partial class Native
    {
        public static IntPtr StringArrayToNative(string[] array, NativeProvider provider)
        {
            if (array == null || array.Length == 0)
            {
                return IntPtr.Zero;
            }

            var data = (byte**)provider.Allocate((nuint)((array.Length + 1) * sizeof(byte*)));

            if (data == null)
            {
                throw new OutOfMemoryException();
            }

            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    data[i] = (byte*)StringToNative(array[i], provider);
                }

                data[array.Length] = null;

                return (IntPtr)data;
            }
            catch
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (data[i] != null)
                    {
                        Free((IntPtr)data[i], provider);
                    }
                }

                Free((IntPtr)data, provider);
                throw;
            }
        }
        
        public static IntPtr StringToNative(string value, NativeProvider provider)
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
        
        public static string NativeToString(IntPtr ptr)
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