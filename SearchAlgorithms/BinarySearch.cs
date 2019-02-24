using System;

namespace ConsoleApp1.SearchAlgorithms
{
    public class BinarySearch
    {
        // Binary Search Algorithm - Iterative Way
        public static bool SearchIterativeWay(int[] arr, int size, int value)
        {
            int low = 0;
            int high = size - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (arr[mid] == value)
                {
                    return true;
                }
                else if (arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return false;
        }

        // Binary Search Algorithm - Recursive Way
        public static bool BinarySearchRecUtil(int[] arr, int low, int high, int value)
        {
            if (low > high)
            {
                return false;
            }
            int mid = (low + high) / 2;
            if (arr[mid] == value)
            {
                return true;
            }
            else if (arr[mid] < value)
            {
                return BinarySearchRecUtil(arr, mid + 1, high,

                value);
            }
            else
            {
                return BinarySearchRecUtil(arr, low, mid - 1, value);
            }
        }

        // Returns index of x if it is present in arr[],  
        // else return -1  
        public static int SearchString(String[] arr, String x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                int res = x.CompareTo(arr[mid]);

                // Check if x is present at mid  
                if (res == 0)
                    return mid;

                // If x greater, ignore left half  
                if (res > 0)
                    low = mid + 1;

                // If x is smaller, ignore right half  
                else
                    high = mid - 1;
            }

            return -1;
        }
    }
}
