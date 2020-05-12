using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day5
    {
        public static void Execute(){
            Console.WriteLine("Enter number to multiple:");
            int n = Convert.ToInt32(Console.ReadLine());
                for(int i=1;i<=10;i++){
                    Console.WriteLine(string.Format("{0} x {1} = {2}",n,i,n*i));
                }
        }

    }
}