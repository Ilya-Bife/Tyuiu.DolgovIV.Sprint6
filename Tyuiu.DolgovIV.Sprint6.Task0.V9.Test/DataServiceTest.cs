using Tyuiu.DolgovIV.Sprint6.Task0.V9.Lib;

namespace Tyuiu.DolgovIV.Sprint6.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(ds.Calculate(3), -2.556);
        }
    }
}
