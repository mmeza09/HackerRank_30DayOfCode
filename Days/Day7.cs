using System.Linq;
using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day7
    {
        public static void Execute()
        {
            Console.WriteLine("Enter in one line, numbers separated by spaces to reverse: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Console.WriteLine(String.Join(" ",arr.Reverse()));
        }
    }
}