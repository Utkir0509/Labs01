using System;

namespace tema8z4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано двузначное число. Вывести число, полученное при перестановке цифр исходного числа.
            int b; //результирующее число
            int d, e; //Десятки, единицы
            string str;
            Console.WriteLine("Введите (целое число):");
            str = Console.ReadLine();
            Int32.TryParse(str, out int a);
            
            d = a / 10;
            e = a % 10;
            b = e * 10 + d;            
            Console.WriteLine($"Исходное число: {a}, после перестановок: {b}");
        }
    }
}
