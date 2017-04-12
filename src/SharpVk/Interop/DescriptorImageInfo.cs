using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DescriptorImageInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public Sampler Sampler; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageView ImageView; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout ImageLayout; 
    }
}
