using System.Runtime.InteropServices;
using System;

namespace Engine.SDL3
{
    internal static unsafe partial class SDL
    {
        public static int SDL_GetNumAudioDrivers()
        {
            return iSDL_GetNumAudioDrivers();
        }

        public static string SDL_GetAudioDriver(int index)
        {
            return SDL_NativeToString(iSDL_GetAudioDriver(index));
        }

        public static string SDL_GetCurrentAudioDriver()
        {
            return SDL_NativeToString(iSDL_GetCurrentAudioDriver());
        }

        public static uint[] SDL_GetAudioPlaybackDevices(out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetAudioPlaybackDevices(&size), size, out count);
            }
        }

        public static uint[] SDL_GetAudioRecordingDevices(out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetAudioRecordingDevices(&size), size, out count);
            }
        }

        public static string SDL_GetAudioDeviceName(uint audioDeviceID)
        {
            return SDL_NativeToString(iSDL_GetAudioDeviceName(audioDeviceID));
        }

        public static bool SDL_GetAudioDeviceFormat(uint audioDeviceID, out SDL_AudioSpec spec, out int sample_frames)
        {
            fixed (SDL_AudioSpec* ptr1 = &spec)
            fixed (int* ptr2 = &sample_frames)
            {
                return iSDL_GetAudioDeviceFormat(audioDeviceID, ptr1, ptr2);
            }
        }

        public static int[] SDL_GetAudioDeviceChannelMap(uint audioDeviceID, out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetAudioDeviceChannelMap(audioDeviceID, &size), size, out count);
            }
        }

        public static uint SDL_OpenAudioDevice(uint audioDeviceID, SDL_AudioSpec* spec)
        {
            return iSDL_OpenAudioDevice(audioDeviceID, spec);
        }

        public static bool SDL_IsAudioDevicePhysical(uint audioDeviceID)
        {
            return iSDL_IsAudioDevicePhysical(audioDeviceID);
        }

        public static bool SDL_IsAudioDevicePlayback(uint audioDeviceID)
        {
            return iSDL_IsAudioDevicePlayback(audioDeviceID);
        }

        public static bool SDL_PauseAudioDevice(uint audioDeviceID)
        {
            return iSDL_PauseAudioDevice(audioDeviceID);
        }

        public static bool SDL_ResumeAudioDevice(uint audioDeviceID)
        {
            return iSDL_ResumeAudioDevice(audioDeviceID);
        }

        public static bool SDL_AudioDevicePaused(uint audioDeviceID)
        {
            return iSDL_AudioDevicePaused(audioDeviceID);
        }

        public static float SDL_GetAudioDeviceGain(uint audioDeviceID)
        {
            return iSDL_GetAudioDeviceGain(audioDeviceID);
        }

        public static bool SDL_SetAudioDeviceGain(uint audioDeviceID, float gain)
        {
            return iSDL_SetAudioDeviceGain(audioDeviceID, gain);
        }

        public static void SDL_CloseAudioDevice(uint audioDeviceID)
        {
            iSDL_CloseAudioDevice(audioDeviceID);
        }

        public static bool SDL_BindAudioStreams(uint audioDeviceID, SDL_AudioStream*[] streams, int num_streams)
        {
            fixed (SDL_AudioStream** ptr1 = streams)
            {
                return iSDL_BindAudioStreams(audioDeviceID, ptr1, num_streams);
            }
        }

        public static bool SDL_BindAudioStream(uint audioDeviceID, SDL_AudioStream* stream)
        {
            return iSDL_BindAudioStream(audioDeviceID, stream);
        }

        public static void SDL_UnbindAudioStreams(SDL_AudioStream*[] streams, int num_streams)
        {
            fixed (SDL_AudioStream** ptr1 = streams)
            {
                iSDL_UnbindAudioStreams(ptr1, num_streams);
            }
        }

        public static void SDL_UnbindAudioStream(SDL_AudioStream* stream)
        {
            iSDL_UnbindAudioStream(stream);
        }

        public static uint SDL_GetAudioStreamDevice(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamDevice(stream);
        }

        public static SDL_AudioStream* SDL_CreateAudioStream(SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec)
        {
            return iSDL_CreateAudioStream(src_spec, dst_spec);
        }

        public static uint SDL_GetAudioStreamProperties(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamProperties(stream);
        }

        public static bool SDL_GetAudioStreamFormat(SDL_AudioStream* stream, out SDL_AudioSpec src_spec, out SDL_AudioSpec dst_spec)
        {
            fixed (SDL_AudioSpec* ptr1 = &src_spec)
            fixed (SDL_AudioSpec* ptr2 = &dst_spec)
            {
                return iSDL_GetAudioStreamFormat(stream, ptr1, ptr2);
            }
        }

        public static bool SDL_SetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec)
        {
            return iSDL_SetAudioStreamFormat(stream, src_spec, dst_spec);
        }

        public static float SDL_GetAudioStreamFrequencyRatio(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamFrequencyRatio(stream);
        }

        public static bool SDL_SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio)
        {
            return iSDL_SetAudioStreamFrequencyRatio(stream, ratio);
        }

        public static float SDL_GetAudioStreamGain(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamGain(stream);
        }

        public static bool SDL_SetAudioStreamGain(SDL_AudioStream* stream, float gain)
        {
            return iSDL_SetAudioStreamGain(stream, gain);
        }

        public static int[] SDL_GetAudioStreamInputChannelMap(SDL_AudioStream* stream, out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetAudioStreamInputChannelMap(stream, &size), size, out count);
            }
        }

        public static int[] SDL_GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, out int count)
        {
            int size = 0;
            {
                return SDL_NativeToArray(iSDL_GetAudioStreamOutputChannelMap(stream, &size), size, out count);
            }
        }

        public static bool SDL_SetAudioStreamInputChannelMap(SDL_AudioStream* stream, int[] chmap, int count)
        {
            fixed (int* ptr1 = chmap)
            {
                return iSDL_SetAudioStreamInputChannelMap(stream, ptr1, count);
            }
        }

        public static bool SDL_SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int[] chmap, int count)
        {
            fixed (int* ptr1 = chmap)
            {
                return iSDL_SetAudioStreamOutputChannelMap(stream, ptr1, count);
            }
        }

        public static bool SDL_PutAudioStreamData(SDL_AudioStream* stream, IntPtr buf, int len)
        {
            return iSDL_PutAudioStreamData(stream, buf, len);
        }

        public static bool SDL_PutAudioStreamDataNoCopy(SDL_AudioStream* stream, IntPtr buf, int len, SDL_AudioStreamDataCompleteCallback callback, IntPtr userdata)
        {
            return iSDL_PutAudioStreamDataNoCopy(stream, buf, len, Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static bool SDL_PutAudioStreamPlanarData(SDL_AudioStream* stream, IntPtr[] channel_buffers, int num_channels, int num_samples)
        {
            fixed (IntPtr* ptr1 = channel_buffers)
            {
                return iSDL_PutAudioStreamPlanarData(stream, ptr1, num_channels, num_samples);
            }
        }

        public static int SDL_GetAudioStreamData(SDL_AudioStream* stream, IntPtr buf, int len)
        {
            return iSDL_GetAudioStreamData(stream, buf, len);
        }

        public static int SDL_GetAudioStreamAvailable(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamAvailable(stream);
        }

        public static int SDL_GetAudioStreamQueued(SDL_AudioStream* stream)
        {
            return iSDL_GetAudioStreamQueued(stream);
        }

        public static bool SDL_FlushAudioStream(SDL_AudioStream* stream)
        {
            return iSDL_FlushAudioStream(stream);
        }

        public static bool SDL_ClearAudioStream(SDL_AudioStream* stream)
        {
            return iSDL_ClearAudioStream(stream);
        }

        public static bool SDL_PauseAudioStreamDevice(SDL_AudioStream* stream)
        {
            return iSDL_PauseAudioStreamDevice(stream);
        }

        public static bool SDL_ResumeAudioStreamDevice(SDL_AudioStream* stream)
        {
            return iSDL_ResumeAudioStreamDevice(stream);
        }

        public static bool SDL_AudioStreamDevicePaused(SDL_AudioStream* stream)
        {
            return iSDL_AudioStreamDevicePaused(stream);
        }

        public static bool SDL_LockAudioStream(SDL_AudioStream* stream)
        {
            return iSDL_LockAudioStream(stream);
        }

        public static bool SDL_UnlockAudioStream(SDL_AudioStream* stream)
        {
            return iSDL_UnlockAudioStream(stream);
        }

        public static bool SDL_SetAudioStreamGetCallback(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, IntPtr userdata)
        {
            return iSDL_SetAudioStreamGetCallback(stream, Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static bool SDL_SetAudioStreamPutCallback(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, IntPtr userdata)
        {
            return iSDL_SetAudioStreamPutCallback(stream, Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static void SDL_DestroyAudioStream(SDL_AudioStream* stream)
        {
            iSDL_DestroyAudioStream(stream);
        }

        public static SDL_AudioStream* SDL_OpenAudioDeviceStream(uint audioDeviceID, SDL_AudioSpec* spec, SDL_AudioStreamCallback callback, IntPtr userdata)
        {
            return iSDL_OpenAudioDeviceStream(audioDeviceID, spec, Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static bool SDL_SetAudioPostmixCallback(uint audioDeviceID, SDL_AudioPostmixCallback callback, IntPtr userdata)
        {
            return iSDL_SetAudioPostmixCallback(audioDeviceID, Marshal.GetFunctionPointerForDelegate(callback), userdata);
        }

        public static bool SDL_LoadWAV_IO(SDL_IOStream* src, bool closeio, out SDL_AudioSpec spec, out IntPtr audio_buf, out uint audio_len)
        {
            fixed (SDL_AudioSpec* ptr1 = &spec)
            fixed (IntPtr* ptr2 = &audio_buf)
            fixed (uint* ptr3 = &audio_len)
            {
                return iSDL_LoadWAV_IO(src, closeio, ptr1, (byte**)ptr2, ptr3);
            }
        }

        public static bool SDL_LoadWAV(string path, out SDL_AudioSpec spec, out IntPtr audio_buf, out uint audio_len)
        {
            fixed (byte* ptr1 = SDL_StringToNative(path))
            fixed (SDL_AudioSpec* ptr2 = &spec)
            fixed (IntPtr* ptr3 = &audio_buf)
            fixed (uint* ptr4 = &audio_len)
            {
                return iSDL_LoadWAV(ptr1, ptr2, (byte**)ptr3, ptr4);
            }
        }

        public static bool SDL_MixAudio(IntPtr dst, IntPtr src, SDL_AudioFormat format, uint len, float volume)
        {
            return iSDL_MixAudio((byte*)dst, (byte*)src, format, len, volume);
        }

        public static bool SDL_ConvertAudioSamples(SDL_AudioSpec* src_spec, IntPtr src_data, int src_len, SDL_AudioSpec* dst_spec, out IntPtr dst_data, out int dst_len)
        {
            fixed (IntPtr* ptr1 = &dst_data)
            fixed (int* ptr2 = &dst_len)
            {
                return iSDL_ConvertAudioSamples(src_spec, (byte*)src_data, src_len, dst_spec, (byte**)ptr1, ptr2);
            }
        }

        public static string SDL_GetAudioFormatName(SDL_AudioFormat format)
        {
            return SDL_NativeToString(iSDL_GetAudioFormatName(format));
        }

        public static int SDL_GetSilenceValueForFormat(SDL_AudioFormat format)
        {
            return iSDL_GetSilenceValueForFormat(format);
        }
    }
}