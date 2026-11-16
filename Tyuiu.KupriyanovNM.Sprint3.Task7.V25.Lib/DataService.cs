using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KupriyanovNM.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Cos(x) + (4.0 * x) / 2 - Math.Sin(x) * 3 * x;
                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}
