using Tyuiu.AytuvorovTK.Sprint3.Task3.V23.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint3.Task2.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                                                                                                            *");
            Console.WriteLine("***********************************************************************************************************************************************************************************************************************************************");

            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';
            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Заменяемый символ: {replaceable}");
            Console.WriteLine($"Заменяющий символ: {replacement}");



            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine($"Строка с замененым симбволом на цифру: {ds.ReplaceCharOnNum(value, replaceable, replacement)}");

            Console.ReadKey();

        }
    }
}
