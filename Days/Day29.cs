using System;

namespace ThirtyDaysOfCode.Days
{
    public class Day29
    {
        static void MaxBitWise(int n, int k)
        {
            int maxBitwise=0;
            for(int i = 1; i <= n; i++)
            {
                for(int j = i + 1;j <= n; j++)
                {
                    if(i==j) continue;
                    int bitwise = i & j;
                    if(bitwise < k)
                    {
                        if(bitwise>maxBitwise)
                        {
                            maxBitwise=bitwise;
                        }
                    }
                    Console.WriteLine(i&j);
                }
            }
            Console.WriteLine(maxBitwise);
        }
        public static void Execute()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++) 
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);
                MaxBitWise(n,k);
                
            }
        }
    }
}