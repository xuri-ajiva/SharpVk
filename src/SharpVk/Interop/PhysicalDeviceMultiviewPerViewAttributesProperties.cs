using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct PhysicalDeviceMultiviewPerViewAttributesProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public PhysicalDeviceMultiviewPerViewAttributesProperties(StructureType sType, void* next, Bool32 perViewPositionAllComponents)
        {
            this.SType = sType;
            this.Next = next;
            this.PerViewPositionAllComponents = perViewPositionAllComponents;
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
        public Bool32 PerViewPositionAllComponents; 
    }
}
