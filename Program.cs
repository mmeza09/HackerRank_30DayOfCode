using System;
using ThirtyDaysOfCode.Days;

namespace ThirtyDaysOfCode
{
    class Program
    {

        private static string[] dias = new string[29]{
            "1 - DAY1","2 - DAY2","3 - DAY3","4 - DAY4","5 - DAY5","6 - DAY6","7 - DAY7","8 - DAY8","9 - DAY9","10 - DAY10",
            "11 - DAY11","12 - DAY12","13 - DAY13","14 - DAY14","15 - DAY15","16 - DAY16","17 - DAY7","18 - DAY8","19 - DAY9","20 - DAY20",
            "21 - DAY21","22 - DAY22","23 - DAY23","24 - DAY24","25 - DAY25","26 - DAY26","27 - DAY27","28 - DAY28","29 - DAY29"
        };

        static void Main(string[] args)
        {
            bool confirmed = false;
            do
            {
                Console.WriteLine("Welcome to HackerRank's 30 Days of Code");
                Console.WriteLine("Days");
                for(int i=0;i< dias.Length;i++)
                {
                    Console.WriteLine(dias[i]);
                }
                Console.WriteLine("Write the day number to be executed: ");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        Day1.Execute();
                        break;
                    case 2:
                        Day2.Execute();
                        break;
                    case 3:
                        Day3.Execute();
                        break;
                    case 4:
                        Day4.Execute();
                        break;
                    case 5:
                        Day5.Execute();
                        break;
                    case 6:
                        Day6.Execute();
                        break;
                    case 7:
                        Day7.Execute();
                        break;
                    case 8:
                        Day8.Execute();
                        break;
                    case 9:
                        Day9.Execute();
                        break;
                    case 10:
                        Day10.Execute();
                        break;
                    case 11:
                        Day11.Execute();
                        break;
                    case 12:
                        Day12.Execute();
                        break;
                    case 13:
                        Day13.Execute();
                        break;
                    case 14:
                        Day14.Execute();
                        break;
                    case 15:
                        Day15.Execute();
                        break;              
                    case 16:
                        Day16.Execute();
                        break;              
                    case 17:
                        Day17.Execute();
                        break;              
                    case 18:
                        Day18.Execute();
                        break;              
                    case 19:
                        Day19.Execute();
                        break;              
                    case 20:
                        Day20.Execute();
                        break;              
                    case 21:
                        Day21.Execute();
                        break;              
                    case 22:
                        Day22.Execute();
                        break;              
                    case 23:
                        Day23.Execute();
                        break;              
                    case 24:
                        Day24.Execute();
                        break;              
                    case 25:
                        Day25.Execute();
                        break;              
                    case 26:
                        Day26.Execute();
                        break;              
                    case 27:
                        Day27.Execute();
                        break;              
                    case 28:
                        Day28.Execute();
                        break;              
                    case 29:
                        Day29.Execute();
                        break;              
                    default:
                        Console.WriteLine("Not Implemeted");
                        break;   
                }
                ConsoleKey response;
                do
                {
                    Console.Write("Execute another function? (Y/N) ");
                    response = Console.ReadKey(false).Key;
                    if (response != ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                    }

                }while(response != ConsoleKey.Y && response != ConsoleKey.N);
                confirmed = response == ConsoleKey.N;
            }while(!confirmed); 
        }
    }
    
}
