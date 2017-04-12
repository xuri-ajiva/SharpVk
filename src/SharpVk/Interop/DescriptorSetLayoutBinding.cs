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
