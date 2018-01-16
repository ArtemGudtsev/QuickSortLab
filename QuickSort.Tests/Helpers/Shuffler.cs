using System;
using System.Collections;

namespace QuickSort.Tests.Helpers
{
    public static class Shuffler
    {
        public static void ShuffleByKnuteMethod<T>(T list) where T : IList
        {
            var rnd = new Random();
            
            for (int i = 0; i < list.Count; i++)
            {
                var rndIndex = rnd.Next(list.Count);
                var t = list[rndIndex];

                list[rndIndex] = list[i];
                list[i] = t;
            }
        }
    }
}
