using System;

namespace tema10z1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны два целых числа: A, B. Проверить истинность высказывания: «Справедливы неравенства A > 2 и B ≤ 3»
            
            string str;
            Console.WriteLine("Введите первое целое число А:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int a);
            Console.WriteLine("Введите второе целое число B:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int b);

            Console.WriteLine($"A > 2: {a > 2}, B <= 3:{b <= 3}");
        }
    }
}
