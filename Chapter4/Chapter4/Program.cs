using System;
using Generic;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = new int[]{1,2,3,4,5};
            var result = SearchMaxMin.FindMax(input);

            ConsolePrinter.Print(result);
        }
    }
}
