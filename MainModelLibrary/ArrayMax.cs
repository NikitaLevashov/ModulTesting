using System;

namespace MainModelLibrary
{
    public static class ArrayMax
    {
        public static int FindMax(int[] array)
        {
            int max = array[0];

            for(int i = 0;i<array.Length;i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            return max;
        }

    


    }
}
