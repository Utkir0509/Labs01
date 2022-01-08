using System;

namespace tema10z6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.
            //Проверить истинность высказывания:
            //«Треугольник со сторонами a, b, c является прямоугольным».

            string str;
            bool triangle90gr = false;

            Console.WriteLine("Введите целое число 1 стороны треугольника");
            str = Console.ReadLine();
            Int32.TryParse(str, out int a);
            Console.WriteLine("Введите целое число 2 стороны треугольника");
            str = Console.ReadLine();
            Int32.TryParse(str, out int b);
            Console.WriteLine("Введите целое число 3 стороны треугольника");
            str = Console.ReadLine();
            Int32.TryParse(str, out int c);

            if ((a * a == b * b + c * c) | (b * b == a * a + c * c) | (c * c == b * b + a * a)) triangle90gr = true; //проверяем что треугольник - прямоугольный.

            //Console.WriteLine($"цифры:{a}, {b}, {c}, {d}");
            Console.WriteLine($"Треугольник является прямоугольным : {triangle90gr}.");
        }
    }
}
