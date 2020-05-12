using System.Collections.Generic;
using System;

namespace ThirtyDaysOfCode.Days
{
    public static class Day8
    {
        public static void Execute()
        {
            Dictionary<string,int> phoneBook = new Dictionary<string, int>();
            // Console.WriteLine("Enter number of parameters:");
            int T=int.Parse(Console.In.ReadLine());
            char[] separator = new char[1]{char.Parse(" ")};
            for (int i = 0; i < T; i++) 
            {
                string contactData = Console.ReadLine();
                var arrData = contactData.Split(separator);
                phoneBook.Add(arrData[0],int.Parse(arrData[1]));
            }
            List<string> queries = new List<string>();
            string nameToSearch;
            // Console.WriteLine("Enter name to search: ");
            do
            {
                nameToSearch = Console.ReadLine();
                if (!string.IsNullOrEmpty(nameToSearch))
                {
                    queries.Add(nameToSearch);
                }

            }while(!string.IsNullOrEmpty(nameToSearch));
            foreach(var query in queries)
            {
                if(phoneBook.ContainsKey(query))
                {
                    Console.WriteLine("{0}={1}",query,phoneBook[query]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                
            }
        }
    }
}