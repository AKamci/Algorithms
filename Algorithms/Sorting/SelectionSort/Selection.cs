namespace SelectionSort
{
    public class Selection
    {
        public static void Sort(int[] values)
        {
            int minValueIndex = 0;
            int unSortedIndex = 0;
            for (int i = 0; i < values.Length - 1; i++) //64-25-12-22-11
            {
                int minValue = int.MaxValue;
                for (int j = unSortedIndex; j < values.Length; j++)
                {
                    int currentItem = values[j];
                    if(currentItem < minValue)
                    {
                        minValue = currentItem;
                        minValueIndex = j;
                    }
                        
                }
                Swap(values, minValueIndex, unSortedIndex);
                unSortedIndex++;
            }
        }

        private static void Swap(int[] values, int minValueIndex, int unSortedIndex) { 
            var temp = values[minValueIndex];
            values[minValueIndex] = values[unSortedIndex];
            values[unSortedIndex] = temp;
        }
    }
}
