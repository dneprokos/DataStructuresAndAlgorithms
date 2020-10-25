using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApp1.DataStructures._1_Array;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CustomList<int> test = new CustomList<int>();
            test.Add(2);
            test.Add(2);
            test.Add(3);
            test.Add(5);
            test.Add(10);

            test.Remove(5);

            test.PrintList();


            Console.ReadLine();
        }

        public static int CalculateSum(int[] arr)
        {
            var totalNumber = 0;
            foreach (var t in arr)
            {
                totalNumber += t;
            }

            return totalNumber;
        }
    }
}
