using System;

namespace tema11z4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны координаты точки, не лежащей на координатных осях OX и OY.
            //Определить номер координатной четверти,
            //в которой находится данная точка
            string str;

            Console.WriteLine("Введите координату х точки");
            str = Console.ReadLine();
            Int32.TryParse(str, out int x);
            Console.WriteLine("Введите координату y точки");
            str = Console.ReadLine();
            Int32.TryParse(str, out int y);

            if ((x > 0) & (y > 0)) Console.WriteLine("Точка лежит в I координатной четверти");
            if ((x < 0) & (y > 0)) Console.WriteLine("Точка лежит во II координатной четверти");
            if ((x < 0) & (y < 0)) Console.WriteLine("Точка лежит в III координатной четверти");
            if ((x > 0) & (y < 0)) Console.WriteLine("Точка лежит в IV координатной четверти");

        }
    }
}
