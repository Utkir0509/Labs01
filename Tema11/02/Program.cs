using System;

namespace tema11z2
{
    class Program
    {
        static void Main(string[] args)
        {
                //Даны три числа. Найти сумму двух наибольших из них
                string str;
                double sum;

                Console.WriteLine("Введите 1ое число");
                str = Console.ReadLine();
                Double.TryParse(str, out double a);
                Console.WriteLine("Введите 2ое число");
                str = Console.ReadLine();
                Double.TryParse(str, out double b);
                Console.WriteLine("Введите 3ое число");
                str = Console.ReadLine();
                Double.TryParse(str, out double c);
                
                if ((a <= b) & (a <= c))
                {
                    sum = b + c;
                }
                else if ((b <= a) & (b <= c))
                {
                    sum = a + c;
                }
                else //if ((c <= a) & (c <= b))
                {
                    sum = a + b;
                }

                Console.WriteLine($"Числа a: {a}, b: {b}, c: {c}. Сумма наибольших из них: {sum}");
        } 
    }
}
