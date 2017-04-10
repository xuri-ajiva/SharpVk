using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DisplayModeProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayModeProperties(DisplayMode displayMode, DisplayModeParameters parameters)
        {
            this.DisplayMode = displayMode;
            this.Parameters = parameters;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public DisplayMode DisplayMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public DisplayModeParameters Parameters; 
    }
}
