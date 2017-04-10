using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ImportMemoryFileDescriptorInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ImportMemoryFileDescriptorInfo(StructureType sType, void* next, ExternalMemoryHandleTypeFlags handleType, int fileDescriptor)
        {
            this.SType = sType;
            this.Next = next;
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
        public ExternalMemoryHandleTypeFlags HandleType; 
        
        /// <summary>
        /// 
        /// </summary>
        public int FileDescriptor; 
    }
}
