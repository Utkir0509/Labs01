using System;

namespace tema6z5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5, y;
            y = 4 * Math.Pow((x-3), 6) - 7 *Math.Pow((x-3),3) + 2 ;
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}
