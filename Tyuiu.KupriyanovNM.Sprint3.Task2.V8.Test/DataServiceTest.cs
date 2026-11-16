using Tyuiu.KupriyanovNM.Sprint3.Task2.V8.Lib;
namespace Tyuiu.KupriyanovNM.Sprint3.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double factor = 1 / Math.Pow(Math.Cos(5) + 1, 2);
            double wait = Math.Round(Math.Pow(factor, 15), 3);

            Assert.AreEqual(wait, res);
        }
    }
}
