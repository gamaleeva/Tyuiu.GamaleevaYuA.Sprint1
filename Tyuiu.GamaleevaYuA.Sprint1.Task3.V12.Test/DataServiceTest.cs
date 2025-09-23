using Tyuiu.GamaleevaYuA.Sprint1.Task3.V12.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 12;
            int b = 6;
            var res = 36;
            Assert.AreEqual(res, ds.TriangleArea(a, b));

        }
    }
}
