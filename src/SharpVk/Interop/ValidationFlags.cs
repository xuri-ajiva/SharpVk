using System;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    public unsafe struct ValidationFlags
    {
        /// <summary>
        /// 
        /// </summary>
        public ValidationFlags(StructureType sType, void* next, uint disabledValidationCheckCount, ValidationCheck* disabledValidationChecks)
        {
            this.SType = sType;
            this.Next = next;
            this.DisabledValidationCheckCount = disabledValidationCheckCount;
            this.DisabledValidationChecks = disabledValidationChecks;
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
        public uint DisabledValidationCheckCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public ValidationCheck* DisabledValidationChecks; 
    }
}
