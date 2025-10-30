using Tyuiu.TenkeumiaffoSL.Sprint4.Task1.V17.Lib;

Console.Title = "Спринт #4 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Обработка структурных типов                                       *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму четных   *");
Console.WriteLine("* элементов массива. С клавиатуры: 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

int[] array = { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };

Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int result = ds.Calculate(array);

Console.WriteLine($"Сумма четных элементов массива = {result}");

Console.ReadLine();