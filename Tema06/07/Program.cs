using System;

namespace _6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 2, y, z;
            Console.WriteLine($"a: {x}");
            y = x;
            z = y * y;
            y = z * z;
            z = y * y;
             y = z * z;
            x = y * (1 / x);
            Console.WriteLine(x);
            Console.WriteLine($"a^15: {x}");
        }
    }
}
