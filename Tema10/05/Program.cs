using System;

namespace tema10z5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано четырехзначное число.
            //Проверить истинность высказывания:
            //«Данное число читается одинаково слева направо и справа налево».

            string str;
            Boolean polindrom = false;
            int a, b, c, d; // числа из которых состоит число

            Console.WriteLine("Введите целое четырехзначное число");
            str = Console.ReadLine();
            Int32.TryParse(str, out int n);

            a = n / 1000; //первая цифра числа.            
            b = n % 1000 / 100;//вторая цифра числа.            
            c = n % 1000 % 100 / 10; //третья цифра числа.
            d = n % 1000 % 100 % 10; //четвертая цифра числа.
            if (( a == d) & ( b == c )) polindrom = true; //проверяем что читается одинаково слева направо и справа налево.

            Console.WriteLine($"цифры:{a}, {b}, {c}, {d}");
            Console.WriteLine($"Число : {n} читается одинаково слева направо и справа налево: {polindrom}.");
        }
    }
}
