using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDevicePushDescriptorProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDevicePushDescriptorProperties(StructureType sType, void* next, uint maxPushDescriptors)
        {
            this.SType = sType;
            this.Next = next;
            this.MaxPushDescriptors = maxPushDescriptors;
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
        public uint MaxPushDescriptors; 
    }
}
