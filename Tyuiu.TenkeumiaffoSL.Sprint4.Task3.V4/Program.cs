using Tyuiu.TenkeumiaffoSL.Sprint4.Task3.V4.Lib;

Console.Title = "Спринт #4 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Обработка структурных типов                                       *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Найдите минимальный      *");
Console.WriteLine("* элемент в последнем столбце массива.                                    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] array = new int[5, 5] {
    { 6, 5, 4, 1, 5 },
    { 8, 2, 3, 4, 2 },
    { 3, 7, 7, 1, 3 },
    { 3, 4, 8, 1, 3 },
    { 4, 3, 5, 5, 2 }
};

DataService ds = new DataService();

Console.WriteLine("Массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int result = ds.Calculate(array);

Console.WriteLine($"Минимальный элемент в последнем столбце массива = {result}");

Console.ReadLine();