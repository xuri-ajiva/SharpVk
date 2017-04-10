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
        public ObjectTableCreateInfo(StructureType sType, void* next, uint objectCount, ObjectEntryType* objectEntryTypes, uint* objectEntryCounts, ObjectEntryUsageFlags* objectEntryUsageFlags, uint maxUniformBuffersPerDescriptor, uint maxStorageBuffersPerDescriptor, uint maxStorageImagesPerDescriptor, uint maxSampledImagesPerDescriptor, uint maxPipelineLayouts)
        {
            this.SType = sType;
            this.Next = next;
            this.ObjectCount = objectCount;
            this.ObjectEntryTypes = objectEntryTypes;
            this.ObjectEntryCounts = objectEntryCounts;
            this.ObjectEntryUsageFlags = objectEntryUsageFlags;
            this.MaxUniformBuffersPerDescriptor = maxUniformBuffersPerDescriptor;
            this.MaxStorageBuffersPerDescriptor = maxStorageBuffersPerDescriptor;
            this.MaxStorageImagesPerDescriptor = maxStorageImagesPerDescriptor;
            this.MaxSampledImagesPerDescriptor = maxSampledImagesPerDescriptor;
            this.MaxPipelineLayouts = maxPipelineLayouts;
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
