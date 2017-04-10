using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceQueueCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceQueueCreateInfo(StructureType sType, void* next, DeviceQueueCreateFlags flags, uint queueFamilyIndex, uint queueCount, float* queuePriorities)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.QueueFamilyIndex = queueFamilyIndex;
            this.QueueCount = queueCount;
            this.QueuePriorities = queuePriorities;
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
        public DeviceQueueCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueueFamilyIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueueCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public float* QueuePriorities; 
    }
}
