using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceCreateInfo
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
        public DeviceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueueCreateInfoCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeviceQueueCreateInfo* QueueCreateInfos; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint EnabledLayerCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public char** EnabledLayerNames; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint EnabledExtensionCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public char** EnabledExtensionNames; 
        
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceFeatures* EnabledFeatures; 
    }
}
