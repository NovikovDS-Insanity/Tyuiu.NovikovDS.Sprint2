using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovDS.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (((x >=2) && (y >= 0) && (y <= 4)) || ((y >= 0) && (x >= 0) && (x <= 2) && (y <= Math.Pow(x, 2)))) { return true; }
            else { return false; }
        }
    }

}
