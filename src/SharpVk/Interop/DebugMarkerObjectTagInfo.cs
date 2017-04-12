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
        public ulong Object; 
        
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
