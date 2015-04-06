using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sorting
{
    static class InsertSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++) {
                int toInsert = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > toInsert) {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = toInsert;
            }
        }
    }
}
