using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task2.V9.Lib
{
    public class DataService : ISprint1Task2V9
    {
        public double CalculateVolumeCircle(int r)
        {
            int x = 3;
            return Math.Round((4/3) * r * r * r * Math.PI, x);
        }
    }
}
