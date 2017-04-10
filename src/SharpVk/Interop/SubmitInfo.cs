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
        public SubmitInfo(StructureType sType, void* next, uint waitSemaphoreCount, Semaphore* waitSemaphores, PipelineStageFlags* waitDestinationStageMask, uint commandBufferCount, CommandBuffer* commandBuffers, uint signalSemaphoreCount, Semaphore* signalSemaphores)
        {
            this.SType = sType;
            this.Next = next;
            this.WaitSemaphoreCount = waitSemaphoreCount;
            this.WaitSemaphores = waitSemaphores;
            this.WaitDestinationStageMask = waitDestinationStageMask;
            this.CommandBufferCount = commandBufferCount;
            this.CommandBuffers = commandBuffers;
            this.SignalSemaphoreCount = signalSemaphoreCount;
            this.SignalSemaphores = signalSemaphores;
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
