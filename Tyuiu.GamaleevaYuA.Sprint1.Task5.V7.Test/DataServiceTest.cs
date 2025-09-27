using Tyuiu.GamaleevaYuA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = ds.AngleToHoursMinutes(x);

            int res = Convert.ToInt32(y);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
