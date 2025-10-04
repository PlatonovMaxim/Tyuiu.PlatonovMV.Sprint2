using System;
using Tyuiu.PlatonovMV.Sprint2.Task0.V24.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task0.V24
{
    internal class Program
    {
        static void Main()
        {
            var ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения.                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=) и       *");
            Console.WriteLine("* арифметических выражений, которая вернет массив:                        *");
            Console.WriteLine("* (True, True, False, False, True, True) при x = 135, y = 755.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 135;
            int y = 755;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetCompareOperations(x, y);

            Console.WriteLine($"1) (x + y) == 890  -> {res[0]}");
            Console.WriteLine($"2) x != y          -> {res[1]}");
            Console.WriteLine($"3) (x + y) < 800   -> {res[2]}");
            Console.WriteLine($"4) x > y           -> {res[3]}");
            Console.WriteLine($"5) x <= y          -> {res[4]}");
            Console.WriteLine($"6) (y - x) >= 600  -> {res[5]}");

            Console.WriteLine();
            Console.WriteLine($"Массив: ({string.Join(", ", res).Replace("True", "True").Replace("False", "False")})");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}