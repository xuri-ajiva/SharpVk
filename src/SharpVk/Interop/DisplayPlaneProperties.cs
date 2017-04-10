using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DisplayPlaneProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayPlaneProperties(Display currentDisplay, uint currentStackIndex)
        {
            this.CurrentDisplay = currentDisplay;
            this.CurrentStackIndex = currentStackIndex;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Display CurrentDisplay; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint CurrentStackIndex; 
    }
}
