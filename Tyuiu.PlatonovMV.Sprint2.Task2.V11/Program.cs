using System;
using Tyuiu.PlatonovMV.Sprint2.Task2.V11.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task2.V11
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if — полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые X и Y (1..15) и           *");
            Console.WriteLine("* определяет, находится ли точка в заштрихованной области (вариант 11).   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите X (1..15): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y (1..15): ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool inside = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(inside ? "Да, точка в заштрихованной области." : "Нет, точка вне области.");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}