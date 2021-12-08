using System;

namespace Lib_3
{
    public class CalculateModules
    {
        public int[] GetRowSum(int[,] numbers)
        {
            int[] sums = new int[numbers.GetLength(0)];
            int sum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sum += numbers[i, j];
                }
                sums[i] = sum;
            }
            return sums;
        }
    }
}
