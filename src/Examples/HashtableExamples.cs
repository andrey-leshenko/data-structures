using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataStructures.Hashtables;

namespace DataStructures.Examples
{
    static class HashtableExamples
    {
        public static void Example1()
        {
            int size = 11;

            // The hashtable is smaller than the number of elements.
            // This guarantees collisions.
            OpenHashtable<string, int> h = new OpenHashtable<string, int>(73);
            h.debugLog = true;

            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    h[i + ", " + j] = i * j;
                }
            }

            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    Console.Write("{0,4}", h[i + ", " + j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
