using Tyuiu.TenkeumiaffoSL.Sprint4.Task2.V7.Lib;
using System;

Console.Title = "Спринт #4 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Обработка структурных типов                                       *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
Console.WriteLine("* случайными значениями в диапазоне от 4 до 9 подсчитать сумму четных     *");
Console.WriteLine("* элементов массива.                                                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
Random rand = new Random();
int[] array = new int[12];

// Заполняем массив случайными числами от 4 до 9
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(4, 10);
}

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