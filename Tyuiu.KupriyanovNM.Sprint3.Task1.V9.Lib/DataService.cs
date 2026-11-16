using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KupriyanovNM.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                double term = Math.Pow(
                    300 / (Math.Cos(value) + Math.Pow(value, k)),
                    k);

                multiplySeries = multiplySeries * term;
                k++;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}
