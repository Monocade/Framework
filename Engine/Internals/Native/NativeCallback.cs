using System;
using System.Runtime.InteropServices;

namespace Engine
{
    internal sealed class NativeCallback<T> where T : class
    {
        private GCHandle handle;

        public NativeCallback(T callback)
        {
            handle = GCHandle.Alloc(callback);
        }

        private NativeCallback(GCHandle handle)
        {
            this.handle = handle;
        }

        public static NativeCallback<T> FromPointer(IntPtr pointer)
        {
            return new NativeCallback<T>(GCHandle.FromIntPtr(pointer));
        }
        
        public static implicit operator IntPtr (NativeCallback<T> callback)
        {
            return callback.Ptr;
        }

        public static implicit operator T (NativeCallback<T> callback)
        {
            return callback.Callback;
        }

        public IntPtr Ptr
        {
            get => GCHandle.ToIntPtr(handle);
        }

        public T Callback
        {
            get => handle.IsAllocated ? handle.Target as T : null;
        }

        public void Free()
        {
            if (handle.IsAllocated)
            {
                handle.Free();
            }
        }
    }
}