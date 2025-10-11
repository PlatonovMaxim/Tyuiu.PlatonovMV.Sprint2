using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PlatonovMV.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            
            string suit = value switch
            {
                1 => "Пики",
                2 => "Трефы",
                3 => "Бубны",
                4 => "Червы",
                _ => "Некорректное значение! Введите число от 1 до 4"
            };

            return suit;
        }
    }
}