using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ExportMemoryAllocateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ExportMemoryAllocateInfo(StructureType sType, void* next, ExternalMemoryHandleTypeFlags handleTypes)
        {
            this.SType = sType;
            this.Next = next;
            this.HandleTypes = handleTypes;
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
        public ExternalMemoryHandleTypeFlags HandleTypes; 
    }
}
