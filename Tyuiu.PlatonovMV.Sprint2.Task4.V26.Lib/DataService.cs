using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PlatonovMV.Sprint2.Task4.V26.Lib
{
    public class DataService : ISprint2Task4V26
    {
        public double Calculate(double x, double y)
        {

            // если x - 2 < y / 2, то z = (10 + 2 / x^2)^y
            // иначе z = x^2 - (1 / y)

            double z = (x - 2 < y / 2)
                ? Math.Pow(10 + 2 / Math.Pow(x, 2), y)
                : Math.Pow(x, 2) - (1 / y);

            return Math.Round(z, 3);
        }
    }
}