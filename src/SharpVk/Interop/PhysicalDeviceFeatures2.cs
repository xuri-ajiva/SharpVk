using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceFeatures2
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceFeatures2(StructureType sType, void* next, PhysicalDeviceFeatures features)
        {
            this.SType = sType;
            this.Next = next;
            this.Features = features;
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
        public PhysicalDeviceFeatures Features; 
    }
}
