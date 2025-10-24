using Tyuiu.AytuvorovTK.Sprint3.Task4.V18.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint3.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага шага = {stopValue}");



            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine($"Сумма ряда: {ds.Calculate(startValue, stopValue)}");
            Console.ReadKey();

        }
    }
}
