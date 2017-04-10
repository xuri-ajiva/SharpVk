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
        public DeviceCreateInfo(StructureType sType, void* next, DeviceCreateFlags flags, uint queueCreateInfoCount, DeviceQueueCreateInfo* queueCreateInfos, uint enabledLayerCount, char** enabledLayerNames, uint enabledExtensionCount, char** enabledExtensionNames, PhysicalDeviceFeatures* enabledFeatures)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.QueueCreateInfoCount = queueCreateInfoCount;
            this.QueueCreateInfos = queueCreateInfos;
            this.EnabledLayerCount = enabledLayerCount;
            this.EnabledLayerNames = enabledLayerNames;
            this.EnabledExtensionCount = enabledExtensionCount;
            this.EnabledExtensionNames = enabledExtensionNames;
            this.EnabledFeatures = enabledFeatures;
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
