using Tyuiu.TenkeumiaffoSL.Sprint4.Task4.V28.Lib;

Console.Title = "Спринт #4 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Обработка структурных типов                                       *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 5. Заменить четные элементы *");
Console.WriteLine("* массива на 1.                                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] array = new int[5, 5] {
    { 3, 3, 1, 1, 4 },
    { 2, 4, 2, 1, 5 },
    { 2, 2, 2, 2, 2 },
    { 1, 5, 4, 5, 4 },
    { 1, 2, 3, 2, 4 }
};

DataService ds = new DataService();

Console.WriteLine("Исходный массив:");
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

int[,] result = ds.Calculate(array);

Console.WriteLine("Массив после замены четных элементов на 1:");
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.ReadLine();