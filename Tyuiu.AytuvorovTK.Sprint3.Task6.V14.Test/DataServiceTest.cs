using Tyuiu.AytuvorovTK.Sprint3.Task6.V14.Lib;
namespace Tyuiu.AytuvorovTK.Sprint3.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 7;
            int stopValue = 16;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}
