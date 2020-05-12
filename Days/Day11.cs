using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day11
    {
        public static void Execute()
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) 
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int max=0;
            for(int j=0;j<arr.Length-2;j++)
            {
                for(int k=0;k<arr[j].Length-2;k++)
                {
                    int sum=0;
                    sum = arr[j][k] + arr[j][k+1] + arr[j][k+2] + arr[j+1][k+1] + arr[j+2][k] + arr[j+2][k+1] + arr[j+2][k+2];
                    if(j==0 && k==0)
                    {
                        max=sum;
                    }
                    max = sum > max ? sum : max;
                }
            }
            Console.WriteLine(max);
        }
    }
}