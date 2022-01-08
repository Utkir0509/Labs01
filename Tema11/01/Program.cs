using System;

namespace tema11z1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны две переменные целого типа: A и B.
            //Если их значения не равны, то присвоить каждой переменной большее из этих значений,
            //а если равны, то присвоить переменным нулевые значения.
            //Вывести новые значения переменных A и B.
            string str;

            Console.WriteLine("Введите 1ое целое число");
            str = Console.ReadLine();
            Int32.TryParse(str, out int a);
            Console.WriteLine("Введите 2ое целое число");
            str = Console.ReadLine();
            Int32.TryParse(str, out int b);

            Console.WriteLine($"Изначальные числа a: {a}, b: {b}.");
            if (a == b)
            {
                a = 0;
                b = 0;
            }
            else
            {
                if (a > b) 
                {
                    b = a;
                } 
                else 
                {
                    a = b; 
                }
            }
            Console.WriteLine($"Числа a: {a}, b: {b}.");
        }
    }
}
