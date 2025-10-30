using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TenkeumiaffoSL.Sprint4.Task3.V4.Lib
{
    public class DataService : ISprint4Task3V4
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int min = int.MaxValue;

            for (int i = 0; i < rows; i++)
            {
                if (array[i, columns - 1] < min)
                {
                    min = array[i, columns - 1];
                }
            }

            return min;
        }
    }
}