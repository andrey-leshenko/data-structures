using System.Collections.Generic;

namespace DataStructures
{
    class BinaryHeap
    {
        const int root = 0;

        List<int> keys;

        public BinaryHeap()
        {
            keys = new List<int>();
        }

        public BinaryHeap(int[] keysCollection)
        {
            this.keys = new List<int>(keysCollection);
            for (int i = keys.Count / 2; i >= 0; i--)
                OrderDownFrom(i);
        }

        public int Max()
        {
            return keys[0];
        }

        public int PopMax()
        {
            int max = Max();
            MoveLastToRoot();
            OrderDownFrom(root);

            return max;
        }

        public void Add(int key)
        {
            keys.Add(key);
            OrderUpFrom(keys.Count - 1);
        }

        public int Count()
        {
            return keys.Count;
        }

        void OrderDownFrom(int node)
        {
            while (!IsLeaf(node) && keys[MaxChild(node)] > keys[node]) {
                SwapWithParent(MaxChild(node));
                node = MaxChild(node);
            }
        }

        void OrderUpFrom(int node)
        {
            while (!IsRoot(node) && keys[node] > keys[Parent(node)]) {
                SwapWithParent(node);
                node = Parent(node);
            }
        }

        void SwapWithParent(int node)
        {
            int temp = keys[node];
            keys[node] = keys[Parent(node)];
            keys[Parent(node)] = temp;
        }

        int MaxChild(int node)
        {
            if (!HasRightChild(node))
                return LeftChild(node);

            int left = LeftChild(node);
            int right = RightChild(node);

            return keys[right] > keys[left] ? right : left;
        }

        void MoveLastToRoot()
        {
            keys[0] = keys[keys.Count - 1];
            keys.RemoveAt(keys.Count - 1);
        }

        int Parent(int node)            { return (node - 1) / 2; }

        int LeftChild(int node)         { return 2 * node + 1; }

        int RightChild(int node)        { return 2 * node + 2; }

        bool HasLeftChild(int node)     { return LeftChild(node) < keys.Count; }

        bool HasRightChild(int node)    { return RightChild(node) < keys.Count; }

        bool IsRoot(int node)           { return node == 0; }

        bool IsLeaf(int node)           { return !HasLeftChild(node); }
    }
}
