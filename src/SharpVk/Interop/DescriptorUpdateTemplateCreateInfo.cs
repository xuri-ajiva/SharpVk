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
        public DescriptorUpdateTemplateCreateInfo(StructureType sType, void* next, DescriptorUpdateTemplateCreateFlags flags, uint descriptorUpdateEntryCount, DescriptorUpdateTemplateEntry* descriptorUpdateEntries, DescriptorUpdateTemplateType templateType, DescriptorSetLayout descriptorSetLayout, PipelineBindPoint pipelineBindPoint, PipelineLayout pipelineLayout, uint set)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.DescriptorUpdateEntryCount = descriptorUpdateEntryCount;
            this.DescriptorUpdateEntries = descriptorUpdateEntries;
            this.TemplateType = templateType;
            this.DescriptorSetLayout = descriptorSetLayout;
            this.PipelineBindPoint = pipelineBindPoint;
            this.PipelineLayout = pipelineLayout;
            this.Set = set;
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
