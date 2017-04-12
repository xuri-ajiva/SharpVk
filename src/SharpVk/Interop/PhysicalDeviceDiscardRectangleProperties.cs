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
