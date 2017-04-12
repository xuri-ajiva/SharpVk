using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Pipeline;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Collation
{
    public class TypeCollator
        : IWorker
    {
        private readonly IEnumerable<TypeElement> types;
        private readonly NameFormatter nameFormatter;
        private readonly IEnumerable<string> handleTypes;

        public TypeCollator(IEnumerable<TypeElement> types, NameFormatter nameFormatter)
        {
            this.types = types;
            this.nameFormatter = nameFormatter;

            this.handleTypes = this.types.Where(x => x.Category == TypeCategory.handle)
                                        .Select(x => x.VkName)
                                        .ToArray();
        }

        public void Execute(IServiceCollection services)
        {
            var typeData = this.types
                                    .Where(x => x.Category != TypeCategory.define && x.Category != TypeCategory.include)
                                    .ToDictionary(x => x.VkName, x => new TypeDeclaration
                                    {
                                        VkName = x.VkName,
                                        Name = this.nameFormatter.FormatName(x),
                                        Pattern = x.Category.MapToPattern(),
                                        Members = GetMembers(x).ToList()
                                    });

            bool newInteropTypes = true;

            while (newInteropTypes)
            {
                newInteropTypes = false;

                foreach (var type in typeData.Values)
                {
                    if (type.Pattern == TypePattern.NonMarshalledStruct
                            && type.Members.Any(x => x.RequiresMarshalling || typeData[x.Type.VkName].RequiresMarshalling))
                    {
                        type.Pattern = TypePattern.MarshalledStruct;

                        newInteropTypes = true;
                    }
                }
            }

            foreach(var type in typeData.Values)
            {
                services.AddSingleton(new TypeNameMapping
                {
                    VkName = type.VkName,
                    OutputName = type.Name
                });
            }

            services.AddSingleton(typeData);
        }

        private IEnumerable<MemberDeclaration> GetMembers(TypeElement type)
        {
            foreach (var member in type.Members)
            {
                yield return new MemberDeclaration
                {
                    Name = this.nameFormatter.FormatName(member, false),
                    ParamName = this.nameFormatter.FormatName(member, true),
                    Type = new TypeReference
                    {
                        VkName = member.Type,
                        PointerType = member.PointerType,
                        FixedLength = member.FixedLength
                    }
                };
            }
        }
    }
}
