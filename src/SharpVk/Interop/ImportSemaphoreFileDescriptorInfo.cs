using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImportSemaphoreFileDescriptorInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ImportSemaphoreFileDescriptorInfo(StructureType sType, void* next, Semaphore semaphore, ExternalSemaphoreHandleTypeFlags handleType, int fileDescriptor)
        {
            this.SType = sType;
            this.Next = next;
            this.Semaphore = semaphore;
            this.HandleType = handleType;
            this.FileDescriptor = fileDescriptor;
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
        public int FileDescriptor; 
    }
}
