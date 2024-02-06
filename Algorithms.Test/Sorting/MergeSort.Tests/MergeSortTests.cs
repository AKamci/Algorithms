namespace MergeSort.Tests
{
    public class MergeSortTests
    {
        [Fact]
        public void Should_Sort_Array_By_Using_Merge_Sort()
        {
            var unSortedArr = new int[] { 12, 45, 7, 23, 56, 89, 43, 2 };
            int[] oldArr = new int[7];
            Array.Copy(unSortedArr, oldArr, 7);

            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort(unSortedArr, 0, unSortedArr.Length - 1);
            
            Assert.NotEqual(oldArr, unSortedArr);
        }
    

    }
}