using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day2
    {
        public static void Execute(){
            Console.WriteLine("Enter meal coast:");
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter tip percentage:");
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tax percentage:");
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Results");
            solve(meal_cost, tip_percent, tax_percent);
        }

        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent) {
            double tip = meal_cost * ((double)tip_percent/100);
            double tax = meal_cost * ((double)tax_percent/100);
            double totalCost = meal_cost + tip + tax;
            Console.WriteLine(Math.Round(totalCost,0));
        }
        
    }
}