using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DolgovIV.Sprint6.Task2.V10.Lib
{
    public class DataService : ISprint6Task2V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[Math.Abs(startValue) + Math.Abs(stopValue) + 1];
            for (int i = 0; i < res.Length; i++)
            {
                int j = i - 5;
                if ((Math.Sin(j) + 1) == 0)
                {
                    res[i] = 0;
                    continue;
                }
                res[i] = Math.Round(2 * j - 4 + (2 * j - 1) / (Math.Sin(j) + 1), 2);
            }
            return res;
        }
    }
}
