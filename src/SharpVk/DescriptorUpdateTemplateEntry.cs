using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct DescriptorUpdateTemplateEntry
    {
        /// <summary>
        /// 
        /// </summary>
        public DescriptorUpdateTemplateEntry(uint destinationBinding, uint destinationArrayElement, uint descriptorCount, DescriptorType descriptorType, HostSize offset, HostSize stride)
        {
            this.DestinationBinding = destinationBinding;
            this.DestinationArrayElement = destinationArrayElement;
            this.DescriptorCount = descriptorCount;
            this.DescriptorType = descriptorType;
            this.Offset = offset;
            this.Stride = stride;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationBinding; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DestinationArrayElement; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DescriptorCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorType DescriptorType; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize Offset; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize Stride; 
    }
}
