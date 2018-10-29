using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World!");
            }
            else if (args[0] == "-g")
            {
                Console.WriteLine("Goodbye cruel world.");
            }
            else
            {
                Console.WriteLine("Hello, {0}!", args[0]);
            }
        }
    }
}
