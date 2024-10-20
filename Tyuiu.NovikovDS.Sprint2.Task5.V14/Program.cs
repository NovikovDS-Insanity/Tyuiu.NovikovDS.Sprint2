using Tyuiu.NovikovDS.Sprint2.Task5.V14.Lib;
DataService ds = new();

Console.Title = "Спринт #2 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем     *");
Console.WriteLine("* недели (понедельником, вторником, …, субботой или воскресеньем)         *");
Console.WriteLine("* является k-й день не високосного года, в котором 1 января d-й день      *");
Console.WriteLine("* недели (если 1 января — понедельник, то d = 1 , если вторник — d = 2,  *");
Console.WriteLine("* …, если воскресенье — d = 7).                                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int d, k;

Console.WriteLine("Какой день 1 января пн, вт, .., вс (от 1 до 7):");
do
{
    d = Convert.ToInt32(Console.ReadLine());
    if ((d < 1) || (d > 7)) Console.WriteLine("Введите число от 1 до 7:");
} while ((d < 1) || (d > 7));


Console.WriteLine("Введите день (от 1 до 365):");
do
{
    k = Convert.ToInt32(Console.ReadLine());
    if ((k < 1) || (k > 365)) Console.WriteLine("Введите число от 1 до 365:");
} while ((k < 1) || (k > 365));

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.FindDayName(d, k));

Console.ReadLine();

