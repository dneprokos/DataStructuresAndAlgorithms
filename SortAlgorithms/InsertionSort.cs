using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InsertionSort
    {
        public static int [] Sort(int[] array)
        {
            int size = array.Length;
            int temp, j;

            for (int i = 1; i < size; i++)
            {
                temp = array[i];
                for (j = i; j > 0 && More(array[j - 1], temp); j--)
                {
                    array[j] = array[j - 1];
                }
                array[j] = temp;
            }

            return array;
        }

        private static bool More(int value1, int value2)
        {
            return value1 > value2;
        }

        private static bool Less(int value1, int value2)
        {
            return value1 < value2;
        }
    }
}
