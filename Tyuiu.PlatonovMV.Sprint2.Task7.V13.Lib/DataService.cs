using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PlatonovMV.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // область один правая часть круга x^2 + y^2 <= 1 и x >= 0
            bool insideCircle = (x >= 0) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1);

            // область два за пределами круга между прямыми y = x - 1 и y = 1
            bool triangleZone = (x >= 0) && (y >= x - 1) && (y <= 1);

            return insideCircle || triangleZone;
        }
    }
}

// 1 4 четверть
// треугольник
//