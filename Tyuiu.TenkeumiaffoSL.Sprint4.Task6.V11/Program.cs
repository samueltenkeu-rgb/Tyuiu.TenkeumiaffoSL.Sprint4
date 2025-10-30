using Tyuiu.TenkeumiaffoSL.Sprint4.Task6.V11.Lib;

Console.Title = "Спринт #4 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Обработка структурных типов                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных [Кошка, Собака, Слон, Жираф, Бегемот,      *");
Console.WriteLine("* Игуана, Ягуар] используя класс Array подсчитайте количество элементов,  *");
Console.WriteLine("* длина которых равна 5.                                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string[] array = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

DataService ds = new DataService();

Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"array[{i}] = \"{array[i]}\" (длина: {array[i].Length})");
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int result = ds.Calculate(array);

Console.WriteLine($"Количество элементов с длиной 5 = {result}");

Console.ReadLine();