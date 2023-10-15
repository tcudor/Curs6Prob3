using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6Prob3
{
    internal class ArrayHelper
    {
        public static int BinarySearch(int[] array, int target, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    return BinarySearch(array, target, mid + 1, right);
                }
                else
                {
                    return BinarySearch(array, target, left, mid - 1);
                }
            }

            return -1;
        }
        public static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
