using System;

namespace tema9z5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дан номер некоторого года (целое положительное число).
             Определить соответствующий ему номер столетия, 
            учитывая, что, к примеру, началом 20 столетия был 1901 год */
            int s; // № столетия.
            string str;
            Console.WriteLine("Введите год:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int y);
            s = (y-1) / 100 + 1;
            Console.WriteLine($"Год: {y} принадлежит {s}-му столетию.");
        }
    }
}
