using System;

namespace tema10z7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны целые числа a, b, c
            //Проверить истинность высказывания:
            //«Существует треугольник со сторонами a, b, c».

            string str;
            bool triangleExist = false;

            Console.WriteLine("Введите целое число 1 стороны треугольника");
            str = Console.ReadLine();
            Int32.TryParse(str, out int a);
            Console.WriteLine("Введите целое число 2 стороны треугольника");
            str = Console.ReadLine();
            Int32.TryParse(str, out int b);
            Console.WriteLine("Введите целое число 3 стороны треугольника");
            str = Console.ReadLine();
            Int32.TryParse(str, out int c);

            if ((b + c > a) & (a + c > b) & (b + a > c)) triangleExist = true; //проверяем что треугольник - cуществует.

            Console.WriteLine($"Существует треугольник со сторонами {a}, {b}, {c} : {triangleExist}.");
        }
    }
}
