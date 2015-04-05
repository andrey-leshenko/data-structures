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
                Console.Write(b.PopMax() + ", ");
            }

            // Output:
            // 15, 8, 7, 5, 3, 0, 
        }

        public static void Example2()
        {
            BinominalHeap b = new BinominalHeap();
            b.Insert(5);
            b.Insert(7);
            b.Insert(0);
            b.Insert(15);
            b.Insert(8);

            BinominalHeap c = new BinominalHeap();
            c.Insert(1);
            c.Insert(2);
            c.Insert(5);
            c.Insert(8);
            c.Insert(17);

            b.MergeWith(c);

            while (!b.Empty()) {
                Console.Write(b.PopMax() + ", ");
            }

            // Output:
            // 17, 15, 8, 8, 7, 5, 5, 2, 1, 0
        }
    }
}
