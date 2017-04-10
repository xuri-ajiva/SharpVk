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
        public QueryPoolCreateInfo(StructureType sType, void* next, QueryPoolCreateFlags flags, QueryType queryType, uint queryCount, QueryPipelineStatisticFlags pipelineStatistics)
        {
            this.SType = sType;
            this.Next = next;
            this.Flags = flags;
            this.QueryType = queryType;
            this.QueryCount = queryCount;
            this.PipelineStatistics = pipelineStatistics;
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
