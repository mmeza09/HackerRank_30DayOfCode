using System;

namespace ThirtyDaysOfCode.Days
{
    public class Day16
    {
        public static void Execute()
        {
            string S = Console.ReadLine();
            try
            {
                int value = int.Parse(S);
                Console.WriteLine(value);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
            
            
        }
    }
}