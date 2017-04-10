using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct BindSparseInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public BindSparseInfo(StructureType sType, void* next, uint waitSemaphoreCount, Semaphore* waitSemaphores, uint bufferBindCount, SparseBufferMemoryBindInfo* bufferBinds, uint imageOpaqueBindCount, SparseImageOpaqueMemoryBindInfo* imageOpaqueBinds, uint imageBindCount, SparseImageMemoryBindInfo* imageBinds, uint signalSemaphoreCount, Semaphore* signalSemaphores)
        {
            this.SType = sType;
            this.Next = next;
            this.WaitSemaphoreCount = waitSemaphoreCount;
            this.WaitSemaphores = waitSemaphores;
            this.BufferBindCount = bufferBindCount;
            this.BufferBinds = bufferBinds;
            this.ImageOpaqueBindCount = imageOpaqueBindCount;
            this.ImageOpaqueBinds = imageOpaqueBinds;
            this.ImageBindCount = imageBindCount;
            this.ImageBinds = imageBinds;
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
        public uint BufferBindCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SparseBufferMemoryBindInfo* BufferBinds; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageOpaqueBindCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SparseImageOpaqueMemoryBindInfo* ImageOpaqueBinds; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint ImageBindCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SparseImageMemoryBindInfo* ImageBinds; 
        
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
