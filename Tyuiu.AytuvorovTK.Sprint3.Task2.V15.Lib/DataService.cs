using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AytuvorovTK.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumseries = 1;
            int k = startValue;
            do
            {
                double denominator = Math.Pow(value, k);
                double demo = 1 / 2;
                double term = (denominator + demo) * Math.Cos(k);
                sumseries *= term;
                k++;
            } while (k <= stopValue);
            return Math.Round(sumseries, 3);
        }
    }
}
