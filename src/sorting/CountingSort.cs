using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    static class CountingSort
    {
        public static void Sort(int[] array, int min, int max)
        {
            // C# initialises the array to zeros
            int[] buckets = new int[(max + 1) - min];

            for (int i = 0; i < array.Length; i++)
                buckets[array[i] - min]++;

            int writeIndex = 0;

            for (int i = 0; i < buckets.Length; i++) {
                for (int j = 0; j < buckets[i]; j++) {
                    array[writeIndex] = i + min;
                    writeIndex++;
                }
            }
        }
    }
}
