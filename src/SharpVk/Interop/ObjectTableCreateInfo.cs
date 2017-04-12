using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ObjectTableCreateInfo
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
        public uint ObjectCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ObjectEntryType* ObjectEntryTypes; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint* ObjectEntryCounts; 
        
        /// <summary>
        /// 
        /// </summary>
        public ObjectEntryUsageFlags* ObjectEntryUsageFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUniformBuffersPerDescriptor; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxStorageBuffersPerDescriptor; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxStorageImagesPerDescriptor; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSampledImagesPerDescriptor; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPipelineLayouts; 
    }
}
