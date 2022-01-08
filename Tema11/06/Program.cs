using System;

namespace tema11z6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число, лежащее в диапазоне 1–999.
            //Вывести его строку описание вида «четное двузначное число»,
            //«нечетное трехзначное число» и т. д.

            string str;
            Console.WriteLine("Введите целое число");
            str = Console.ReadLine();
            Int32.TryParse(str, out int chislo);

            str = "";

            if (chislo % 2 == 0)
            {
                str = "четное ";
            }
            else
            {
                str = "нечетное ";
            }

            if (chislo < 10)
            {
                str += "однозначное ";
            }
            else if (chislo < 100)
            {
                str += "двузначное ";
            }
            else if (chislo < 1000)
            {
                str += "трехзначное ";
            }

            str += "число.";
            Console.WriteLine($"Число {chislo}: {str}.");

        }
    }
}
