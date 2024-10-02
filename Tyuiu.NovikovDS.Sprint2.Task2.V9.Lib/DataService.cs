using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovDS.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (((x >= 3) && (x <= 5) && (y  >= 3) && (y <= 4)) || ((x == 4) && (y >= 5) && (y <= 10)) || ((x >= 3) && (x <= 12) && (y == 11)) || ((x >= 7) && (x <= 10) && (y == 12)) || ((x >= 6) && (x <= 12) && (y >= 9) && (y <= 10)) || ((x >= 8) && (x <= 13) && (y >= 6) && (y <= 8)) || ((x == 7) && (y == 6)) || ((x >= 8) && (x <= 12) && (y == 5)) || ((x >= 9) && (x <= 12) && (y >= 3) && (y <= 4))) { return true; }
            else { return false; }
        }
    }

}
