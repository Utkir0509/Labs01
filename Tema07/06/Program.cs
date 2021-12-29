using System;

namespace tema7z6
{
    class Program
    {
        static void Main(string[] args)
        {
			double a1, b1, c1, a2, b2, c2;

			string str; //Строковая переменная для обработки ответа пользователя.

			Console.WriteLine("Введите коэффицент первого уравнения A");
			str = Console.ReadLine();
			Double.TryParse(str, out a1);
			Console.WriteLine("Введите коэффицент первого уравнения B");
			str = Console.ReadLine();
			Double.TryParse(str, out b1);
			Console.WriteLine("Введите коэффицент первого уравнения C");
			str = Console.ReadLine();
			Double.TryParse(str, out c1);

			Console.WriteLine("Введите коэффицент второго уравнения A");
			str = Console.ReadLine();
			Double.TryParse(str, out a2);
			Console.WriteLine("Введите коэффицент второго уравнения B");
			str = Console.ReadLine();
			Double.TryParse(str, out b2);
			Console.WriteLine("Введите коэффицент второго уравнения C");
			str = Console.ReadLine();
			Double.TryParse(str, out c2);

			double d, d1, d2;
			d = a1 * b2 - b1 * a2;
			d1 = c1 * b2 - b1 * c2;
			d2 = a1 * c2 - c1 * a2;
			double x, y;
			x = d1 / d;
			y = d2 / d;

			Console.WriteLine($"x= {x}, y={y}");
        }
    }
}
