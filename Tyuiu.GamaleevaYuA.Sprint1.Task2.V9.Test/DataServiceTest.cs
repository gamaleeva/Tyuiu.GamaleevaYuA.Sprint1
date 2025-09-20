using Tyuiu.GamaleevaYuA.Sprint1.Task2.V9.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 6;
            var res = ds.CalculateVolumeCircle(x);
            Assert.AreEqual(904.779, res);

        }

    }
}
