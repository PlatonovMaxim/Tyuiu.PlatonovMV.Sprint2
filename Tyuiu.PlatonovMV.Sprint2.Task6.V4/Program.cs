using System;
using Tyuiu.PlatonovMV.Sprint2.Task6.V4.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task6.V4
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Спринт #2 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт присвоены номера:                                 *");
            Console.WriteLine("* 1 — пики, 2 — трефы, 3 — бубны, 4 — червы.                              *");
            Console.WriteLine("* По заданному номеру масти определить её название.                       *");
            Console.WriteLine("* Использовать сокращённую форму записи switch.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти (1..4): ");
            int value = Convert.ToInt32(Console.ReadLine());

            var ds = new DataService();
            string result = ds.FindCardSuit(value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Масть карты: {result}");


            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}