using System.Text.Json;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DolgovIV.Sprint6.Task3.V28.Lib
{
    public class DataService : ISprint6Task3V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            int[,] resmatr = matrix;

            for (int i = 0; i < rows; i++)
            {
                for (global::System.Int32 j = 0; j < cols; j++)
                {
                    if (matrix[i,j] == matrix[3,j] && matrix[i, j] % 2 == 0)
                    {
                        resmatr[i,j] = 0;
                    }
                }
            }

            return resmatr;
        }
    }
}
