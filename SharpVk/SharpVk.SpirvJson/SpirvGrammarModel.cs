namespace SharpVk.SpirvJson
{
    public struct SpirvGrammarModel
    {
        public SpirvInstruction[] Instructions;
        public SpirvOperandKind[] Operand_Kinds;
    }

    public struct SpirvInstruction
    {
        public string OpName;
        public string OpCode;
        public SpirvOperand[] Operands;
    }

    public struct SpirvOperand
    {
        public string Kind;
        public string Quantifier;
        public string Name;
        public string[] Capability;
    }

    public struct SpirvOperandKind
    {
        public string Kind;
    }
}