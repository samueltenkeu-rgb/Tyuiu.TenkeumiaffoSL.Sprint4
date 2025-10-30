using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint4.Task2.V7.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 5, 6, 7, 8, 9, 4, 6, 5, 8, 7, 6 };

            int res = ds.Calculate(array);

            int wait = 42;

            Assert.AreEqual(wait, res);
        }
    }
}