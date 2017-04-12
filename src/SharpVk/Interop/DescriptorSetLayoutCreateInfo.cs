using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DescriptorSetLayoutCreateInfo
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
        public DescriptorSetLayoutCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BindingCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSetLayoutBinding* Bindings; 
    }
}
