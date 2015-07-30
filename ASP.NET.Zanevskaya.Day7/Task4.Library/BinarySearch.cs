using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Library
{
    public class BinarySearch
    {
        public static int Binary<T>(T[] array, T key)
        {
            return BinaryFinder(array, key, 0, array.Length, null);
        }
        public static int Binary<T>(T[] array, T key, IComparer<T> comparer)
        {
            if (ReferenceEquals(comparer, null)) throw new ArgumentNullException("comparer");
            return Binary<T>(array, key, comparer.Compare);
        }
        public static int Binary<T>(T[] array, T key, Comparison<T> comparison)
        {
            if (ReferenceEquals(comparison, null)) throw new ArgumentNullException("comparison");
            return BinaryFinder<T>(array, key, 0, array.Length, comparison);
        }
        private static int BinaryFinder<T>(T[] array, T key, int left, int right, Comparison<T> comparison)
        {
            if (left >= right || right == 0) return -1;
            if (ReferenceEquals(array, null)) throw new ArgumentNullException("array");
            if (!(key is IComparable<T>)) throw new ArgumentException("key is invalid");
            if (ReferenceEquals(comparison, null)) comparison = Compare;
            int mid = left + (right - left) / 2;
            if (comparison(array[mid], key) == 0) return mid;
            else if (comparison(array[mid], key) > 0) 
            return BinaryFinder(array, key, left, mid, comparison);
            else return BinaryFinder<T>(array, key, mid + 1, right, comparison);
        }
        private static int Compare<T>(T firstN, T secondN)
        {
            if (ReferenceEquals(firstN, null)) return -1;
            if (ReferenceEquals(firstN, secondN)) return 0;

            IComparable<T> compare = firstN as IComparable<T>;
            return compare.CompareTo(secondN);
        }       
    }
}
