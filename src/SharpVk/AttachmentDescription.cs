using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct AttachmentDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public AttachmentDescription(AttachmentDescriptionFlags flags, Format format, SampleCountFlags samples, AttachmentLoadOp loadOp, AttachmentStoreOp storeOp, AttachmentLoadOp stencilLoadOp, AttachmentStoreOp stencilStoreOp, ImageLayout initialLayout, ImageLayout finalLayout)
        {
            this.Flags = flags;
            this.Format = format;
            this.Samples = samples;
            this.LoadOp = loadOp;
            this.StoreOp = storeOp;
            this.StencilLoadOp = stencilLoadOp;
            this.StencilStoreOp = stencilStoreOp;
            this.InitialLayout = initialLayout;
            this.FinalLayout = finalLayout;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentDescriptionFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// 
        /// </summary>
        public SampleCountFlags Samples; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentLoadOp LoadOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentStoreOp StoreOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentLoadOp StencilLoadOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public AttachmentStoreOp StencilStoreOp; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout InitialLayout; 
        
        /// <summary>
        /// 
        /// </summary>
        public ImageLayout FinalLayout; 
    }
}
