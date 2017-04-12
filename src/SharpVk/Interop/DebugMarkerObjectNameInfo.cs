using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct DebugMarkerObjectNameInfo
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
        public char* ObjectName; 
    }
}
