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
        public PipelineCacheCreateInfo(StructureType sType, void* next, PipelineCacheCreateFlags flags, HostSize initialDataSize, void* initialData)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.InitialDataSize = initialDataSize;
            this.InitialData = initialData;
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
