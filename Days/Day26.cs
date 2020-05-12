using System;
using System.Collections.Generic;
using System.IO;
namespace ThirtyDaysOfCode.Days
{
    public class Day26
    {
        static int calculateFine(DateTime returnedDate, DateTime expectedReturnDate)
        {
            int days = Convert.ToInt32((returnedDate-expectedReturnDate).TotalDays);
            /* If the book is returned on or before the expected return date, no fine will be charged*/
            if(days <= 0 )
            {
                return 0;
            }
            /* If the book is returned after the expected return day 
               but still within the same calendar month and year as the expected return date, 
               fine = 15 x number of days late
            */
            else if(expectedReturnDate.Year == returnedDate.Year  && expectedReturnDate.Month == returnedDate.Month)
            {
                return 15 * days;
            }
            /* If the book is returned after the expected return month 
               but still within the same calendar year as the expected return date, the 
               fine = 500 x number of months late
            */
            else if(expectedReturnDate.Year == returnedDate.Year  && returnedDate.Month > expectedReturnDate.Month)
            {
                return  500 * (returnedDate.Month - expectedReturnDate.Month);
            }
            /* 
                If the book is returned after the calendar year in which it was expected, 
                there is a fixed fine of 1000
            */
            else
            {
                return 10000;
            }
        }
        public static void Execute()
        {
            int[][] arr = new int[2][];

            for (int i = 0; i < 2; i++) 
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            DateTime expectedReturnDate,returnedDate;
            returnedDate = new DateTime(arr[0][2],arr[0][1], arr[0][0]);
            expectedReturnDate = new DateTime(arr[1][2],arr[1][1], arr[1][0]);
            int fine = calculateFine(returnedDate,expectedReturnDate);
            Console.WriteLine(fine);
        }
    }
}