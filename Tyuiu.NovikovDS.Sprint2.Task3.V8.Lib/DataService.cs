using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovDS.Sprint2.Task3.V8.Lib
{
    public class DataService : ISprint2Task3V8
    {
        public double Calculate(double x)
        {
            if (x > 0) return Math.Round(((Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x))), 3);
            else if (x == 0) return Math.Round(((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12)), 3);
            else if ((x > -12) && (x < 0)) return Math.Round((Math.Pow((1 + (3 / Math.Pow(x, 2))), x)), 3);
            else return Math.Round((x + 10 * x - (5 / x)), 3);
        }
    }

}
