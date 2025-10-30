using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint4.Task6.V11.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

            int res = ds.Calculate(array);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}