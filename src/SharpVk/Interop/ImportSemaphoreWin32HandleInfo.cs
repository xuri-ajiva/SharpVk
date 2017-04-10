using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImportSemaphoreWin32HandleInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ImportSemaphoreWin32HandleInfo(StructureType sType, void* next, Semaphore semaphore, ExternalSemaphoreHandleTypeFlags handleType, IntPtr handle)
        {
            this.SType = sType;
            this.Next = next;
            this.Semaphore = semaphore;
            this.HandleType = handleType;
            this.Handle = handle;
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
        public Semaphore Semaphore; 
        
        /// <summary>
        /// 
        /// </summary>
        public ExternalSemaphoreHandleTypeFlags HandleType; 
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr Handle; 
    }
}
