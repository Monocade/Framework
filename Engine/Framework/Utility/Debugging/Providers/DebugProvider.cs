using System.Diagnostics.CodeAnalysis;
using System;

namespace Engine
{
    // Debug Provider
    public abstract class DebugProvider(App app)
    {
        protected readonly App App = app;
        
        public abstract void Log(string message);
        
        public abstract void Log(object obj);
        
        public abstract void Warning(string message);
        
        public abstract void Warning(object obj);
        
        public abstract void Error(string message);
        
        public abstract void Error(object obj);
        
        public abstract void Assert(bool condition, Exception exception);
        
        public abstract void Assert(bool condition, string message);
        
        public abstract void Assert(bool condition, object obj);
        
        public abstract void Exception(Exception exception);
        
        public abstract void Exception(string message);
        
        public abstract void Exception(object obj);
    }
}