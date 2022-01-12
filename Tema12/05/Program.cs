using System;

namespace tema12z5
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            string str;

            Console.WriteLine("Введите год");
            str = Console.ReadLine();
            Int32.TryParse(str, out int year);

            str = "";
            year = year - 1924;
            i = (year % 60) % 12;
            int j= year % 10;
            //Console.WriteLine($"j:{j}");
            switch (j)
            {
                case 0:
                case 1:
                    str = "зелёной";
                    break;

                case 2:
                case 3:
                    str = "красной";
                    break;
                case 4:
                case 5:
                    str = "жёлтой";
                    break;
                case 6:
                case 7:
                    str = "белой";
                    break;
                case 8:
                case 9:
                    str = "чёрной";
                    break;
                default:
                    str = "ошибка";
                    break;
            }

            switch (year % 12)
            {
                case 0:
                    str += " крысы";
                    break;
                case 1:
                    str += " коровы";
                    break;
                case 2:
                    str += " тигра";
                    break;
                case 3:
                    str += " зайца";
                    break;
                case 4:
                    str += " дракона";
                    break;
                case 5:
                    str += " змеи";
                    break;
                case 6:
                    str += " лошади";
                    break;
                case 7:
                    str += " овцы";
                    break;
                case 8:
                    str += " обезьяны";
                    break;
                case 9:
                    str += " курицы";
                    break;
                case 10:
                    str += " собаки";
                    break;
                case 11:
                    str += " свиньи";
                    break;
                case -1:
                    str += " свиньи";
                    break;
                case -2:
                    str += " собаки";
                    break;
                case -3:
                    str += " курицы";
                    break;
                case -4:
                    str += " обезьяны";
                    break;
                case -5:
                    str += " овцы";
                    break;
                case -6:
                    str += " лошади";
                    break;
                case -7:
                    str += " змеи";
                    break;
                case -8:
                    str += " дракона";
                    break;
                case -9:
                    str += " зайца";
                    break;
                case -10:
                    str += " тигра";
                    break;
                case -11:
                    str += " коровы";
                    break;
            }
            
            Console.WriteLine(str);
        }
    }
}
