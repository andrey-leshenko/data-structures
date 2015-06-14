using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.UnionFind
{
    class UnionFind<T>
    {
        public Node AddSet(T value)
        {
            return new Node(value);
        }

        public Node GetSet(Node node)
        {
            List<Node> path = new List<Node>();

            while (node.parent != null) {
                path.Add(node);
                node = node.parent;
            }

            Node root = node;

            foreach (Node pathNode in path) {
                pathNode.parent = root;
            }

            return root;
        }

        public void Union(Node a, Node b)
        {
            Node setA = GetSet(a);
            Node setB = GetSet(b);

            if (setA == setB)
                return;

            if (setA.rank > setB.rank) {
                setB.parent = setA;
            } else if (setA.rank == setB.rank) {
                setB.parent = setA;
                setA.rank++;
            } else {
                setA.parent = setB;
            }
        }

        public class Node
        {
            public Node parent;
            public int rank = 0;
            public T value;

            public Node(T value)
            {
                this.value = value;
            }
        }
    }
}
