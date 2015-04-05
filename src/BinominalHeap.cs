﻿using System;
using System.Collections.Generic;

namespace DataStructures
{
    class BinominalHeap
    {
        List<BinominalTree> trees = new List<BinominalTree>();

        public BinominalHeap() { }

        public BinominalHeap(int singleKey)
        {
            trees.Add(new BinominalTree(singleKey));
        }

        public void MergeWith(BinominalHeap other)
        {
            BinominalTree carryIn = null;
            int i = 0;

            int treesCount = Math.Max(TreesLength(), other.TreesLength());

            while (i < treesCount || carryIn != null) {
                BinominalTree carryOut;
                BinominalTree sum = CombineTrees(GetTree(i), other.GetTree(i), carryIn, out carryOut);
                SetTree(i, sum);
                carryIn = carryOut;
                i++;
            }
        }

        public int Max()
        {
            return GetMaxTree().key;
        }

        public void Insert(int key)
        {
            MergeWith(new BinominalHeap(key));
        }

        public int PopMax()
        {
            BinominalTree maxTree = GetMaxTree();
            BinominalHeap childrenHeap = new BinominalHeap();
            childrenHeap.trees = maxTree.children;

            trees[maxTree.Order] = null;

            if (maxTree.Order == trees.Count)
                TrimEnd();

            MergeWith(childrenHeap);
            return maxTree.key;
        }

        public int TreesLength()
        {
            return trees.Count;
        }

        public bool Empty()
        {
            for (int i = 0; i < trees.Count; i++)
                if (trees[i] != null)
                    return false;
            return true;
        }

        public BinominalTree GetTree(int order)
        {
            if (order >= trees.Count)
                return null;
            else
                return trees[order];
        }

        void SetTree(int order, BinominalTree value)
        {
            while (trees.Count <= order)
                trees.Add(null);
            trees[order] = value;
        }

        void TrimEnd()
        {
            int i = trees.Count;
            while (i >= 0 && trees[i] == null) {
                trees.RemoveAt(i);
                i--;
            }
        }

        BinominalTree GetMaxTree()
        {
            BinominalTree maxTree = null;
            for (int i = 0; i < trees.Count; i++)
                if (trees[i] != null && (maxTree == null || trees[i].key > maxTree.key))
                    maxTree = trees[i];
            return maxTree;
        }

        BinominalTree CombineTrees(BinominalTree left, BinominalTree right, BinominalTree carryIn, out BinominalTree carryOut)
        {
            if (left != null && right != null) {
                carryOut = CombineTrees(left, right);
                return carryIn;
            }
            if (left != null && carryIn != null) {
                carryOut = CombineTrees(left, carryIn);
                return right;
            }
            if (right != null && carryIn != null) {
                carryOut = CombineTrees(right, carryIn);
                return left;
            }
            carryOut = null;
            return CombineTrees(CombineTrees(left, right), carryIn);
        }

        BinominalTree CombineTrees(BinominalTree a, BinominalTree b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;

            if (a.key >= b.key)
                return a.AddSubTree(b);
            else
                return b.AddSubTree(a);
        }

        public class BinominalTree
        {
            public int key;
            public List<BinominalTree> children = new List<BinominalTree>();

            public BinominalTree(int key)
            {
                this.key = key;
            }

            public int Order { get { return children.Count; } }

            public BinominalTree AddSubTree(BinominalTree other)
            {
                if (other != null) {
                    if (Order != other.Order) {
                        throw new Exception("Can not add binominal trees of different orders");
                    }
                    children.Add(other);
                }
                return this;
            }
        }
    }
}