using System;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Console.WriteLine("Hello World!");
            string someString = "interpolation";
            Console.WriteLine($"{someString.Length}");
            string newString = someString.Substring(0, 5);
        }
    }
}
