using System;

namespace DataStructures.Examples
{
    static class BinominalHeapExamples
    {
        public static void Example1()
        {
            BinominalHeap b = new BinominalHeap();
            b.Insert(5);
            b.Insert(7);
            b.Insert(3);
            b.Insert(0);
            b.Insert(15);
            b.Insert(8);

            while (!b.Empty()) {
                Console.Write(b.ExtractMax() + ", ");
            }

            // Output:
            // 15, 8, 7, 5, 3, 0, 
        }

        public static void Example2()
        {
            int[] keys1 = { 5, 7, 0, 15, 8 };
            BinominalHeap heap1 = new BinominalHeap(keys1);

            int[] keys2 = { 1, 2, 5, 8, 17};
            BinominalHeap heap2 = new BinominalHeap(keys2);

            heap1.MergeWith(heap2);

            while (!heap1.Empty()) {
                Console.Write(heap1.ExtractMax() + ", ");
            }

            // Output:
            // 17, 15, 8, 8, 7, 5, 5, 2, 1, 0
        }
    }
}
