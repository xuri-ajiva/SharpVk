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
        public SparseImageOpaqueMemoryBindInfo(Image image, uint bindCount, SparseMemoryBind* binds)
        {
            this.Image = image;
            this.BindCount = bindCount;
            this.Binds = binds;
        }
        
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
