using Tyuiu.TenkeumiaffoSL.Sprint4.Task7.V17.Lib;

Console.Title = "Спринт #4 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Обработка структурных типов                                       *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр '753159864'. Преобразуйте ее в        *");
Console.WriteLine("* матрицу 3 на 3 и подсчитайте количество четных чисел.                   *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "753159864";
int n = 3;
int m = 3;

DataService ds = new DataService();

Console.WriteLine($"Исходная строка: '{value}'");
Console.WriteLine($"Размер матрицы: {n} x {m}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int result = ds.Calculate(n, m, value);

Console.WriteLine($"Количество четных чисел в матрице = {result}");

Console.ReadLine();