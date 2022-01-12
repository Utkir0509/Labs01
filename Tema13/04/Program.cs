using System;

namespace tema13z4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано вещественное число A и целое число N (> 0).
            //Используя один цикл, найти сумму
            //1 + A + A2 + A3 + . . . + AN
            
            double a, i; 
            string str;

            Console.WriteLine("Введите вещественное число A:");
            str = Console.ReadLine();
            Double.TryParse(str, out double A);
            Console.WriteLine("Введите целое число N>0:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int N);

            a = 0;
            for (i = 0; i <= N; i++)
            {
                a = a + Math.Pow(A,i);
            }
            Console.WriteLine($"A:{a}");
        }
    }
}
