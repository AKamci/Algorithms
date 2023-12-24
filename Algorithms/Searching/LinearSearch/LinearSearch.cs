namespace LinearSearch
{
    public class LinearSearch
    {
        public static int Search(int[] arr, int target)
        {
            // Complexity = O(n);
            var index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
