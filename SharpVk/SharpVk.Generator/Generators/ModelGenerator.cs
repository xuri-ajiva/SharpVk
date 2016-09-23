using SharpVk.VkXml;

namespace SharpVk.Generator.Generators
{
    public abstract class ModelGenerator
    {
        public abstract void Run(TypeSet types, FileGenerator fileGenerator);
    }
}