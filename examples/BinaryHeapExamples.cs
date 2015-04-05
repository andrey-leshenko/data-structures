using System;

namespace DataStructures.Examples
{
    class BinaryHeapExamples
    {
        public static void Example1()
        {
            BinaryHeap b = new BinaryHeap();
            b.Add(5);
            b.Add(7);
            b.Add(3);
            b.Add(0);
            b.Add(15);
            b.Add(8);

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
