using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AytuvarovTK.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumseries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                double term = (Math.Pow(value, 2 * i) + 1.0 / (i + 1)) * Math.Cos(value);
                sumseries += term;
            }
            return Math.Round(sumseries, 3);
        }
    }
}
