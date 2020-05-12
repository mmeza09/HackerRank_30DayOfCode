using System;

namespace ThirtyDaysOfCode.Days
{
    public class Day20
    {
        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);
            sortArray(n, a);
        }

         private static void sortArray(int n, int[] a)
        {
            int totalSwap = 0;

            for (int i = 0; i < n; i++)
            {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;

                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        int firstIndex = Array.IndexOf(a, a[j]);
                        int secondIndex = Array.IndexOf(a, a[j + 1]);
                        int v1 = a[j];
                        int v2 = a[j+1];
                        a[secondIndex] = v1;
                        a[firstIndex] = v2;
                        numberOfSwaps++;
                    }
                }
                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }
                totalSwap += numberOfSwaps;
            }
            Console.WriteLine("Array is sorted in {0} swaps.", totalSwap);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[n - 1]);
        }
    }
    
}