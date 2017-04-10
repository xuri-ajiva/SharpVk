using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DescriptorSetAllocateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSetAllocateInfo(StructureType sType, void* next, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSetLayout* setLayouts)
        {
            this.SType = sType;
            this.Next = next;
            this.DescriptorPool = descriptorPool;
            this.DescriptorSetCount = descriptorSetCount;
            this.SetLayouts = setLayouts;
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
        public DescriptorPool DescriptorPool; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorSetCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSetLayout* SetLayouts; 
    }
}
