using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SparseImageMemoryBindInfo
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
        public SparseImageMemoryBind* Binds; 
    }
}
