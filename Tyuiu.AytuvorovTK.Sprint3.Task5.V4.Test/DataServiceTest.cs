using Tyuiu.AytuvorovTK.Sprint3.Task5.V4.Lib;
namespace Tyuiu.AytuvorovTK.Sprint3.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 3328.185;

            Assert.AreEqual(wait, res);
        }
    }
}
