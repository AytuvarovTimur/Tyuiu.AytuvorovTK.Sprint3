using Tyuiu.AytuvorovTK.Sprint3.Task7.V21.Lib;
namespace Tyuiu.AytuvorovTK.Sprint3.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] valueMaitArray;
            valueMaitArray = new double[len];

            valueMaitArray[0] = 28.85;
            valueMaitArray[1] = 21.04;
            valueMaitArray[2] = 15.03;
            valueMaitArray[3] = 11.75;
            valueMaitArray[4] = 9.62;
            valueMaitArray[5] = -2.00;
            valueMaitArray[6] = 1.62;
            valueMaitArray[7] = -8.25;
            valueMaitArray[8] = -14.97;
            valueMaitArray[9] = -18.96;
            valueMaitArray[10] = -21.15;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueMaitArray, res);
        }
    }
}
