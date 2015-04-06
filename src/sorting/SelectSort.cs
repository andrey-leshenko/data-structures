using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    static class SelectSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;
                Swap(array, i, minIndex);
            }
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
