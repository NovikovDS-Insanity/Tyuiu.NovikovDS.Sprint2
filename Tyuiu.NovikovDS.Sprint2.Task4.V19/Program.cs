using Tyuiu.NovikovDS.Sprint2.Task4.V19.Lib;
DataService ds = new();

Console.Title = "Спринт #2 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции  с     *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
Console.WriteLine("* переменных x,y с клавиатуры.                                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
do
{
    y = Convert.ToDouble(Console.ReadLine());
    if ((y == 0) && ((x / 2) < (y - 6))) Console.WriteLine("Введите другое значение Y (происходит деление на ноль):");
} while ((y == 0) && ((x / 2) < (y - 6)));


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));

Console.ReadLine();

