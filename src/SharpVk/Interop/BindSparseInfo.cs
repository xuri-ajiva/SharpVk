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
