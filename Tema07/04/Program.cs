using System;

namespace tema7z4
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1=50, v2=60, s=10, t=2, sT;
            //Скорость первого автомобиля, второго, расстояние между ними изначально, расстояние между ними через T часов
            
            string str; //Строковая переменная для обработки ответа пользователя.
            Console.WriteLine("Введите скорость 1-го автомобиля");
            str = Console.ReadLine();
            Double.TryParse(str, out v1);

            Console.WriteLine("Введите скорость 2-го автомобиля");
            str = Console.ReadLine();
            Double.TryParse(str, out v2);

            Console.WriteLine("Введите расстояние между автомобилями");
            str = Console.ReadLine();
            Double.TryParse(str, out s);

            Console.WriteLine("Введите время");
            str = Console.ReadLine();
            Double.TryParse(str, out t);

            sT = (v1 + v2) * t + s;

            Console.WriteLine($"Расстояние между машинами через {t} ч.: {sT}км.");
        }
    }
}
