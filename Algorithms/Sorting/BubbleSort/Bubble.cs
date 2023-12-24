namespace BubbleSort
{
    public class Bubble
    {
        public static int Pass { get; set; }
        public static void Sort(int[] values)
        {
            int n = values.Length;
            Pass = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
                Pass++;
            }
        }

        public static void Sort2(int[] values)
        {
            int n = values.Length;
            Pass = 0;


            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int value1 = values[j];
                    int value2 = values[j + 1];

                    if (value1 > value2)
                    {
                        int temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }
                }
                Pass++;
            }


        }
    }
}
