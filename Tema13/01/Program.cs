using System;

namespace tema13z1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано вещественное число — цена 1 кг конфет.
            //Вывести стоимость 0.1, 0.2, . . . , 1 кг конфет.
            string str;
            
            Console.WriteLine("Введите цену 1кг конфет (вещественное число):");
            str = Console.ReadLine();
            double.TryParse(str, out double price);
            
            for (double j = 0.1; j<=1.0; j+=0.1)
            {
                string result = string.Format("{0:f2}", j * price);
                string ves = string.Format("{0:f1}", j);
                Console.WriteLine($"Цена {ves} кг конфет: {result}");                
            }            
        }
    }
}
