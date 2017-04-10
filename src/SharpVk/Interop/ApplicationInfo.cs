using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ApplicationInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ApplicationInfo(StructureType sType, void* next, char* applicationName, uint applicationVersion, char* engineName, uint engineVersion, uint apiVersion)
        {
            this.SType = sType;
            this.Next = next;
            this.ApplicationName = applicationName;
            this.ApplicationVersion = applicationVersion;
            this.EngineName = engineName;
            this.EngineVersion = engineVersion;
            this.ApiVersion = apiVersion;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public char* ApplicationName; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ApplicationVersion; 
        
        /// <summary>
        /// 
        /// </summary>
        public char* EngineName; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint EngineVersion; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ApiVersion; 
    }
}
