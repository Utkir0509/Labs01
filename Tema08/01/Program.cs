using System;

namespace tema8z1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан размер файла в байтах. Найти количество полных килобайтов, которые занимает данный файл
            double sizeKBite;
            string str;
            Console.WriteLine("Введите размер файла в байтах (целое число):");
            str = Console.ReadLine();
            Int32.TryParse(str, out int sizeBite);

            sizeKBite = (Math.Truncate(sizeBite / 1024.00));
            Console.WriteLine($"Файл размером {sizeBite} байт, занимает полных {sizeKBite} КилоБайт.") ;
        }
    }
}
