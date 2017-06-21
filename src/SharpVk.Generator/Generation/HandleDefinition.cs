using System.Collections.Generic;

namespace SharpVk.Generator.Generation
{
    public class HandleDefinition
    {
        public string Name;
        public string Parent;
        public string[] Namespace;
        public string[] ParentNamespace;
        public bool IsDispatch;
        public List<MethodDefinition> Commands;
        public List<string> Interfaces;
    }
}
