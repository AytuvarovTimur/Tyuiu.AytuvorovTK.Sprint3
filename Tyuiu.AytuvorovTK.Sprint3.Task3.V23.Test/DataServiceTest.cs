using Tyuiu.AytuvorovTK.Sprint3.Task3.V23.Lib;
namespace Tyuiu.AytuvorovTK.Sprint3.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "fdsst siu vsrs";

            char num = '8';

            char buk = 's';

            string res = ds.ReplaceCharOnNum(str, num, buk);

            string wait = "fd88t 8iu v8r8";

            Assert.AreEqual(wait, res);
        }
    }
}
