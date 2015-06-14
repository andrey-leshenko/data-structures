using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataStructures.UnionFind;

namespace DataStructures.Examples
{
    class UnionFindExamples
    {
        static void Main(string[] args)
        {
            UnionFind<int> uf = new UnionFind<int>();

            var nodes = new UnionFind<int>.Node[10];

            for (int i = 0; i < 10; i++) {
                nodes[i] = uf.AddSet(i);
            }
            // 0 1 2 3 4 5 6 7 8 9
            uf.Union(nodes[0], nodes[1]);
            // 01 2 3 4 5 6 7 8 9
            uf.Union(nodes[2], nodes[3]);
            // 01 23 4 5 6 7 8 9
            uf.Union(nodes[1], nodes[4]);
            // 014 23 5 6 7 8 9
            uf.Union(nodes[5], nodes[6]);

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("The set of {0} is {1}", i, uf.GetSet(nodes[i]).value);
            }
            Console.WriteLine();

            // 014 23 56 7 8 9
            uf.Union(nodes[5], nodes[6]); // Union it again!
            // 014 23 56 7 8 9
            uf.Union(nodes[4], nodes[6]);
            // 01456 23 7 8 9
            uf.Union(nodes[8], nodes[9]);
            // 01456 23 7 89

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("The set of {0} is {1}", i, uf.GetSet(nodes[i]).value);
            }

            Console.Read();
        }
    }
}
