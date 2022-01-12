using System;

namespace tema12z4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дано целое число в диапазоне 100–999.
             * Вывести строку - описание данного числа, 
             * например: 256 — «двести пятьдесят шесть», 
             * 814 — «восемьсот четырнадцать».*/
            int n1, n2, n3;
            string str;

            Console.WriteLine("Введите целое число в диапазоне от 100 до 999");
            str = Console.ReadLine();
            Int32.TryParse(str, out int a);

            str = "";
            n1 = a / 100;
            n2 = (a % 100) / 10;
            n3 = (a % 100) % 10;

            switch (n1)
            {
                case 1:
                    str =  "Сто ";
                    break;
                case 2:
                    str =  "Двести ";
                    break;
                case 3:
                    str =  "Триста ";
                    break;
                case 4:
                    str =  "Четыреста ";
                    break;
                case 5:
                    str =  "Пятьсот ";
                    break;
                case 6:
                    str =  "Шестьсот ";
                    break;
                case 7:
                    str =  "Семьсот ";
                    break;
                case 8:
                    str =  "Восемсот ";
                    break;
                case 9:
                    str =  "Девятсот ";
                    break;
            }
            if (((a % 100) >= 10) & ((a % 100) < 20)){
                switch (a % 100)
                {
                    case 11:
                        str +=  "одиннадцать";
                        break;
                    case 12:
                        str +=  "двенадцать";
                        break;
                    case 13:
                        str +=  "тринадцать";
                        break;
                    case 14:
                        str +=  "четырнадцать";
                        break;
                    case 15:
                        str +=  "пятнадцать";
                        break;
                    case 16:
                        str +=  "шестнадцать";
                        break;
                    case 17:
                        str +=  "семнадцать";
                        break;
                    case 18:
                        str +=  "восемнадцать";
                        break;
                    case 19:
                        str +=  "девятнадцать";
                        break;
                    case 10:
                        str +=  "десять";
                        break;
                }
            }
            switch (n2)
            {
                case 2:
                    str +=  "двадцать ";
                    break;
                case 3:
                    str +=  "тридцать ";
                    break;
                case 4:
                    str +=  "сорок ";
                    break;
                case 5:
                    str +=  "пятьдесят ";
                    break;
                case 6:
                    str +=  "шестьдесят ";
                    break;
                case 7:
                    str +=  "семьдесят ";
                    break;
                case 8:
                    str +=  "восемьдесят ";
                    break;
                case 9:
                    str +=  "девяносто ";
                    break;
            }
            if ((a % 100) > 20)
            {
                switch (n3)
                {
                    case 1:
                        str += "один";
                        break;
                    case 2:
                        str += "два";
                        break;
                    case 3:
                        str += "три";
                        break;
                    case 4:
                        str += "четрые";
                        break;
                    case 5:
                        str += "пять";
                        break;
                    case 6:
                        str += "шесть";
                        break;
                    case 7:
                        str += "семь";
                        break;
                    case 8:
                        str += "восемь";
                        break;
                    case 9:
                        str += "девять";
                        break;
                }
            }
            Console.WriteLine($"Число:{a}, строка:{str}");
        }
    }
}
