using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day6
    {
        public static void Execute(){
            int T=int.Parse(Console.In.ReadLine());
            string[] stringArr = new string[T];
            for (int i = 0; i < T; i++) {
                stringArr[i] =Console.ReadLine();
            }
            for(int i=0; i<stringArr.Length;i++)
            {
                string oddString ="",evenString="";
                for(int j=0;j<stringArr[i].Length;j++){
                    if(j%2==0){
                        evenString+=stringArr[i][j];
                    } else{
                        oddString+=stringArr[i][j];
                    }
                }
                Console.WriteLine($"{evenString} {oddString}");

            }
        }
    }
}