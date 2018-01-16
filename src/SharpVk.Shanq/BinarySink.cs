using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SharpVk.Spirv
{
    public class BinarySink
        : ISpirvSink
    {
        private BinaryWriter file;

        public BinarySink(Stream outputStream, int bound)
        {
            this.file = new BinaryWriter(outputStream);

            this.file.Write(0x07230203);
            this.file.Write(0x00010000);
            this.file.Write(0x00000000);
            this.file.Write(bound);
            this.file.Write(0x00000000);
        }

        public void AddStatement(ResultId? resultId, SpirvStatement statement)
        {
            //if (resultId.HasValue)
            //{
            //    Console.Write($" {resultId.Value}".PadRight(5));
            //    Console.Write(" = ");
            //}
            //else
            //{
            //    Console.Write("        ");
            //}

            //Console.WriteLine(statement);

            var opCode = OpCode.Lookup[statement.Op];

            var arguments = statement.Operands.ToList();

            if (resultId.HasValue)
            {
                int resultIdOperandIndex = opCode.Operands.TakeWhile(x => x.Kind != OperandKind.IdResult).Count();

                arguments.Insert(resultIdOperandIndex, resultId.Value);
            }

            int wordCount = arguments.Select(x =>
            {
                if (x.GetType() == typeof(string))
                {
                    int byteCount = Encoding.UTF8.GetByteCount(x.ToString()) + 1;
                    int stringWordCount = byteCount / 4;

                    if (byteCount % 4 > 0)
                    {
                        stringWordCount++;
                    }

                    return stringWordCount;
                }
                else
                {
                    return 1;
                }
            }).Aggregate(1, (x, y) => x + y);

            this.file.Write(wordCount << 16 | (int)statement.Op);
            foreach (var argument in arguments)
            {
                var argumentType = argument.GetType();
                if (argumentType == typeof(ResultId))
                {
                    this.file.Write(((ResultId)argument).Id);
                }
                else if (argumentType == typeof(string))
                {
                    int byteCount = Encoding.UTF8.GetByteCount(argument.ToString()) + 1;
                    var stringBytes = Encoding.UTF8.GetBytes(argument.ToString());

                    this.file.Write(stringBytes);
                    this.file.Write((byte)0);

                    for (int paddingByteIndex = 0; paddingByteIndex < (4 - byteCount % 4); paddingByteIndex++)
                    {
                        this.file.Write((byte)0);
                    }
                }
                else if (argumentType == typeof(float))
                {
                    this.file.Write((float)argument);
                }
                else
                {
                    this.file.Write(Convert.ToInt32(argument));
                }
            }

            this.file.Flush();
        }
    }
}
