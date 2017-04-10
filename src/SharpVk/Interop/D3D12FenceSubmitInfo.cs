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
        public D3D12FenceSubmitInfo(StructureType sType, void* next, uint waitSemaphoreValuesCount, ulong* waitSemaphoreValues, uint signalSemaphoreValuesCount, ulong* signalSemaphoreValues)
        {
            this.SType = sType;
            this.Next = next;
            this.WaitSemaphoreValuesCount = waitSemaphoreValuesCount;
            this.WaitSemaphoreValues = waitSemaphoreValues;
            this.SignalSemaphoreValuesCount = signalSemaphoreValuesCount;
            this.SignalSemaphoreValues = signalSemaphoreValues;
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
