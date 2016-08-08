using SharpVk.VkXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SharpVk
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            GenerateTypes();
        }

        private static void Enumerate<T>(T target)
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine("{0} = {1}", field.Name, field.GetValue(target));
            }

            foreach (var property in typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine("{0} = {1}", property.Name, property.GetValue(target));
            }
        }

        private static void GenerateTypes()
        {
            var xmlCache = new VkXmlCache(".\\obj\\VkTemplates");

            var parser = new SpecParser(xmlCache);
            var generator = new TypeGenerator();

            var types = generator.Generate(parser.Run());
        }
    }
}