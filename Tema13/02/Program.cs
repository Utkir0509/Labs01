using System;

namespace tema13z2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число N (> 0).
            //Найти произведение 1.1 · 1.2 · 1.3 · . . . (N сомножителей).
            double m=1;
            string str;

            Console.WriteLine("Введите целое число");
            str = Console.ReadLine();
            Int32.TryParse(str, out int n);
            for(int j = 1; j <= n; j++)
            {
                m = m * (1 + 0.1 * j);
            }

            Console.WriteLine($"{m}");
        }
    }
}
