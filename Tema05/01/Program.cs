using System;

namespace Tema5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тема 5. Задание 1
            //Найти расстояние между двумя точками с заданными координатами (x1, y1) и (x2, y2)
            int x1 =5, x2=10, y1=0, y2=0;
            double s;
            s = Math.Sqrt((x2 - x1)* (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("           Тема 5. Задание 1");
            Console.WriteLine($"Координаты первой точки: {x1}, {y1}");
            Console.WriteLine($"Координаты Второй точки: {x2}, {y2}");
            Console.WriteLine("Расстояние между точками: " + s);
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
