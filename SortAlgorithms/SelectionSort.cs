namespace ConsoleApp1
{
    public class SelectionSort
    {
        public static int [] Sort(int[] arr)
        {
            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swap(ref arr[i], ref arr[min]);
                    }
                }
            }
            return arr;
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
