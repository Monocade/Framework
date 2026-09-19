using System;

namespace Engine
{
    // SDL Debug Provider
    public sealed class SDLDebugProvider(App app) : DebugProvider(app)
    {
        public override void Log(string message)
        {
            if (message != null)
            {
                SDL_LogInfo(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, message);
            }
        }

        public override void Log(object obj)
        {
            if (obj != null)
            {
                SDL_LogInfo(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, obj.ToString());
            }
        }

        public override void Warning(string message)
        {
            if (message != null)
            {
                SDL_LogWarn(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, message);
            }
        }

        public override void Warning(object obj)
        {
            if (obj != null)
            {
                SDL_LogWarn(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, obj.ToString());
            }
        }

        public override void Error(string message)
        {
            if (message != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, message);
            }
        }

        public override void Error(object obj)
        {
            if (obj != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, obj.ToString());
            }
        }

        public override void Assert(bool condition, Exception exception)
        {
            if (!condition && exception != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, exception.ToString());
                {
                    throw exception;
                }
            }
        }

        public override void Assert(bool condition, string message)
        {
            if (!condition && message != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, message);
            }
        }

        public override void Assert(bool condition, object obj)
        {
            if (!condition && obj != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, obj.ToString());
            }
        }

        public override void Exception(Exception exception)
        {
            if (exception != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, exception.ToString());
                {
                    throw exception;
                }
            }
        }

        public override void Exception(string message)
        {
            if (message != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, message);
            }
        }

        public override void Exception(object obj)
        {
            if (obj != null)
            {
                SDL_LogError(SDL_LogCategory.SDL_LOG_CATEGORY_APPLICATION, obj.ToString());
            }
        }
    }
}