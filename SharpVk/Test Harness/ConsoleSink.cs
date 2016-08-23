using SharpVk.Shanq;
using SharpVk.Spirv;
using System;

namespace SharpVk
{
    public class ConsoleSink
        : ISpirvSink
    {
        public void AddStatement(ResultId? resultId, SpirvStatement statement)
        {
            if (resultId.HasValue)
            {
                Console.WriteLine($"{resultId} = {statement}");
            }
            else
            {
                Console.WriteLine(statement);
            }
        }
    }
}
