using Microsoft.Extensions.DependencyInjection;
using System.Xml.Linq;

namespace SharpVk.Generator.Specification
{
    public interface ITypeExtensionRule
    {
        bool CanApply(XElement typeXml, TypeElement type);

        void Apply(XElement typeXml, TypeElement type, IServiceCollection target);
    }
}
