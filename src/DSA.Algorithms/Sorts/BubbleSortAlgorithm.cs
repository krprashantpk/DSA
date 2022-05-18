using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms.Sorts
{
    public static class BubbleSortAlgorithm
    {

        
        public static void BubbleOrderByDescending<T>(this T[] array) where T : IComparable<T>
        {
            if (array == null) throw new ArgumentNullException("array");

            if (array.Length == 1) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var swaped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1].CompareTo(array[j]) > 0)
                    {
                        swaped = true;
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                if (!swaped) break;
            }
        }
        public static void BubbleOrderBy<T>(this T[] array) where T : IComparable<T>
        {
            if (array == null) throw new ArgumentNullException("array");

            if (array.Length == 1) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var swaped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1].CompareTo(array[j]) < 0)
                    {
                        swaped = true;
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                if (!swaped) break;
            }

        }
    }
}
