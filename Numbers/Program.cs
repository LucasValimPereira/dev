using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10456.25m;
            Console.WriteLine(
                Math.Ceiling(valor)
            );
        }
    }
}