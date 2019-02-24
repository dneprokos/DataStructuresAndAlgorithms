namespace ConsoleApp1.SearchAlgorithms
{
    public class LinearSearch
    {
        public static bool linearSearchSorted(int[] arr, int size, int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (value == arr[i])
                {
                    return true;
                }
                else if (value < arr[i])
                {
                    return false;
                }
            }
            return false;
        }

        public static bool linearSearchUnsorted(int[] arr, int size, int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (value == arr[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
