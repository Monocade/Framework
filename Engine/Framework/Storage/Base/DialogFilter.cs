using System;

namespace Engine
{
    public struct DialogFilter
    {
        public string Name;
        public string Pattern;

        
        public DialogFilter(string name, string pattern)
        {
            this.Name = name;
            this.Pattern = pattern;
        }
    }
}