using Tyuiu.AytuvorovTK.Sprint3.Task2.V15.Lib;
namespace Tyuiu.AytuvorovTK.Sprint3.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 482982.891;

            Assert.AreEqual(wait, res);
        }
    }
}
