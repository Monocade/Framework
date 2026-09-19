using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System;

namespace Engine
{
    // Debug
    public sealed class Debug(App App, DebugProvider provider) : Module(App)
    {
        public void Log(string message)
        {
            provider.Log(message);
        }
        
        public void Log(object obj)
        {
            provider.Log(obj);
        }
        
        public void Warning(string message)
        {
            provider.Warning(message);
        }
        
        public void Warning(object obj)
        {
            provider.Warning(obj);
        }
        
        public void Error(string message)
        {
            provider.Error(message);
        }
        
        public void Error(object obj)
        {
            provider.Error(obj);
        }
        
        public void Assert(bool condition, Exception exception)
        {
            provider.Assert(condition, exception);
        }
        
        public void Assert(bool condition, string message)
        {
            provider.Assert(condition, message);
        }
        
        public void Assert(bool condition, object obj)
        {
            provider.Assert(condition, obj);
        }
        
        public void Exception(Exception exception)
        {
            provider.Exception(exception);
        }
        
        public void Exception(string message)
        {
            provider.Exception(message);
        }
        
        public void Exception(object obj)
        {
            provider.Exception(obj);
        }
    }
}