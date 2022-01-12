using System;

namespace tema13z3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число N (> 0).
            //Найти квадрат данного числа, используя для его вычисления следующую формулу:
            //N2 = 1 + 3 + 5 + . . . + (2·N − 1).
            //После добавления к сумме каждого слагаемого выводить текущее значение суммы
            float i, a;
            string str;

            Console.WriteLine("Введите целое число >0");
            str = Console.ReadLine();
            Int32.TryParse(str, out int N);
            
            a = 0;
            for (i = 1; i <= N; i++)
            {
                a = a + 2 * i - 1;
                Console.WriteLine($"{a}");
            }
            Console.WriteLine($"Квадрат:{str} будет:{a}");
        }
    }
}
