using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
 //Тема 4. Задание 1
            double a=10, b=5, S, P;
            S = a * b;
            P = 2*(a + b);
            Console.WriteLine("           Тема 4. Задание 1");
            Console.WriteLine($"Стороны прямоугольника: {a}, {b}");
            Console.WriteLine("Площадь прямоугольника: " + S);
            Console.WriteLine("Периметр прямоугольника: " + P);
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
