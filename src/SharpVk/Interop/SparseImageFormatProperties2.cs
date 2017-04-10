using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SparseImageFormatProperties2
    {
        /// <summary>
        /// 
        /// </summary>
        public SparseImageFormatProperties2(StructureType sType, void* next, SparseImageFormatProperties properties)
        {
            this.SType = sType;
            this.Next = next;
            this.Properties = properties;
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
        public SparseImageFormatProperties Properties; 
    }
}
