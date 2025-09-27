using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7

    {
        public int AngleToHoursMinutes(double f)
        {
     
            int minutes = Convert.ToInt32(f) * 2;
            int hours = minutes / 60;
            return hours;

        }
    }
}
