using Tyuiu.KupriyanovNM.Sprint3.Task0.V28.Lib;
namespace Tyuiu.KupriyanovNM.Sprint3.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;
            Console.Title = "Спринт #3 | Выполнил: Куприянов Н. М. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Куприянов Никита Максимович | ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* ряда по формуле, при X=0,25                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + value);
            Console.WriteLine("начальное значение = " + startValue);
            Console.WriteLine("конечное значение = " + stopValue);

            double result = ds.GetMultiplySeries(
                value,
                startValue,
                stopValue);

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + result);

            Console.ReadKey();
        }
    }
}
