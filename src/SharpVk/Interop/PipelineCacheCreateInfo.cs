using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PipelineCacheCreateInfo
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
        public PipelineCacheCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize InitialDataSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* InitialData; 
    }
}
