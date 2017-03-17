using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Collation;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Generation
{
    public class EnumGenerator
    {
        private readonly Dictionary<string, TypeDeclaration> typeData;

        public EnumGenerator(Dictionary<string, TypeDeclaration> typeData)
        {
            this.typeData = typeData;
        }

        public void GenerateTo(IServiceCollection services)
        {
            foreach (var type in this.typeData.Values.Where(x => x.Category == TypeCategory.@enum))
            {
                services.AddSingleton(new EnumDefinition
                {
                    Name = type.Name
                });
            }
        }
    }
}
