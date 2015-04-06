using System;

namespace DataStructures.Sorting
{
    static class QuickSort
    {
        static Random rnd = new Random();

        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length);
        }

        // Quicksort array[begin..(end-1)]
        public static void Sort(int[] array, int begin, int end)
        {
            if (end - begin <= 1)
                return;

            int pivotIndex = rnd.Next(begin, end);
            Swap(array, pivotIndex, end - 1);
            pivotIndex = end - 1;

            int writeIndex = begin;

            for (int i = begin; i < end - 1; i++) {
                if (array[i] < array[pivotIndex]) {
                    Swap(array, writeIndex, i);
                    writeIndex++;
                }
            }

            Swap(array, pivotIndex, writeIndex);
            pivotIndex = writeIndex;

            Sort(array, begin, pivotIndex);
            Sort(array, pivotIndex + 1, end);
        }



        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
