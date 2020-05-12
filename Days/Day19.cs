using System;

namespace ThirtyDaysOfCode.Days
{
    interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    class Calculator2 : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum=0;
            int divisor = n;
            while(divisor > 0)
            {
                if(n%divisor==0){
                    sum += n/divisor;
                }
                divisor--;
            }
            return sum;
        }
    }

    public class Day19
    {
        public static void Execute()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator2();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
}