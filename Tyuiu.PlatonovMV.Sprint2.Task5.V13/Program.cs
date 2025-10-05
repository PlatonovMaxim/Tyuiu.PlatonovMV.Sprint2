using System;
using Tyuiu.PlatonovMV.Sprint2.Task5.V13.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task5.V13
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Спринт #2 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня задаётся тремя числами: g – год, m – месяц,         *");
            Console.WriteLine("* n – день. Определить дату следующего дня. Год считать невисокосным.     *");
            Console.WriteLine("* Использовать оператор switch.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите год (g): ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц (m): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            var ds = new DataService();
            string res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Следующий день: {res}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}