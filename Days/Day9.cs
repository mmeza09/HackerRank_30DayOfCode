using System;
using System.IO;

namespace ThirtyDaysOfCode.Days
{
    public static class Day9
    {
        public static void Execute()
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);
            
            Console.WriteLine(result);
            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
        }

        static int factorial(int n) {
            if(n==1)
            {
                return 1;
            }
            else
            {
                return n*factorial(n-1);
            }

        }
    }
}