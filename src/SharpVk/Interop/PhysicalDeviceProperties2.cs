using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceProperties2
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceProperties2(StructureType sType, void* next, PhysicalDeviceProperties properties)
        {
            this.SType = sType;
            this.Next = next;
            this.Properties = properties;
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
        public PhysicalDeviceProperties Properties; 
    }
}
