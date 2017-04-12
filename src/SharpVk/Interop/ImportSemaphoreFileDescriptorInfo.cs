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
