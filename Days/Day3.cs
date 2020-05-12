using System;

namespace ThirtyDaysOfCode.Days
{
    public class Day3
    {
        public static void Execute(){
            Console.WriteLine("Enter a number:");
            int N = Convert.ToInt32(Console.ReadLine());
            if(N % 2 == 1){
                Console.WriteLine("Weird");
            }else if(N%2==0){
                if(N>=2&& N<=5){
                    Console.WriteLine("Not Weird");
                }else if(N>=6 && N<=20){
                    Console.WriteLine("Weird");
                }
                else if(N>20){
                    Console.WriteLine("Not Weird");
                }
            }
        }
    }
}