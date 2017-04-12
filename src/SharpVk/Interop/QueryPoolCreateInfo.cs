using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct QueryPoolCreateInfo
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
        public QueryPoolCreateFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public QueryType QueryType; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint QueryCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public QueryPipelineStatisticFlags PipelineStatistics; 
    }
}
