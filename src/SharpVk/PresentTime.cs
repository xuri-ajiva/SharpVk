using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct PresentTime
    {
        /// <summary>
        /// 
        /// </summary>
        public PresentTime(uint presentID, ulong desiredPresentTime)
        {
            this.PresentID = presentID;
            this.DesiredPresentTime = desiredPresentTime;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PresentID; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DesiredPresentTime; 
    }
}
