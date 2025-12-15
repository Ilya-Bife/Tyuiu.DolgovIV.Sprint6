using Tyuiu.DolgovIV.Sprint6.Task4.V5.Lib;

namespace Tyuiu.DolgovIV.Sprint6.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] matr = { 70.14, 55.21, 41.05, 27.96, 15.48, 1, -13.06, -28.16, -42.96, -56.77, -69.83 };

            CollectionAssert.AreEqual(ds.GetMassFunction(-5, 5), matr);



        }
    }
}
