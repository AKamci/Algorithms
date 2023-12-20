namespace BinarySearch
{
    public class BinarySearch
    {
        public static int Search(int[] arr, int target)
        {
            Array.Sort(arr);

            int lower = 0;
            int upper = arr.Length - 1;
            int mid;
            while (lower <= upper)
            {
                mid = lower + (upper - lower) / 2;
                if (arr[mid] < target)
                {
                    lower = mid + 1;

                }
                if (arr[mid] > target)
                {
                    upper = mid - 1;
                }
                if (arr[mid] == target)
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
