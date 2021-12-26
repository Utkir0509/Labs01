using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тема 4. Задание 4
            double a = 10, b = 5, S, R, P, C;
            S = a * a + b * b;
            R = a * a - b * b;
            C = a * a / (b * b);
            P = a * a * b * b;
            Console.WriteLine("           Тема 4. Задание 4");
            Console.WriteLine($"Числа: {a}, {b}");
            Console.WriteLine("Сумма их квадратов: " + S);
            Console.WriteLine("Разность их квадратов: " + R);
            Console.WriteLine("Произведение их квадратов: " + P);
            Console.WriteLine("Частное их квадратов: " + C);
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
