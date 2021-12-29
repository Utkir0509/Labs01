using System;

namespace tema7z3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 2.0, y=3.0;
            double a = 500, b, c;            
            string str;
            Console.WriteLine("Введите вес конфет");
            str=Console.ReadLine();
            Double.TryParse(str, out x);

            Console.WriteLine("Введите стоимость этих конфет");
            str = Console.ReadLine();
            Double.TryParse(str, out a);
            c = a / x; // Стоимость 1 кг конфет
            Console.WriteLine("Введите интересующий вес конфет");
            str = Console.ReadLine();
            Double.TryParse(str, out y);

            Console.WriteLine($"1 кг конфет стоит: {c} ");
            b = c * y;// Стоимость y кг конфет
            Console.WriteLine($"Конфеты весом {y} стоят: {b} ") ;
        }
    }
}
