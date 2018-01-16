using QuickSort.Tests.Helpers;
using Xunit;

namespace QuickSort.Tests
{
    public class BasicTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12})]
        [InlineData(new int[] { 0, 3, 4, 6, 12, 23, 94 })]
        public void Theory(int[] value)
        {
            var array = value.Clone() as int[];

            Shuffler.ShuffleByKnuteMethod(array);
            Sorter<int>.Sort(array, 0, array.Length - 1);
            Assert.Equal(value, array);
        }
    }
}
