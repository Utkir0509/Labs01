using System;

namespace tema6z4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=1, y;
            y = 3 * Math.Pow(x, 6) - 6 * x * x - 7;
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}
