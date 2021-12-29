using System;

namespace tema7z5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 50, B = 60, x ;
            string str; //Строковая переменная для обработки ответа пользователя.

            Console.WriteLine("Введите коэффицент A");
            str = Console.ReadLine();
            Double.TryParse(str, out A);

            Console.WriteLine("Введите коэффицент B");
            str = Console.ReadLine();
            Double.TryParse(str, out B);

            x = -B / A;

            Console.WriteLine($"x={x}");
        }
    }
}
