using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct PastPresentationTiming
    {
        /// <summary>
        /// 
        /// </summary>
        public PastPresentationTiming(uint presentID, ulong desiredPresentTime, ulong actualPresentTime, ulong earliestPresentTime, ulong presentMargin)
        {
            this.PresentID = presentID;
            this.DesiredPresentTime = desiredPresentTime;
            this.ActualPresentTime = actualPresentTime;
            this.EarliestPresentTime = earliestPresentTime;
            this.PresentMargin = presentMargin;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint PresentID; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DesiredPresentTime; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong ActualPresentTime; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong EarliestPresentTime; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong PresentMargin; 
    }
}
