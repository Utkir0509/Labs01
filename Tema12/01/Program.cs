using System;

namespace tema12z1
{
    enum month { января = 1, февраля, марта, апреля, мая, июня, июля, августа, сентября, октября, ноября, декабря}

    class Program
    {
        static void Main(string[] args)
        {
            //Дан номер дня – целое число от 1 до 31 и
            //месяца — целое число в диапазоне 1–12 (1 — январь, 2 — февраль и т. д.).
            //Вывести дату в виде текста (например, «пятое января»).
            string str;
            string dayString = "";

            Console.WriteLine("Введите № дня");
            str = Console.ReadLine();
            Int32.TryParse(str, out int d);
            Console.WriteLine("Введите № месяца");
            str = Console.ReadLine();
            Int32.TryParse(str, out int m);

            month monthString = (month)m;

            switch (d)
            {
                case 1:
                    {
                        dayString = "Первое ";
                        break;
                    }
                case 2:
                    {
                        dayString = "Второе ";
                        break;
                    }
                case 3:
                    {
                        dayString = "Третье ";
                        break;
                    }
                case 4:
                    {
                        dayString = "Четвертое ";
                        break;
                    }
                case 5:
                    {
                        dayString = "Пятое ";
                        break;
                    }
                case 6:
                    {
                        dayString = "Шестое ";
                        break;
                    }
                case 7:
                    {
                        dayString = "Седьмое ";
                        break;
                    }
                case 8:
                    {
                        dayString = "Восьмое ";
                        break;
                    }
                case 9:
                    {
                        dayString = "Девятое ";
                        break;
                    }
                case 10:
                    {
                        dayString = "Десятое ";
                        break;
                    }
                case 11:
                    {
                        dayString = "Одиннадцатое ";
                        break;
                    }
                case 12:
                    {
                        dayString = "Двенадцатое ";
                        break;
                    }
                case 13:
                    {
                        dayString = "Тринадцатое ";
                        break;
                    }
                case 14:
                    {
                        dayString = "Четырнадцатое ";
                        break;
                    }
                case 15:
                    {
                        dayString = "Пятнадцатое ";
                        break;
                    }
                case 16:
                    {
                        dayString = "Шестнадцатое ";
                        break;
                    }
                case 17:
                    {
                        dayString = "Семнадцатое ";
                        break;
                    }
                case 18:
                    {
                        dayString = "Восемнадцатое ";
                        break;
                    }
                case 19:
                    {
                        dayString = "Девятнадцатое ";
                        break;
                    }
                case 20:
                    {
                        dayString = "Двадцатое ";
                        break;
                    }
                case 21:
                    {
                        dayString = "Двадцать первое ";
                        break;
                    }
                case 22:
                    {
                        dayString = "Двадцать второе ";
                        break;
                    }
                case 23:
                    {
                        dayString = "Двадцать третье ";
                        break;
                    }
                case 24:
                    {
                        dayString = "Двацать четвертое ";
                        break;
                    }
                case 25:
                    {
                        dayString = "Двацать пятое ";
                        break;
                    }
                case 26:
                    {
                        dayString = "Двацать шестое ";
                        break;
                    }
                case 27:
                    {
                        dayString = "Двацать седьмое ";
                        break;
                    }
                case 28:
                    {
                        dayString = "Двацать восьмое ";
                        break;
                    }
                case 29:
                    {
                        dayString = "Двацать девятое ";
                        break;
                    }
                case 30:
                    {
                        dayString = "Тридцатое ";
                        break;
                    }
                case 31:
                    {
                        dayString = "Тридцать первое ";
                        break;
                    }
            }
            //Console.WriteLine($"День:{d} месяц:{m}");
            Console.WriteLine($"Дата: {dayString}{monthString}");
        }
    }
}
