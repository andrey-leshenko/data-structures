using System;

namespace DataStructures.Sorting
{
    static class MergeSort
    {
        public static void Sort(int[] array)
        {
            int[] mergeBuffer = new int[array.Length];
            Sort(array, 0, array.Length, mergeBuffer);
        }

        // Merge sort the range array[begin..(end-1)]
        static void Sort(int[] array, int begin, int end, int[] mergeBuffer)
        {
            if (end - begin <= 1)
                return;

            int middle = (end - begin) / 2 + begin;
            Sort(array, begin, middle, mergeBuffer);
            Sort(array, middle, end, mergeBuffer);

            Merge(array, begin, middle, end, mergeBuffer);
        }

        // First half: [begin..middle - 1]
        // Second half: [middle..end - 1]
        // Merges the halves to the output buffer
        static void Merge(int[] array, int begin, int middle, int end, int[] tempBuffer)
        {
            int i = begin;
            int j = middle;

            int writeIndex = begin;

            while (i < middle && j < end)
                if (array[i] <= array[j])
                    tempBuffer[writeIndex++] = array[i++];
                else
                    tempBuffer[writeIndex++] = array[j++];

            while (i < middle)
                tempBuffer[writeIndex++] = array[i++];

            while (j < end)
                tempBuffer[writeIndex++] = array[j++];

            for (int k = begin; k < end; k++)
                array[k] = tempBuffer[k];
        }
    }
}
