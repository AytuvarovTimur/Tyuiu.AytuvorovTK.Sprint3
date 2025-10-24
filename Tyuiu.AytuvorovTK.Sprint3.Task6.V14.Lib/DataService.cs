using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AytuvorovTK.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int i = 6; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }
    }
}
