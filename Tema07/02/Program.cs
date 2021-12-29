using System;

namespace tema7z2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=3.14; //угол в радианах 
            double g; //угол в градусах 
            string str;
            Console.WriteLine("Введите значения угла в радианах (меньше 2пи)");
            str=Console.ReadLine();
            double.TryParse (  str, out a);
            g = a * 180 / Math.PI ;
            Console.WriteLine($"Значение угла в {a} радиан является {g} градусов") ;
        }
    }
}
