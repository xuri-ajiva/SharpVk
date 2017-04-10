using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceDiscardRectangleProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceDiscardRectangleProperties(StructureType sType, void* next, uint maxDiscardRectangles)
        {
            this.SType = sType;
            this.Next = next;
            this.MaxDiscardRectangles = maxDiscardRectangles;
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
        public uint MaxDiscardRectangles; 
    }
}
