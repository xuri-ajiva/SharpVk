using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DescriptorSetLayoutBinding
    {
        /// <summary>
        /// 
        /// </summary>
        public DescriptorSetLayoutBinding(uint binding, DescriptorType descriptorType, uint descriptorCount, ShaderStageFlags stageFlags, Sampler* immutableSamplers)
        {
            this.Binding = binding;
            this.DescriptorType = descriptorType;
            this.DescriptorCount = descriptorCount;
            this.StageFlags = stageFlags;
            this.ImmutableSamplers = immutableSamplers;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Binding; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorType DescriptorType; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ShaderStageFlags StageFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Sampler* ImmutableSamplers; 
    }
}
