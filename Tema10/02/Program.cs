using System;

namespace tema10z2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны три целых числа: A, B, C.
            //Проверить истинность высказывания:
            //«Справедливо двойное неравенство A < B < C».
            string str;
            Boolean n;
            Console.WriteLine("Введите целое число А:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int a);
            Console.WriteLine("Введите целое число B:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int b);
            Console.WriteLine("Введите целое число C:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int c);            
            
            n = (a < b) & (b < c);
            Console.WriteLine($"A < B < C: {n}");
        }
    }
}
