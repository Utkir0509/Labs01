using System;

namespace tema11z3
{
    class Program
    {
        static void Main(string[] args)
        {
            //На плоскости расположены три точки: A, B, C.
            //Определить, какая из двух последних точек (B или C) расположена ближе к A,
            //и вывести эту точку и ее расстояние от точки A.
            string str;
            double ac, ab;

            Console.WriteLine("Введите координату х точки A");
            str = Console.ReadLine();
            Int32.TryParse(str, out int ax);
            Console.WriteLine("Введите координату y точки A");
            str = Console.ReadLine();
            Int32.TryParse(str, out int ay);
            Console.WriteLine("Введите координату х точки B");
            str = Console.ReadLine();
            Int32.TryParse(str, out int bx);
            Console.WriteLine("Введите координату y точки B");
            str = Console.ReadLine();
            Int32.TryParse(str, out int by);
            Console.WriteLine("Введите координату х точки C");
            str = Console.ReadLine();
            Int32.TryParse(str, out int cx);
            Console.WriteLine("Введите координату y точки C");
            str = Console.ReadLine();
            Int32.TryParse(str, out int cy);

            ac = Math.Sqrt((cx - ax) * (cx - ax) + (cy - ay) * (cy - ay));
            ab = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));

            if (ab < ac)
            {
                Console.WriteLine($"Ближайшая точка b: {bx}, {by}. Расстояние до точки А: {ab}");
            }
            else if (ab < ac)
            {
                Console.WriteLine($"Ближайшая точка с: {cx}, {cy}. Расстояние до точки А: {ac}");
            }
            else
            {
                Console.WriteLine("Точки B, C равноудалены от точки А.");
            }
        }
    }
}
