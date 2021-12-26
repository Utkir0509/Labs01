using System;

namespace Tema5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Тема 5. Задание 3
            Даны три точки A, B, C на числовой оси.
            Точка C расположена между точками A и B. 
            Найти произведение длин отрезков AC и BC */
            int x1 = 5, x2 = 30, x3 = 20; // три точки на оси
            int s; // Произведение длин отрезков
            s = (x3 - x1) * (x2 - x3);
            Console.WriteLine("           Тема 5. Задание 3");
            Console.WriteLine($"Координаты первой точки: {x1}");
            Console.WriteLine($"Координаты второй точки: {x2}");
            Console.WriteLine($"Координаты третей точки: {x3}");
            Console.WriteLine("Произведение длин отрезков: " + s);
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
