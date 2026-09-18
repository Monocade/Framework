using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System;

namespace Engine
{
    // Debug
    public sealed partial class Debug(App App) : Module(App)
    {
        internal override void Initialize()
        {
            base.Initialize();
            {
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_INFO, "");
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_WARN, "");
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_ERROR, "");
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_CRITICAL, "");
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_COUNT, "");
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_DEBUG, "");
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_INVALID, "");
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_TRACE, "");
                SDL_SetLogPriorityPrefix(SDL_LogPriority.SDL_LOG_PRIORITY_VERBOSE, "");
            }
        }
    }
    
    // API
    public partial class Debug
    {
        [DebuggerHidden]
        [StackTraceHidden]
        public void Log(string message)
        {
            if (message != null)
            {
                SDL_LogInfo(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, $"{message}");
            }
        }
        
        [DebuggerHidden]
        [StackTraceHidden]
        public void Log(object message)
        {
            if (message != null)
            {
                SDL_LogInfo(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, $"{message}");
            }
        }
        
        
        [DebuggerHidden]
        [StackTraceHidden]
        public void Warning(string message)
        {
            if (message != null)
            {
                SDL_LogWarn(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, $"{message}");
            }
        }
        
        [DebuggerHidden]
        [StackTraceHidden]
        public void Warning(object message)
        {
            if (message != null)
            {
                SDL_LogWarn(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, $"{message}");
            }
        }
        
        
        [DebuggerHidden]
        [StackTraceHidden]
        public void Error(string message)
        {
            if (message != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_ERROR, $"{message}");
            }
        }
        
        [DebuggerHidden]
        [StackTraceHidden]
        public void Error(object message)
        {
            if (message != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_ERROR, $"{message}");
            }
        }
        
        
        [DebuggerHidden]
        [StackTraceHidden]
        public void Assert([DoesNotReturnIf(false)] bool condition, Exception exception)
        {
            if (!condition)
            {
                throw exception;
            }
        }
        
        [DebuggerHidden]
        [StackTraceHidden]
        public void Assert([DoesNotReturnIf(false)] bool condition, string message)
        {
            if (!condition)
            {
                throw new Exception($"{message}");
            }
        }
        
        [DebuggerHidden]
        [StackTraceHidden]
        public void Assert([DoesNotReturnIf(false)] bool condition, object message)
        {
            if (!condition)
            {
                throw new Exception($"{message}");
            }
        }
        
        
        [DoesNotReturn]
        [DebuggerHidden]
        [StackTraceHidden]
        public void Exception(Exception exception)
        {
            throw exception;
        }
        
        [DoesNotReturn]
        [DebuggerHidden]
        [StackTraceHidden]
        public void Exception(string message)
        {
            throw new Exception($"{message}");
        }
        
        [DoesNotReturn]
        [DebuggerHidden]
        [StackTraceHidden]
        public void Exception(object message)
        {
            throw new Exception($"{message}");
        }
    }
}