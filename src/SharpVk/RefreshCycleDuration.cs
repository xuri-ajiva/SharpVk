using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public struct RefreshCycleDuration
    {
        /// <summary>
        /// 
        /// </summary>
        public RefreshCycleDuration(ulong refreshDuration)
        {
            this.RefreshDuration = refreshDuration;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong RefreshDuration; 
    }
}
