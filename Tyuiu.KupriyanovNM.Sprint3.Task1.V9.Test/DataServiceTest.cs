using Tyuiu.KupriyanovNM.Sprint3.Task1.V9.Lib;
namespace Tyuiu.KupriyanovNM.Sprint3.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 4;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = Math.Round(
                Math.Pow(300 / (Math.Cos(value) + Math.Pow(value, 1)), 1) *
                Math.Pow(300 / (Math.Cos(value) + Math.Pow(value, 2)), 2) *
                Math.Pow(300 / (Math.Cos(value) + Math.Pow(value, 3)), 3) *
                Math.Pow(300 / (Math.Cos(value) + Math.Pow(value, 4)), 4),
                3);

            Assert.AreEqual(wait, res);
        }
    }
}
