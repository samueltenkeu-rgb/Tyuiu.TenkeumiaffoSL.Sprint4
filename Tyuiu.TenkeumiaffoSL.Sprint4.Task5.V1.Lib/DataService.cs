using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TenkeumiaffoSL.Sprint4.Task5.V1.Lib
{
    public class DataService : ISprint4Task5V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (result[i, j] > 0)
                    {
                        result[i, j] = 1;
                    }
                }
            }

            return result;
        }
    }
}