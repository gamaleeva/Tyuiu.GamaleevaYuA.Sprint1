using Tyuiu.GamaleevaYuA.Sprint1.Task4.V27.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = -2.414;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
