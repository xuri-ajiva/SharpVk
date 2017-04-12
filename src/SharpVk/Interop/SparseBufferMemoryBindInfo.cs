using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct SparseBufferMemoryBindInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public Buffer Buffer; 
        
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
