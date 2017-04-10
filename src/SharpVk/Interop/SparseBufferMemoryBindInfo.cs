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
        public SparseBufferMemoryBindInfo(Buffer buffer, uint bindCount, SparseMemoryBind* binds)
        {
            this.Buffer = buffer;
            this.BindCount = bindCount;
            this.Binds = binds;
        }
        
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
