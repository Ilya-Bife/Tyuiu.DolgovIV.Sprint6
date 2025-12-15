using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DolgovIV.Sprint6.Task4.V5.Lib
{
    public class DataService : ISprint6Task4V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valuearray;
            int len = (stopValue - startValue) + 1;
            valuearray = new double[len];

            double y;
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (3 * i + 1.2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((2 * Math.Sin(i)) / (3 * i + 1.2) + Math.Cos(i) - 7 * i * 2, 2);
                }
                
                valuearray[count] = y;
                count++;
            }

            return valuearray;

        }
    }
}
