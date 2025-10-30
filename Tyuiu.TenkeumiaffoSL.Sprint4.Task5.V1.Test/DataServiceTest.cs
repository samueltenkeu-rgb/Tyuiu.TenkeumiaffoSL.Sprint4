using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint4.Task5.V1.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint4.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { -5, 3, -2, 1, 4 },
                { 2, -4, 2, -1, 5 },
                { -2, 2, -7, 2, -8 },
                { 1, -5, 4, -5, 4 },
                { -1, 2, -3, 2, -4 }
            };

            int[,] res = ds.Calculate(array);

            int[,] wait = new int[5, 5] {
                { -5, 1, -2, 1, 1 },
                { 1, -4, 1, -1, 1 },
                { -2, 1, -7, 1, -8 },
                { 1, -5, 1, -5, 1 },
                { -1, 1, -3, 1, -4 }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        }
    }
}