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
        public DescriptorPoolCreateInfo(StructureType sType, void* next, DescriptorPoolCreateFlags flags, uint maxSets, uint poolSizeCount, DescriptorPoolSize* poolSizes)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.MaxSets = maxSets;
            this.PoolSizeCount = poolSizeCount;
            this.PoolSizes = poolSizes;
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
