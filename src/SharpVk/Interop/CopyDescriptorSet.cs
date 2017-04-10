using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct CopyDescriptorSet
    {
        /// <summary>
        /// 
        /// </summary>
        public CopyDescriptorSet(StructureType sType, void* next, DescriptorSet sourceSet, uint sourceBinding, uint sourceArrayElement, DescriptorSet destinationSet, uint destinationBinding, uint destinationArrayElement, uint descriptorCount)
        {
            this.SType = sType;
            this.Next = next;
            this.SourceSet = sourceSet;
            this.SourceBinding = sourceBinding;
            this.SourceArrayElement = sourceArrayElement;
            this.DestinationSet = destinationSet;
            this.DestinationBinding = destinationBinding;
            this.DestinationArrayElement = destinationArrayElement;
            this.DescriptorCount = descriptorCount;
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
        public DescriptorSet SourceSet; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceBinding; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SourceArrayElement; 
        
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
    }
}
