using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 7;
            Console.WriteLine($"Изначальные переменные: {a}, {b}");
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine($"Переставленные переменные: {a}, {b}");
        }
    }
}
