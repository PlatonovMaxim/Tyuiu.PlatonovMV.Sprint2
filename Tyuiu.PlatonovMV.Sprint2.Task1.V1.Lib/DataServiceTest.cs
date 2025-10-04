using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PlatonovMV.Sprint2.Task1.V1.Lib
{
    
    // |, &, ||, &&, !, ^
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[]
            {
                // 1) |  True
                (a < b) | (c > d),

                // 2) &  False
                (a > b) & (c < d),

                // 3) || True
                (a * 2 == 238) || (d < c),

                // 4) && False
                (b <= a) && (d >= 400),

                // 5) !  True
                !(d < a + b),

                // 6) ^  False
                (b != c) ^ (d > a)
            };
        }
    }
}