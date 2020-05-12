using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;

namespace ThirtyDaysOfCode.Days
{
    public class Day28
    {
        public static void Execute()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> names = new List<string>();

            for (int NItr = 0; NItr < N; NItr++) 
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                string pattern = $"@gmail.com";
                Match m = Regex.Match(emailID, pattern);
                if(m.Success)
                    names.Add(firstName);
            }
            names.Sort();
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}