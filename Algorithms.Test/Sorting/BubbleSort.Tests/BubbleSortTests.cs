namespace BubbleSort.Tests
{
    public class BubbleSortTests
    {
        public int[] OrderedArray => new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public int[] UnorderedArray => new int[] { 12, 45, 7, 23, 56, 89, 43 };

        [Fact]
        public void Should_Sort_Array_By_Using_Bubble_Sort_With_Empty_Array()
        {
            int[] arr1 = { };
            int[] result = { };
            Bubble.Sort(arr1);

            Assert.Equal(arr1, result);
        }

        [Fact]
        public void Should_Sort_Array_By_Using_Bubble_Sort()
        {
            int[] arr1 = { 12, 45, 7, 23, 56, 89, 43 };
            int[] arr2 = arr1;
            int[] result = { 7, 12, 23, 43, 45, 56, 89 };
            Bubble.Sort(arr2);

            Assert.Equal(arr1, result);
        }
    }
}