using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KupriyanovNM.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;
            double value = 5;
            int k = startValue;

            do
            {
                multiplySeries = multiplySeries *
                    (1 / Math.Pow(Math.Cos(value) + 1, 2));

                k++;
            }
            while (k <= stopValue);

            return Math.Round(multiplySeries, 3);
        }
    }
}
