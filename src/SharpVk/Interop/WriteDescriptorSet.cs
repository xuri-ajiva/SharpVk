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
