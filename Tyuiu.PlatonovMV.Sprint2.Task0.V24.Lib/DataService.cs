using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PlatonovMV.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        // П ==, !=, <, >, <=, >=
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                (x + y) == 890,   // True
                x != y,           // True
                (x + y) < 800,    // False
                x > y,            // False
                x <= y,           // True
                (y - x) >= 600    // True
            };
        }
    }
}