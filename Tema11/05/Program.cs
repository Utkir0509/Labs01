using System;

namespace tema11z5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число.
            //Вывести его строку-описание вида «отрицательное четное число»,
            //«нулевое число», «положительное нечетное число» и т. д.

            string str;
            Console.WriteLine("Введите целое число");
            str = Console.ReadLine();
            Int32.TryParse(str, out int chislo);
            str = "";
            if (chislo == 0)
            {
                str = "нулевое число."; //проверяем на 0.
                Console.WriteLine($"Число {chislo}: {str}.");
                Environment.Exit(0);
            }
            if (chislo > 0)
            {
                str = "положительное ";
            }
            else if (chislo < 0)
            {
                str = "отрицательное ";
            }

            if (chislo % 2 == 0)
            {
                str += "четное ";
            }
            else
            {
                str += "нечетное ";
            }
            str += "число.";
            Console.WriteLine($"Число {chislo}: {str}.");
        }
    }
}
