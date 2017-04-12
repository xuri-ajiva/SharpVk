using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct D3D12FenceSubmitInfo
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
        public uint WaitSemaphoreValuesCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong* WaitSemaphoreValues; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SignalSemaphoreValuesCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong* SignalSemaphoreValues; 
    }
}
