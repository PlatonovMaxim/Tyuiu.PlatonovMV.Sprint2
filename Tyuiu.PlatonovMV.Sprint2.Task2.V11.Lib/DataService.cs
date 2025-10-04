using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PlatonovMV.Sprint2.Task2.V11.Lib
{
    public class DataService : ISprint2Task2V11
    {
        // Проверяет принадлежность точки (x,y) заштрихованной области варианта 11
        // Координаты: 1..15, отсчет от левого верхнего угла (x вправо, y вниз).
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 1 || x > 15 || y < 1 || y > 15) return false;

            // Центральный прямоугольник: x=6..9, y=5..10
            bool r1 = (x >= 6 && x <= 9 && y >= 5 && y <= 10);

            // Колонка: x=10, y=8..10
            bool r2 = (x == 10 && y >= 8 && y <= 10);

            // Две колонки: x=11..12, y=5..11
            bool r3 = (x >= 11 && x <= 12 && y >= 5 && y <= 11);

            // Блок сверху слева: x=3..5, y=3..4
            bool r4 = (x >= 3 && x <= 5 && y >= 3 && y <= 4);

            // Доп. клетки сверху справа от блока: (9,3), (9,4)
            bool r5 = (x == 9 && (y == 3 || y == 4));

            // Ряд: y=7, x=2..5
            bool r6 = (y == 7 && x >= 2 && x <= 5);

            // Ряд: y=11, x=3..7
            bool r7 = (y == 11 && x >= 3 && x <= 7);

            // Одиночные точки
            bool p1 = (x == 7 && y == 12); // (7,12)
            bool p2 = (x == 13 && y == 8); // (13,8)

            return r1 || r2 || r3 || r4 || r5 || r6 || r7 || p1 || p2;
        }
    }
}