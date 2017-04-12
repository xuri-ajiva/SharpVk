using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DescriptorUpdateTemplateCreateInfo
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
        public DescriptorUpdateTemplateCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorUpdateEntryCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorUpdateTemplateEntry* DescriptorUpdateEntries; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorUpdateTemplateType TemplateType; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSetLayout DescriptorSetLayout; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineBindPoint PipelineBindPoint; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineLayout PipelineLayout; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint Set; 
    }
}
