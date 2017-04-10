using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DebugMarkerMarkerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DebugMarkerMarkerInfo(StructureType sType, void* next, char* markerName, float color)
        {
            this.SType = sType;
            this.Next = next;
            this.MarkerName = markerName;
            this.Color = color;
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
        public char* MarkerName; 
        
        /// <summary>
        /// 
        /// </summary>
        public float Color; 
    }
}
