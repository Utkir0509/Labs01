using System;

namespace tema8z2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). Найти количество отрезков B, размещенных на отрезке A.
            int n; //количество отрезков B, размещенных на отрезке A
            string str;
            Console.WriteLine("Введите размер отрезка А (целое положительное число):");
            str = Console.ReadLine();
            Int32.TryParse(str, out int A);
            Console.WriteLine("Введите размер отрезка B (целое положительное число):");
            str = Console.ReadLine();
            Int32.TryParse(str, out int B);

            n = A/B;
            Console.WriteLine($"Количество отрезков размером: {B} , размещенных на отрезке A: {A} равно: {n}");
        }
    }
}
