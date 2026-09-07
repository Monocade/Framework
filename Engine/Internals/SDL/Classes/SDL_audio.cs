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
            return SDL_Utf8ToString(iSDL_GetAudioDriver(index));
        }

        public static string SDL_GetCurrentAudioDriver()
        {
            return SDL_Utf8ToString(iSDL_GetCurrentAudioDriver());
        }

        public static uint[] SDL_GetAudioPlaybackDevices(out int count)
        {
            return SDL_PointerToArray(iSDL_GetAudioPlaybackDevices(null), out count);
        }

        public static uint[] SDL_GetAudioRecordingDevices(out int count)
        {
            return SDL_PointerToArray(iSDL_GetAudioRecordingDevices(null), out count);
        }

        public static string SDL_GetAudioDeviceName(uint devid)
        {
            return SDL_Utf8ToString(iSDL_GetAudioDeviceName(devid));
        }

        public static bool SDL_GetAudioDeviceFormat(uint devid, out SDL_AudioSpec spec, out int sample_frames)
        {
            fixed (SDL_AudioSpec* ptr1 = &spec)
            fixed (int* ptr2 = &sample_frames)
            {
                return iSDL_GetAudioDeviceFormat(devid, ptr1, ptr2);
            }
        }

        public static int[] SDL_GetAudioDeviceChannelMap(uint devid, out int count)
        {
            return SDL_PointerToArray(iSDL_GetAudioDeviceChannelMap(devid, null), out count);
        }

        public static uint SDL_OpenAudioDevice(uint devid, ref SDL_AudioSpec spec)
        {
            fixed (SDL_AudioSpec* ptr1 = &spec)
            {
                return iSDL_OpenAudioDevice(devid, ptr1);
            }
        }

        public static bool SDL_IsAudioDevicePhysical(uint devid)
        {
            return iSDL_IsAudioDevicePhysical(devid);
        }

        public static bool SDL_IsAudioDevicePlayback(uint devid)
        {
            return iSDL_IsAudioDevicePlayback(devid);
        }

        public static bool SDL_PauseAudioDevice(uint devid)
        {
            return iSDL_PauseAudioDevice(devid);
        }

        public static bool SDL_ResumeAudioDevice(uint devid)
        {
            return iSDL_ResumeAudioDevice(devid);
        }

        public static bool SDL_AudioDevicePaused(uint devid)
        {
            return iSDL_AudioDevicePaused(devid);
        }

        public static float SDL_GetAudioDeviceGain(uint devid)
        {
            return iSDL_GetAudioDeviceGain(devid);
        }

        public static bool SDL_SetAudioDeviceGain(uint devid, float gain)
        {
            return iSDL_SetAudioDeviceGain(devid, gain);
        }

        public static void SDL_CloseAudioDevice(uint devid)
        {
            iSDL_CloseAudioDevice(devid);
        }

        public static bool SDL_BindAudioStreams(uint devid, SDL_AudioStream*[] streams)
        {
            fixed (SDL_AudioStream** ptr1 = streams)
            {
                return iSDL_BindAudioStreams(devid, ptr1, streams.Length);
            }
        }

        public static bool SDL_BindAudioStream(uint devid, SDL_AudioStream* stream)
        {
            return iSDL_BindAudioStream(devid, stream);
        }

        public static void SDL_UnbindAudioStreams(SDL_AudioStream*[] streams)
        {
            fixed (SDL_AudioStream** ptr1 = streams)
            {
                iSDL_UnbindAudioStreams(ptr1, streams.Length);
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

        public static bool SDL_GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec)
        {
            return iSDL_GetAudioStreamFormat(stream, src_spec, dst_spec);
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

        public static int* SDL_GetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* count)
        {
            return iSDL_GetAudioStreamInputChannelMap(stream, count);
        }

        public static int* SDL_GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* count)
        {
            return iSDL_GetAudioStreamOutputChannelMap(stream, count);
        }

        public static bool SDL_SetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* chmap, int count)
        {
            return iSDL_SetAudioStreamInputChannelMap(stream, chmap, count);
        }

        public static bool SDL_SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* chmap, int count)
        {
            return iSDL_SetAudioStreamOutputChannelMap(stream, chmap, count);
        }

        public static bool SDL_PutAudioStreamData(SDL_AudioStream* stream, void* buf, int len)
        {
            return iSDL_PutAudioStreamData(stream, buf, len);
        }

        public static bool SDL_PutAudioStreamDataNoCopy(SDL_AudioStream* stream, void* buf, int len, IntPtr callback, void* userdata)
        {
            return iSDL_PutAudioStreamDataNoCopy(stream, buf, len, callback, userdata);
        }

        public static bool SDL_PutAudioStreamPlanarData(SDL_AudioStream* stream, void** channel_buffers, int num_channels, int num_samples)
        {
            return iSDL_PutAudioStreamPlanarData(stream, channel_buffers, num_channels, num_samples);
        }

        public static int SDL_GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len)
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

        public static bool SDL_SetAudioStreamGetCallback(SDL_AudioStream* stream, IntPtr callback, void* userdata)
        {
            return iSDL_SetAudioStreamGetCallback(stream, callback, userdata);
        }

        public static bool SDL_SetAudioStreamPutCallback(SDL_AudioStream* stream, IntPtr callback, void* userdata)
        {
            return iSDL_SetAudioStreamPutCallback(stream, callback, userdata);
        }

        public static void SDL_DestroyAudioStream(SDL_AudioStream* stream)
        {
            iSDL_DestroyAudioStream(stream);
        }

        public static SDL_AudioStream* SDL_OpenAudioDeviceStream(uint devid, SDL_AudioSpec* spec, IntPtr callback, void* userdata)
        {
            return iSDL_OpenAudioDeviceStream(devid, spec, callback, userdata);
        }

        public static bool SDL_SetAudioPostmixCallback(uint devid, IntPtr callback, void* userdata)
        {
            return iSDL_SetAudioPostmixCallback(devid, callback, userdata);
        }

        public static bool SDL_LoadWAV_IO(SDL_IOStream* src, bool closeio, SDL_AudioSpec* spec, byte** audio_buf, uint* audio_len)
        {
            return iSDL_LoadWAV_IO(src, closeio, spec, audio_buf, audio_len);
        }

        public static bool SDL_LoadWAV(byte* path, SDL_AudioSpec* spec, byte** audio_buf, uint* audio_len)
        {
            return iSDL_LoadWAV(path, spec, audio_buf, audio_len);
        }

        public static bool SDL_MixAudio(byte* dst, byte* src, SDL_AudioFormat format, uint len, float volume)
        {
            return iSDL_MixAudio(dst, src, format, len, volume);
        }

        public static bool SDL_ConvertAudioSamples(SDL_AudioSpec* src_spec, byte* src_data, int src_len, SDL_AudioSpec* dst_spec, byte** dst_data, int* dst_len)
        {
            return iSDL_ConvertAudioSamples(src_spec, src_data, src_len, dst_spec, dst_data, dst_len);
        }

        public static byte* SDL_GetAudioFormatName(SDL_AudioFormat format)
        {
            return iSDL_GetAudioFormatName(format);
        }

        public static int SDL_GetSilenceValueForFormat(SDL_AudioFormat format)
        {
            return iSDL_GetSilenceValueForFormat(format);
        }
    }
}