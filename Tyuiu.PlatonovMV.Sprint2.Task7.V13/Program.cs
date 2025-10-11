using System;
using Tyuiu.PlatonovMV.Sprint2.Task7.V13.Lib;

namespace Tyuiu.PlatonovMV.Sprint2.Task7.V13
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Title = "Спринт #2 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить, находится ли точка с координатами (x, y) в закрашенной       *");
            Console.WriteLine("* области. Фигуры: окружность x^2 + y^2 = 1, прямая y = 1, прямая y = x-1 *");
            Console.WriteLine("* Закрашена правая половина круга и область между указанными прямыми.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            var ds = new DataService();
            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (result)
                Console.WriteLine("Да, точка находится в закрашенной области.");
            else
                Console.WriteLine("Нет, точка не принадлежит закрашенной области.");


            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}