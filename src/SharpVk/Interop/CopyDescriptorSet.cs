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
