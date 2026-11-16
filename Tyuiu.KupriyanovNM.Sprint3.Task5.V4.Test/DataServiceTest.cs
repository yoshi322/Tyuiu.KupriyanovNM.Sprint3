using Tyuiu.KupriyanovNM.Sprint3.Task5.V4.Lib;
namespace Tyuiu.KupriyanovNM.Sprint3.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            double res = ds.GetSumSumSeries(
                x,
                startValue1,
                startValue2,
                stopValue1,
                stopValue2);


            double expected = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    expected = expected + x / System.Math.Cos(k);
                }
            }

            expected = System.Math.Round(expected, 3);

            Assert.AreEqual(expected, res);
        }
    }
}
