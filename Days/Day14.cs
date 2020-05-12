using System;
using System.Linq;

namespace ThirtyDaysOfCode.Days
{
    class Difference 
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] parameters)
        {
            elements = parameters;
        }
        public void computeDifference()
        {
            maximumDifference = 0;
            for(int i=0; i<elements.Length-1;i++)
            {
                for(int j=0; j<elements.Length;j++)
                {
                    if(i==j) continue;
                    int diference =  Math.Abs(elements[i] - elements[j]);
                    if(diference>maximumDifference) maximumDifference = diference;
                }
            }
        }
    }
    public static class Day14
    {
        public static void Execute()
        {
            Convert.ToInt32(Console.ReadLine());
        
            int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
            
            Difference d = new Difference(a);
            
            d.computeDifference();
            
            Console.WriteLine(d.maximumDifference);
        }
    }
}