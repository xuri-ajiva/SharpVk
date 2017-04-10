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
        public DebugMarkerObjectNameInfo(StructureType sType, void* next, DebugReportObjectType objectType, ulong @Object, char* objectName)
        {
            this.SType = sType;
            this.Next = next;
            this.ObjectType = objectType;
            this.@Object = @Object;
            this.ObjectName = objectName;
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
        public char* ObjectName; 
    }
}
