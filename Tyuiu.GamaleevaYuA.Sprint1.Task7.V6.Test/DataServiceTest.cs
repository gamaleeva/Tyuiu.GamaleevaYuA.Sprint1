using Tyuiu.GamaleevaYuA.Sprint1.Task7.V6.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = -22;
            Assert.AreEqual(res, wait);

        }
    }
}
