namespace BinarySearch.Tests
{
    public class BinarySearchTest
    {
        public int[] OrderedArray => new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public int[] UnorderedArray => new int[] { 12, 45, 7, 23, 56, 89, 43 };
        [Fact]
        public void Should_Find_On_Array()
        {
            int target = 2;
            int result = BinarySearch.Search(OrderedArray, target);
            Assert.NotEqual(-1, result);
        }
        [Fact]
        public void Should_Not_Find_On_Array()
        {
            int target = 100;

            int result = BinarySearch.Search(OrderedArray, target);

            Assert.Equal(-1, result);
        }
    }
}