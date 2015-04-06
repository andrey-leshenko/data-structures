using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Sorting;

namespace DataStructures.Examples
{
    static class SortingExamples
    {
        static Random rnd = new Random();

        public static void BubbleSortExample()
        {
            int[] array = RandomArray(20, 0, 21);
            PrintArray(array);
            BubbleSort.Sort(array);
            PrintArray(array);
        }

        public static void CountingSortExample()
        {
            int min = 0;
            int max = 20;

            int[] array = RandomArray(20, min, max + 1);
            PrintArray(array);
            CountingSort.Sort(array, min, max);
            PrintArray(array);
        }

        public static void InsertSortExample()
        {
            int[] array = RandomArray(20, 0, 21);
            PrintArray(array);
            InsertSort.Sort(array);
            PrintArray(array);
        }

        public static void MergeSortExample()
        {
            int[] array = RandomArray(20, 0, 21);
            PrintArray(array);
            MergeSort.Sort(array);
            PrintArray(array);
        }

        public static void QuickSortExample()
        {
            int[] array = RandomArray(20, 0, 21);
            PrintArray(array);
            QuickSort.Sort(array);
            PrintArray(array);
        }

        public static void SelectSortExample()
        {
            int[] array = RandomArray(20, 0, 21);
            PrintArray(array);
            SelectSort.Sort(array);
            PrintArray(array);
        }


        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        static int[] RandomArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++) {
                array[i] = rnd.Next(minValue, maxValue);
            }

            return array;
        }
    }
}
