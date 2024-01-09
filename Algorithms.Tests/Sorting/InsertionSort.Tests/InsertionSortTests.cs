namespace InsertionSort.Tests
{
    public class InsertionSortTests
    {
        [Fact]
        public void Should_Sort_Array_By_Using_Insertion_Sort()
        {
            var unSortedArr = new int[] { 12, 45, 7, 23, 56, 89, 43, 2 };
            int[] oldArr = new int[7];
            Array.Copy(unSortedArr, oldArr, 7);

            Insertion.Sort(unSortedArr);
            Assert.NotEqual(oldArr, unSortedArr);
        }
    }
}