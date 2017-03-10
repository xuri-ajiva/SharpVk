using Microsoft.Extensions.DependencyInjection;
using SharpVk.Generator.Specification;
using System;
using System.IO;

namespace SharpVk.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "SharpVk");

            if (!Directory.Exists(tempFilePath))
            {
                Directory.CreateDirectory(tempFilePath);
            }

            var specServices = new ServiceCollection();

            specServices.AddSingleton<IVkXmlCache>(new VkXmlCache(tempFilePath));
            specServices.AddSingleton<IExtensionSet, ExtensionSet>();

            var specProvider = specServices.BuildServiceProvider();

            var collationServices = new ServiceCollection();

            var typeReader = ActivatorUtilities.CreateInstance<TypeElementReader>(specProvider);

            typeReader.ReadTo(collationServices);

            var collectionProvider = collationServices.BuildServiceProvider();

            foreach (var typeElement in collectionProvider.GetServices<TypeElement>())
            {
                Console.WriteLine($"{typeElement.Category}: {typeElement.VkName}");
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}