using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.AytuvorovTK.Sprint3.Task1.V17.Lib;

namespace Tyuiu.AytuvorovTK.Sprint3.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 4;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);


            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();

        }
    }
}

