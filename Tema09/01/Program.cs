using System;

namespace tema9z1
{
    class Program
    {
        static void Main(string[] args)
        {
            //С начала суток прошло N секунд (N — целое). Найти количество секунд, прошедших с начала последней минуты.
            int m, s;
            string str;
            Console.WriteLine("Введите прошедшее количество секунд с начала суток");
            str = Console.ReadLine();
            Int32.TryParse(str, out int n); 

            m = n / 60; //количество минут, прошедших с начала суток.
            s = n - m * 60; //количество секунд, прошедших с начала последней минуты.
            Console.WriteLine($"С начала суток прошло: {n} с, с последней минуты прошло {s} с.");
        }
    }
}
