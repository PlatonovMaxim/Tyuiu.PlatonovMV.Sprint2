using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PlatonovMV.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int day = n;
            int month = m;
            int year = g;

            int daysInMonth = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    // год невисокосный в феврале 28 дней
                    daysInMonth = 28;
                    break;
                default:
                    throw new ArgumentException("Неверный номер месяца");
            }

            day++;

            if (day > daysInMonth)
            {
                day = 1;
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
            // по новой если больше чем надо и прибавляется

            return $"{day:D2}.{month:D2}.{year}";
        }
    }
}