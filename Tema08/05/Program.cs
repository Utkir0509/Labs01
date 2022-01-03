using System;

namespace tema8z5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее справа. Вывести полученное число.
            int r; //результирующее число
            int a, b, c; //Сотни, десятки, единицы
            string str;
            Console.WriteLine("Введите трехзначное целое число:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int i);

            a = i / 100;
            b = (i-a*100) / 10;
            c = i % 10;
            r = b * 100 + c*10+ a;
            Console.WriteLine($"Исходное число: {i}, после перестановок: {r}");
        }
    }
}
