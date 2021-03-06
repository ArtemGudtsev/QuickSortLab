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
            var sorter = new Sorter<int, int[]>();

            Shuffler.ShuffleByKnuteMethod(array);
            sorter.Sort(array);
            Assert.Equal(value, array);
        }
    }
}
