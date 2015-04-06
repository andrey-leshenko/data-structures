using System;

namespace DataStructures.Examples
{
    static class BinaryHeapExamples
    {
        public static void Example1()
        {
            BinaryHeap b = new BinaryHeap();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(0);
            b.Insert(15);
            b.Insert(8);

            while (b.Count() > 0) {
                Console.Write(b.PopMax() + ", ");
            }

            // Output:
            // 15, 8, 7, 5, 3, 0, 
        }

        public static void Example2()
        {
            int[] unsorted = { 5, 9, 3, 4, };
            BinaryHeap b = new BinaryHeap(unsorted);

            int[] downSorted = new int[unsorted.Length];

            for (int i = 0; i < downSorted.Length; i++) {
                downSorted[i] = b.PopMax();
            }

            // downSorted is [9, 5, 4, 3]
        }
    }
}
