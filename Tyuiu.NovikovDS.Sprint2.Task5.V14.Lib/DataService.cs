using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovDS.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            int res = (k + d - 1) % 7;

            switch (res)
            {
                case 0: return "Воскресенье";
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                default: return "Неверные данные";
            }
        }
    }

}
