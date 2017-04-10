using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct WriteDescriptorSet
    {
        /// <summary>
        /// 
        /// </summary>
        public WriteDescriptorSet(StructureType sType, void* next, DescriptorSet destinationSet, uint destinationBinding, uint destinationArrayElement, uint descriptorCount, DescriptorType descriptorType, DescriptorImageInfo* imageInfo, DescriptorBufferInfo* bufferInfo, BufferView* texelBufferView)
        {
            this.SType = sType;
            this.Next = next;
            this.DestinationSet = destinationSet;
            this.DestinationBinding = destinationBinding;
            this.DestinationArrayElement = destinationArrayElement;
            this.DescriptorCount = descriptorCount;
            this.DescriptorType = descriptorType;
            this.ImageInfo = imageInfo;
            this.BufferInfo = bufferInfo;
            this.TexelBufferView = texelBufferView;
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
        public DescriptorSet DestinationSet; 
        
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
        public DescriptorImageInfo* ImageInfo; 
        
        /// <summary>
        /// 
        /// </summary>
        public DescriptorBufferInfo* BufferInfo; 
        
        /// <summary>
        /// 
        /// </summary>
        public BufferView* TexelBufferView; 
    }
}
