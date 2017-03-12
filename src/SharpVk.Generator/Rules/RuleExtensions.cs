using System.Collections.Generic;

namespace SharpVk.Generator.Rules
{
    public static class RuleExtensions
    {
        public static bool ApplyFirst<T>(this IEnumerable<IRule<T>> rules, T arg)
        {
            foreach (var rule in rules)
            {
                if (rule.Apply(arg))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ApplyFirst<T, U>(this IEnumerable<IRule<T, U>> rules, T arg1, U arg2)
        {
            foreach (var rule in rules)
            {
                if (rule.Apply(arg1, arg2))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ApplyFirst<T, U, V>(this IEnumerable<IRule<T, U, V>> rules, T arg1, U arg2, V arg3)
        {
            foreach (var rule in rules)
            {
                if (rule.Apply(arg1, arg2, arg3))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
