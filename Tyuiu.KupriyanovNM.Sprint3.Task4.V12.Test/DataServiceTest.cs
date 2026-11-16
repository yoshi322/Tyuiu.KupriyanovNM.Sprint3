using Tyuiu.KupriyanovNM.Sprint3.Task4.V12.Lib;
namespace Tyuiu.KupriyanovNM.Sprint3.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait =
                (-5 / (-5 + Math.Sin(-5)) + 2.5) *
                (-4 / (-4 + Math.Sin(-4)) + 2.5) *
                (-3 / (-3 + Math.Sin(-3)) + 2.5) *
                (-2 / (-2 + Math.Sin(-2)) + 2.5) *
                (-1 / (-1 + Math.Sin(-1)) + 2.5);

            wait = Math.Round(wait, 3);

            Assert.AreEqual(wait, res);
        }
    }
}
