using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct DescriptorPoolSize
    {
        /// <summary>
        /// 
        /// </summary>
        public DescriptorPoolSize(DescriptorType type, uint descriptorCount)
        {
            this.Type = type;
            this.DescriptorCount = descriptorCount;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorType Type; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorCount; 
    }
}
