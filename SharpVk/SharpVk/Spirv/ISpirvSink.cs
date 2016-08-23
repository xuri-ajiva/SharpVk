namespace SharpVk.Spirv
{
    public interface ISpirvSink
    {
        void AddStatement(ResultId? resultId, SpirvStatement statement);
    }

    public static class SpirvSinkExtensions
    {
        public static void AddStatement(this ISpirvSink sink, SpirvStatement statement)
        {
            sink.AddStatement(null, statement);
        }

        public static void AddStatement(this ISpirvSink sink, Op op, params object[] operands)
        {
            sink.AddStatement(null, new SpirvStatement(op, operands));
        }

        public static void AddStatement(this ISpirvSink sink, ResultId resultId, Op op, params object[] operands)
        {
            sink.AddStatement(resultId, new SpirvStatement(op, operands));
        }
    }
}
