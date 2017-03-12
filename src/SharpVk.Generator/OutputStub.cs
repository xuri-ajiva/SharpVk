using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator
{
    public class OutputStub
        : IOutput
    {
        private readonly IEnumerable<EnumElement> enums;

        public OutputStub(IEnumerable<EnumElement> enums)
        {
            this.enums = enums;
        }

        public void Run()
        {
            foreach (var enumElement in this.enums)
            {
                Console.WriteLine(enumElement.VkName);

                foreach(var field in enumElement.Fields)
                {
                    Console.WriteLine($"\t{field.Key}\t{field.Value.Value}");
                }
            }
        }
    }
}
