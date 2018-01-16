using System;
using System.Collections.Generic;

namespace QuickSort
{
    public class Sorter<T> where T : IComparable
    {
        public void Sort(IList<T> array)
        {
            Sort(array, 0, array.Count - 1);
        }

        private void Sort(IList<T> array, int lo, int hi)
        {
            if (lo < hi)
            {
                var p = Partition(array, lo, hi);
                Sort(array, lo, p - 1);
                Sort(array, p, hi);
            }
        }

        private int Partition(IList<T> array, int lo, int hi)
        {
            var pivot = GetPivot(array, lo, hi);
            var i = lo;
            var j = hi;

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0) ++i;
                while (array[j].CompareTo(pivot) > 0) --j;
                if (i <= j)
                {
                    T t = array[i];
                    array[i] = array[j];
                    array[j] = t;
                    ++i;
                    --j;
                }
            }

            return i;
        }
        
        private static T GetPivot(IList<T> array, int lo, int hi)
        {
            //return array[hi];//античная реализация
            //return array[lo];//как у Кормена
            return array[((hi - lo)  >> 1) + lo];//выбираем середину
        }
    }
}
