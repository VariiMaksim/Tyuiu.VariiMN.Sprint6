using Tyuiu.VariiMN.Sprint6.Task0.V9.Lib;

namespace Tyuiu.VariiMN.Sprint6.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -2.556;
            Assert.AreEqual(wait, res);
        }
    }
}
