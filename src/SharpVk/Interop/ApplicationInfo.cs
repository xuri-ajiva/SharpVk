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
