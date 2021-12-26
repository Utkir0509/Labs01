using System;

namespace Tema5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Тема 5. Задание 4
           Даны координаты двух противоположных вершин прямоугольника:
           (x1, y1), (x2, y2). Стороны прямоугольника параллельны осям координат.
           Найти периметр и площадь данного прямоугольника.*/
            int x1 = -5, y1 = -2; //координата первой вершины
            int x2 = 5, y2 = 2; //координата второй вершины
            int l, n ; // Длины сторон прямоугольника
            l = Math.Abs(x2 - x1);
            n = Math.Abs(y2 - y1);
            int p, s; // Периметр и площадь прямоугольника
            p = 2 * (l + n);
            s = l * n;
            Console.WriteLine("           Тема 5. Задание 3");
            Console.WriteLine($"Координаты первой вершины: {x1}, {y1}");
            Console.WriteLine($"Координаты второй вершины: {x2}, {y2}");
            Console.WriteLine($"Периметр прямоугольника: {p}");
            Console.WriteLine($"Площадь прямоугольника: {s}");
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
