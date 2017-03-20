using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct SurfaceFormat
    {
        /// <summary>
        /// 
        /// </summary>
        public SurfaceFormat(Format format, ColorSpace colorSpace)
        {
            this.Format = format;
            this.ColorSpace = colorSpace;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Format Format; 
        
        /// <summary>
        /// 
        /// </summary>
        public ColorSpace ColorSpace; 
    }
}
