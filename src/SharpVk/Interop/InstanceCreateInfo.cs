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
