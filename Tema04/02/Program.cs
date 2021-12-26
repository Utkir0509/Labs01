using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тема 4. Задание 2
            double d = 10, pi = 3.14, L;
            L = d * pi;
            Console.WriteLine("           Тема 4. Задание 2");
            Console.WriteLine($"Диаметр окружности: {d}");
            Console.WriteLine("Длина окружности: " + L);
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
