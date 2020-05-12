using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day1
    {
        public static void Execute(){
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            Console.WriteLine("Enter a integer:");
            int i2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a double:");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a string:");
            string s2 = Console.ReadLine();
            Console.WriteLine("Results:");
            Console.WriteLine(i+i2);
            Console.WriteLine(string.Format("{0:0.0}", d+d2));
            Console.WriteLine(s+ s2);
        }
        
    }
}