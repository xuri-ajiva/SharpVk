namespace SharpVk.Generator.Rules
{
    public interface IRule<T>
    {
        bool Apply(T arg);
    }

    public interface IRule<T, U>
    {
        bool Apply(T arg1, U arg2);
    }

    public interface IRule<T, U, V>
    {
        bool Apply(T arg1, U arg2, V arg3);
    }
}
