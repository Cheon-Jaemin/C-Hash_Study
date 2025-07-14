using System;
using static System.Console;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("{0} {1}", 3.14f, 12);
            Console.WriteLine("{0} + {1} = {2}", 1, 2, (1 + 2));

        }
    }
}
