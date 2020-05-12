using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day10
    {
        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var binaryNumber =  Convert.ToString(n,2);
            Console.WriteLine(binaryNumber);
            int max=0;
            int count=0;
            for(int i = 0;i<binaryNumber.Length;i++)
            {
                if(int.Parse(binaryNumber[i].ToString())==1){
                    count++;
                }else{
                    
                    count=0;
                }
                if(count>max){
                    max=count;
                }
            }
            Console.WriteLine(max);
        }
    }
}