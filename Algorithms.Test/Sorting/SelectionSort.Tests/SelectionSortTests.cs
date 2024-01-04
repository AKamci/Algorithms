namespace SelectionSort.Tests
{
    public class SelectionSortTests
    {
        [Fact]
        public void Should_Sort_Array_By_Using_Selection_Sort()
        {
            var unSortedArr = new int[] { 12, 45, 7, 23, 56, 89, 43 };
            int[] oldArr = new int[7];
            Array.Copy(unSortedArr, oldArr,7);

            Selection.Sort(unSortedArr);
            Assert.NotEqual(oldArr, unSortedArr);
        }
    }
}