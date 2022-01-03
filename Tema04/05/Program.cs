using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тема 4. Задание 5
            double a = -10, b = 5, S, R, P, C;
            S = Math.Abs(a) + Math.Abs(b);
            R = Math.Abs(a) - Math.Abs(b);
            C = Math.Abs(a) / Math.Abs(b);
            P = Math.Abs(a) * Math.Abs(b);
            Console.WriteLine("           Тема 4. Задание 5");
            Console.WriteLine($"Числа: {a}, {b}");
            Console.WriteLine("Сумма модулей: " + S);
            Console.WriteLine("Разность модулей: " + R);
            Console.WriteLine("Произведение модулей: " + P);
            Console.WriteLine("Частное модулей: " + C);
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
