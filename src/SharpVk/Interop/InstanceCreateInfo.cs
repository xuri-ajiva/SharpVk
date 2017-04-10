using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct InstanceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public InstanceCreateInfo(StructureType sType, void* next, InstanceCreateFlags flags, ApplicationInfo* applicationInfo, uint enabledLayerCount, char** enabledLayerNames, uint enabledExtensionCount, char** enabledExtensionNames)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.ApplicationInfo = applicationInfo;
            this.EnabledLayerCount = enabledLayerCount;
            this.EnabledLayerNames = enabledLayerNames;
            this.EnabledExtensionCount = enabledExtensionCount;
            this.EnabledExtensionNames = enabledExtensionNames;
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
        public InstanceCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public ApplicationInfo* ApplicationInfo; 
        
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
    }
}
