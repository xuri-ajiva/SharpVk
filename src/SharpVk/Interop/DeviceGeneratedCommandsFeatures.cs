using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DeviceGeneratedCommandsFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceGeneratedCommandsFeatures(StructureType sType, void* next, Bool32 computeBindingPointSupport)
        {
            this.SType = sType;
            this.Next = next;
            this.ComputeBindingPointSupport = computeBindingPointSupport;
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
        public Bool32 ComputeBindingPointSupport; 
    }
}
