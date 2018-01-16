using System;
using System.Collections.Generic;

namespace QuickSort
{
    public class Sorter<TItem, TList> 
        where TItem : IComparable 
        where TList : IList<TItem>
    {
        public void Sort(TList array)
        {
            Sort(array, 0, array.Count - 1);
        }

        private void Sort(TList array, int lo, int hi)
        {
            if (lo < hi)
            {
                var p = Partition(array, lo, hi);
                Sort(array, lo, p - 1);
                Sort(array, p, hi);
            }
        }

        private int Partition(TList array, int lo, int hi)
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
                    TItem t = array[i];
                    array[i] = array[j];
                    array[j] = t;
                    ++i;
                    --j;
                }
            }

            return i;
        }
        
        private static TItem GetPivot(TList array, int lo, int hi)
        {
            //return array[hi];//античная реализация
            //return array[lo];//как у Кормена
            return array[((hi - lo)  >> 1) + lo];//выбираем середину
        }
    }
}
