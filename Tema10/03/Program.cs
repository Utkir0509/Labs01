using System;

namespace tema10z3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано целое положительное число. Проверить истинность высказывания: «Данное число является четным двузначным».
            string str;
            Boolean chet=false, dvuZnachnoe=false;
            int b;
            Console.WriteLine("Введите целое положительное число");
            str = Console.ReadLine();
            Int32.TryParse(str, out int a);

            //b=a % 2;
            if (a % 2 == 0) chet = true; //проверяем четность.
            if ((a / 10 >= 1) & (a / 10 < 10)) dvuZnachnoe =true; //проверяем двузначность.

            Console.WriteLine($"Число : {a} четное: {chet}, двузначное: {dvuZnachnoe}.");
        }
    }
}
