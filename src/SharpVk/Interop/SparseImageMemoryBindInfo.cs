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
        public SparseImageMemoryBindInfo(Image image, uint bindCount, SparseImageMemoryBind* binds)
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
        public SparseImageMemoryBind* Binds; 
    }
}
