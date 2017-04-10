using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ExportSemaphoreCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public ExportSemaphoreCreateInfo(StructureType sType, void* next, ExternalSemaphoreHandleTypeFlags handleTypes)
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
        public ExternalSemaphoreHandleTypeFlags HandleTypes; 
    }
}
