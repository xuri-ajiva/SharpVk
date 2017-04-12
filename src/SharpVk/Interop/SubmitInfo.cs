using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SubmitInfo
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
        public uint WaitSemaphoreCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Semaphore* WaitSemaphores; 
        
        /// <summary>
        /// 
        /// </summary>
        public PipelineStageFlags* WaitDestinationStageMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CommandBufferCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public CommandBuffer* CommandBuffers; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SignalSemaphoreCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public Semaphore* SignalSemaphores; 
    }
}
