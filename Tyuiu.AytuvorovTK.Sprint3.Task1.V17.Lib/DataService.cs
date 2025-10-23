using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AytuvorovTK.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multseries = 1;
            while (startValue <= stopValue)
            {
                multseries *= Math.Pow(2 / Math.Cos(value), startValue);
                startValue++;
            }
            return Math.Round(multseries, 2);
        }
    }
}
