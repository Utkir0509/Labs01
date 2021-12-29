using System;

namespace tema6z6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2, b;
            Console.WriteLine($"a: {a}");
            b = a * a;
            a = b * b;
            b = a * a;
            Console.WriteLine($"b: {b}");
        }
    }
}
