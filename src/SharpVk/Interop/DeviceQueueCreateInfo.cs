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
