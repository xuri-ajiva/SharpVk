using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System;
using System.Collections.Generic;

namespace SharpVk.Generator
{
    public class OutputStub
        : IOutput
    {
        private readonly IEnumerable<CommandElement> commands;

        public OutputStub(IEnumerable<CommandElement> commands)
        {
            this.commands = commands;
        }

        public void Run()
        {
            foreach (var commandElement in this.commands)
            {
                Console.WriteLine(commandElement.VkName);

                foreach (var field in commandElement.Params)
                {
                    Console.WriteLine($"\t{field.Type}\t{field.VkName}");
                }
            }
        }
    }
}
