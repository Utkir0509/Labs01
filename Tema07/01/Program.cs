using System;

namespace tema7z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 90;
            double  r;
            string str;
            Console.WriteLine("Введите значение в градусах (целое число):");
            str =Console.ReadLine();            
            Int32.TryParse(str, out int b); 
            r = b * Math.PI / 180;            
            Console.WriteLine($"Значение угла в {str} градусов будет {r} радиан.");
        }
    }
}
