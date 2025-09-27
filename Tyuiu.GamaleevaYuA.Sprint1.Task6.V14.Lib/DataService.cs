using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GamaleevaYuA.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            string rus = "йцукенгшщзхъфывапролджэячсмитьбю ";
            int j = 0;
            foreach(var ch in value)
            {
                if (rus.Contains(ch))
                {
                    j++;
                }
            }
            if (j == value.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
