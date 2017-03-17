using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace SharpVk.Generator.Collation
{
    public class TypeCollator
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

        public void CollateTo(IServiceCollection services)
        {
            var typeData = this.types
                                    .Where(x => x.Category != TypeCategory.define && x.Category != TypeCategory.include)
                                    .ToDictionary(x => x.VkName, x => new TypeDeclaration
                                    {
                                        VkName = x.VkName,
                                        Name = this.nameFormatter.FormatName(x),
                                        Category = x.Category,
                                        RequiresMarshalling = RequiresMarshalling(x),
                                        IsPrimitive = x.Category == TypeCategory.basetype || x.Category == TypeCategory.None,
                                        Members = GetMembers(x).ToList()
                                    });

            bool newInteropTypes = true;

            while (newInteropTypes)
            {
                newInteropTypes = false;

                foreach (var type in typeData.Values)
                {
                    if (!type.RequiresMarshalling
                            && type.Members.Any(x => typeData[x.Type.VkName].RequiresMarshalling))
                    {
                        type.RequiresMarshalling = true;

                        newInteropTypes = true;
                    }
                }
            }
            
            services.AddSingleton(typeData);
        }

        private IEnumerable<MemberDeclaration> GetMembers(TypeElement type)
        {
            foreach(var member in type.Members)
            {
                yield return new MemberDeclaration
                {
                    Name = this.nameFormatter.FormatName(member),
                    Type = new TypeReference
                    {
                        VkName = member.Type,
                        PointerType = member.PointerType
                    }
                };
            }
        }

        private bool RequiresMarshalling(TypeElement type)
        {
            return type.Category == TypeCategory.@struct
                && type.Members.Any(y =>
                    y.FixedLength.Type != FixedLengthType.None
                        || (y.PointerType != PointerType.Value
                            && y.PointerType != PointerType.ConstValue
                            || this.handleTypes.Contains(y.Type)));
        }
    }
}
