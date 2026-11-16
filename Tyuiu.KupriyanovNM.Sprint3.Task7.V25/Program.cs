using Tyuiu.KupriyanovNM.Sprint3.Task7.V25.Lib;
namespace Tyuiu.KupriyanovNM.Sprint3.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.Title = "Спринт #3 | Выполнил: Куприянов Н. М. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Никита Максимович | ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* F(x) = cos(x) + 4x/2 - sin(x) * 3x                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Начало диапазона = " + startValue);
            Console.WriteLine("Конец диапазона = " + stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("---------------------");
            Console.WriteLine("|    x    |   f(x)  |");
            Console.WriteLine("---------------------");
            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine(
                    "| {0,5}   | {1,6:F2}  |",
                    startValue + i,
                    valueArray[i]);
            }

            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}
