using System.Collections.Generic;

namespace SharpVk.Generator.Specification
{
    public interface IExtensionSet
    {
        IEnumerable<string> KnownExtensions { get; }
    }
}