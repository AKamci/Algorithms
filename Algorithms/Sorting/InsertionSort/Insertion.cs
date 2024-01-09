namespace InsertionSort
{
    public class Insertion
    {
        public static void Sort(int[] values)
        {
            int n = values.Length;
            for (int i = 1; i < n; ++i)
            {
                int currentItem = values[i];
                int j = i - 1;

                while (j >= 0 && values[j] > currentItem)
                {
                    values[j + 1] = values[j];
                    j = j - 1;
                }
                values[j + 1] = currentItem;
            }

        }
    }
}
