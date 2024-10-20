using Tyuiu.NovikovDS.Sprint2.Task6.V11.Lib;
DataService ds = new();

Console.Title = "Спринт #2 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Получение результата из switch                                    *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
Console.WriteLine("* определить дату следующего дня. Заданный год не является високосным.    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int g, m, n;

Console.WriteLine("Введите год:");
do
{
    g = Convert.ToInt32(Console.ReadLine());
    if (g < 0) Console.WriteLine("Год не может быть отрицательным:");
} while (g < 0);

Console.WriteLine("Введите месяц:");
m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число:");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.FindDateOfNextDay(g, m, n));

Console.ReadLine();

