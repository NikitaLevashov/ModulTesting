using System;
using System.Collections.Generic;
using System.Text;

namespace MainModelLibrary
{
    public static class FindAverageValue
    {
        public static double GetAverage(int[] array)
        {
            int sum = 0;

            for(int i=0;i<array.Length;i++)
            {
                sum += array[i];
            }

            return (double)sum / array.Length;
        }


    }
}
