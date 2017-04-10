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
        public DescriptorSetLayoutCreateInfo(StructureType sType, void* next, DescriptorSetLayoutCreateFlags flags, uint bindingCount, DescriptorSetLayoutBinding* bindings)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.BindingCount = bindingCount;
            this.Bindings = bindings;
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
