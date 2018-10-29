using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World!");
            }
            else
            {
                Console.WriteLine("Hello, {0}!", args[0]);
            }
        }
    }
}
