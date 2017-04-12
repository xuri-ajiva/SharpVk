using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SparseImageOpaqueMemoryBindInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public Image Image; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BindCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public SparseMemoryBind* Binds; 
    }
}
