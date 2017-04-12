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
