using System;
using Tyuiu.PlatonovMV.Sprint2.Task1.V1.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task1.V1
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
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=) и       *");
            Console.WriteLine("* логических операций (|, &, ||, &&, !, ^) с арифметикой, которая вернет  *");
            Console.WriteLine("* массив: (True, False, True, False, True, False) при a=119, b=196,       *");
            Console.WriteLine("* c=134, d=327. Последовательность логических операций не нарушать.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 119, b = 196, c = 134, d = 327;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine($"1) (a < b) | (c > d)            -> {res[0]}");
            Console.WriteLine($"2) (a > b) & (c < d)            -> {res[1]}");
            Console.WriteLine($"3) (a * 2 == 238) || (d < c)    -> {res[2]}");
            Console.WriteLine($"4) (b <= a) && (d >= 400)       -> {res[3]}");
            Console.WriteLine($"5) !(d < a + b)                 -> {res[4]}");
            Console.WriteLine($"6) (b != c) ^ (d > a)           -> {res[5]}");

            Console.WriteLine();
            Console.WriteLine($"Массив: ({string.Join(", ", res)})");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}