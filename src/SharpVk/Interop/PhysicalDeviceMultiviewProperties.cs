using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceMultiviewProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceMultiviewProperties(StructureType sType, void* next, uint maxMultiviewViewCount, uint maxMultiviewInstanceIndex)
        {
            this.SType = sType;
            this.Next = next;
            this.MaxMultiviewViewCount = maxMultiviewViewCount;
            this.MaxMultiviewInstanceIndex = maxMultiviewInstanceIndex;
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
        public uint MaxMultiviewViewCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxMultiviewInstanceIndex; 
    }
}
