using Tyuiu.GamaleevaYuA.Sprint1.Task1.V30.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(1.5, res);

        }
    }
}
