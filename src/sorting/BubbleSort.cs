using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    static class BubbleSort
    {
        public static void Sort(int[] array)
        {
            bool swapped;

            do {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++) {
                    if (array[i] > array[i + 1]) {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
