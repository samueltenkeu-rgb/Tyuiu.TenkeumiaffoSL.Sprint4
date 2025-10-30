using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TenkeumiaffoSL.Sprint4.Task6.V11.Lib
{
    public class DataService : ISprint4Task6V11
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            foreach (string element in array)
            {
                if (element.Length == 5)
                {
                    count++;
                }
            }

            return count;
        }
    }
}