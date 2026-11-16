using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KupriyanovNM.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int maxCount = 0;
            int currentCount = 0;

            foreach (char symbol in value)
            {
                if (symbol == item)
                {
                    currentCount++;

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }
    }
}
