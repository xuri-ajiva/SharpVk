using System;

namespace SharpVk
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new Instance(InstanceCreateInfo.Create(), null);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
