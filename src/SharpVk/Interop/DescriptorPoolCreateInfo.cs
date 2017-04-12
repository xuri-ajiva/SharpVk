using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DescriptorPoolCreateInfo
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
        public DescriptorPoolCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSets; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PoolSizeCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorPoolSize* PoolSizes; 
    }
}
