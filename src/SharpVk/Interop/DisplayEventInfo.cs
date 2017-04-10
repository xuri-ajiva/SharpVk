using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DisplayEventInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayEventInfo(StructureType sType, void* next, DisplayEventType displayEvent)
        {
            this.SType = sType;
            this.Next = next;
            this.DisplayEvent = displayEvent;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public DisplayEventType DisplayEvent; 
    }
}
