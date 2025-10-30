using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TenkeumiaffoSL.Sprint4.Task1.V17.Lib
{
    public class DataService : ISprint4Task1V17
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0) 
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}