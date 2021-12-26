using System;

namespace Tema5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Тема 5. Задание 5
           Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
           Найти его периметр и площадь*/
            int x1 = 0, y1 = 0; //координата первой вершины
            int x2 = 0, y2 = 3; //координата второй вершины
            int x3 = 5, y3 = 0; //координата третей вершины
            double a, b, c ;// Длины треугольника
            double pp; // Полупериметр треугольника 

            a = Math.Sqrt((x2 - x1)* (x2 - x1) + (y2 - y1) * (y2 - y1));
            b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            c = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            double s; // Площадь треугольника
            pp = (a + b + c)/2;
            // Вычисляем площадь по формуле Герона
            s = Math.Sqrt(pp * (pp-a) * (pp - b) * (pp - c)); 
            Console.WriteLine("           Тема 5. Задание 5");
            //Console.WriteLine($"Стороны треугольника: {a}, {b}, {c}");
            Console.WriteLine($"Координаты первой вершины: {x1}, {y1}");
            Console.WriteLine($"Координаты второй вершины: {x2}, {y2}");
            Console.WriteLine($"Координаты третей вершины: {x3}, {y3}");
            Console.WriteLine($"Периметр треугольника: {pp*2}");
            Console.WriteLine($"Площадь треугольника: {s}");
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
