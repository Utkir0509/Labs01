using System;

namespace tema9z2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дни недели пронумерованы следующим образом: 
              0 — воскресенье, 1 — понедельник, 2 — вторник, . . . , 6 — суббота.
            Дано целое число K, лежащее в диапазоне 1–365.
            Определить номер дня недели для K-го дня года,
            если известно, что в этом году 1 января было понедельником.*/
            int n, num; //номер недели, номер дня недели дня К.
            string str;
            Console.WriteLine("Введите количество дней прошедших с начала года:");
            str = Console.ReadLine();
            Int32.TryParse(str, out int k);
            n = k / 7;
            num = k - n * 7;
            Console.WriteLine($"Номер дня недели: {num} для {k}-го дня");

        }
    }
}
