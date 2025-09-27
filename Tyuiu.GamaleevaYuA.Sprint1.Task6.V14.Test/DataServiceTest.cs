using Tyuiu.GamaleevaYuA.Sprint1.Task6.V14.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strtest = "ф ро";
            bool wait = true;
            bool res = ds.CheckLowerCaseRusLetters(strtest);
            Assert.AreEqual(wait, res);
        }
    }
}
