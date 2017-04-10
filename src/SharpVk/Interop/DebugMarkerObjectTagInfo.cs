using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DebugMarkerObjectTagInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DebugMarkerObjectTagInfo(StructureType sType, void* next, DebugReportObjectType objectType, ulong @Object, ulong tagName, HostSize tagSize, void* tag)
        {
            this.SType = sType;
            this.Next = next;
            this.ObjectType = objectType;
            this.@Object = @Object;
            this.TagName = tagName;
            this.TagSize = tagSize;
            this.Tag = tag;
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
        public DebugReportObjectType ObjectType; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong @Object; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong TagName; 
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize TagSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Tag; 
    }
}
