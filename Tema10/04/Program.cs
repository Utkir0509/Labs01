using System;

namespace tema10z4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано трехзначное число. Проверить истинность высказывания:
            //«Цифры данного числа образуют возрастающую
            //или убывающую последовательность».
            string str;
            Boolean posledovVozr = false, posledovUbyv = false;
            int a,b,c; // цифры из которых состоит число

            Console.WriteLine("Введите целое трехзначное число");
            str = Console.ReadLine();
            Int32.TryParse(str, out int n);
            
            a = n / 100 ; //первая цифра числа.            
            b = (n % 100) / 10; //вторая цифра числа.
            c = (n % 100) % 10; //третья цифра числа.
            if ((c > b) & (b >a)) posledovVozr = true; //проверяем что последовательность возрастающая.
            if ((a > b) & (b > c)) posledovUbyv = true; //проверяем что последовательность убывающая.

            //Console.WriteLine($"цифры:{a}, {b}, {c}");
            Console.WriteLine($"Число : {n} состоит из цифр образущих последовательность возрастающую: {posledovVozr}, убывающую: {posledovUbyv}.");
        }
    }
}
