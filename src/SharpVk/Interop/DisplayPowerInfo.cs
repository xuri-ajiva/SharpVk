using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DisplayPowerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayPowerInfo(StructureType sType, void* next, DisplayPowerState powerState)
        {
            this.SType = sType;
            this.Next = next;
            this.PowerState = powerState;
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
        public DisplayPowerState PowerState; 
    }
}
