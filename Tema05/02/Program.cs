using System;

namespace Tema5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тема 5. Задание 2
            //Даны три точки A, B, C на числовой оси.
            //Найти длины отрезков AC и BC и их сумму.
            int x1 = 5, x2 = 10, x3 = 20; // три точки на оси
            double s1, s2, s3; //длины отрезков
            s1 = x3 - x1;
            s2 = x3 - x2;
            s3 = s1 + s2;
            Console.WriteLine("           Тема 5. Задание 2");
            Console.WriteLine($"Координаты первой точки: {x1}");
            Console.WriteLine($"Координаты второй точки: {x2}");
            Console.WriteLine($"Координаты третей точки: {x3}");
            Console.WriteLine("Длина отрезка AC: " + s1);
            Console.WriteLine("Длина отрезка BC: " + s2);
            Console.WriteLine("Сумма длин отрезков AC и BC: " + s3);
            Console.WriteLine("Нажмите любую кнопку");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
