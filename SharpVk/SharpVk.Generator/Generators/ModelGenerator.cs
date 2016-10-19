namespace SharpVk.Generator.Generators
{
    public abstract class ModelGenerator<T>
    {
        public abstract void Run(T model, FileGenerator fileGenerator);
    }
}