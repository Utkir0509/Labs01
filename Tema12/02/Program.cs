using System;
using System.ComponentModel;

namespace tema12z2
{
    enum compassPoints { Север , Запад, Юг, Восток}
    class Program
    {
        static void Main(string[] args)
        {
            /* Робот может перемещаться в четырех направлениях («С» — север, «З» — запад, «Ю» — юг, «В» — восток) и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, −1 — поворот направо. Дан символ C — исходное направление робота и целое число N — посланная ему команда. Вывести направление робота после выполнения полученной команды
             */
            string str;
            compassPoints direction ; //текущее направление
            compassPoints directionDefault; //направление изначальное

            Console.WriteLine("Введите исходное направление робота");
            str = Console.ReadLine().ToUpper();
            
            switch (str)
            {
                case "C":
                    directionDefault = compassPoints.Север;
                    break;
                case "З":
                    directionDefault = compassPoints.Запад;
                    break;
                case "Ю":
                    directionDefault = compassPoints.Юг;
                    break;
                case "В":
                    directionDefault = compassPoints.Восток;
                    break;
                default:
                    directionDefault = compassPoints.Север; //по умолчанию вперед.
                    break;
            }

            Console.WriteLine("Введите команду - целое число: 0 — продолжать движение, 1 — поворот налево, —1 — поворот направо.");
            str = Console.ReadLine();
            Int32.TryParse(str, out int commandInput);
            Console.WriteLine($"Изначальное направление: {directionDefault}, команда: {commandInput}");
            //int dir1;
            direction = directionDefault;
            if (commandInput==1)
            {
                direction ++;
            }
            else if (commandInput == -1)
            {
                direction --;
            };
            if (direction < 0) direction = compassPoints.Восток;
            if ((int)direction > 3) direction = compassPoints.Север;             
             Console.WriteLine($"Направление робота после выполнения полученной команды - {direction}");
          }

    }
}
