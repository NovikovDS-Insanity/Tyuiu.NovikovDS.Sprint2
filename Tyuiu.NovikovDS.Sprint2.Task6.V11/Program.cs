using Tyuiu.NovikovDS.Sprint2.Task6.V11.Lib;
DataService ds = new();

Console.Title = "Спринт #2 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
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

Console.WriteLine("Введите год:");
int g = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите месяц:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.FindDateOfNextDay(g, m, n));

Console.ReadLine();

