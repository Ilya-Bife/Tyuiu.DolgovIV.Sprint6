using Tyuiu.Sprint6.DolgovIV.Task2.V10.Lib;

namespace Tyuiu.Sprint6.DolgovIV.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = { -19.62, -17.12, -18.15, -63.13, -24.92, -5, -1.46, 1.57, 6.38, 32.78, 225.11 };

            CollectionAssert.AreEqual(res, ds.GetMassFunction(-5, 5));
        }
    }
}
