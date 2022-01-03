using System;

namespace tema8z3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). Найти длину незанятой части отрезка A.
            int m; //остаток
            string str;
            Console.WriteLine("Введите размер отрезка А (целое положительное число):");
            str = Console.ReadLine();
            Int32.TryParse(str, out int A);
            Console.WriteLine("Введите размер отрезка B (целое положительное число):");
            str = Console.ReadLine();
            Int32.TryParse(str, out int B);

            m = A % B;
            Console.WriteLine($"После размещения отрезков размером: {B}, размещенных на отрезке A: {A} остаток: {m}");
        }
    }
}
