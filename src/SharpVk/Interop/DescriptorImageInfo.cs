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
        public DescriptorImageInfo(Sampler sampler, ImageView imageView, ImageLayout imageLayout)
        {
            this.Sampler = sampler;
            this.ImageView = imageView;
            this.ImageLayout = imageLayout;
        }
        
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
