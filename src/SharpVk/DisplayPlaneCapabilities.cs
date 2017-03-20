using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct DisplayPlaneCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayPlaneCapabilities(DisplayPlaneAlphaFlags supportedAlpha, Offset2D minSourcePosition, Offset2D maxSourcePosition, Extent2D minSourceExtent, Extent2D maxSourceExtent, Offset2D minDestinationPosition, Offset2D maxDestinationPosition, Extent2D minDestinationExtent, Extent2D maxDestinationExtent)
        {
            this.SupportedAlpha = supportedAlpha;
            this.MinSourcePosition = minSourcePosition;
            this.MaxSourcePosition = maxSourcePosition;
            this.MinSourceExtent = minSourceExtent;
            this.MaxSourceExtent = maxSourceExtent;
            this.MinDestinationPosition = minDestinationPosition;
            this.MaxDestinationPosition = maxDestinationPosition;
            this.MinDestinationExtent = minDestinationExtent;
            this.MaxDestinationExtent = maxDestinationExtent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DisplayPlaneAlphaFlags SupportedAlpha; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset2D MinSourcePosition; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset2D MaxSourcePosition; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D MinSourceExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D MaxSourceExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset2D MinDestinationPosition; 
        
        /// <summary>
        /// 
        /// </summary>
        public Offset2D MaxDestinationPosition; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D MinDestinationExtent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Extent2D MaxDestinationExtent; 
    }
}
