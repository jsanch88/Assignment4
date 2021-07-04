using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    class Program
    {
        // Function to calculate matching pairs
        static int matching_pairs(List<int> input_list)
        {
            int totalPairs = 0;

            Dictionary<int, int> pair = input_list.GroupBy(x => x)
            .Where(c => c.Count() > 1)
            .ToDictionary(x => x.Key, x => x.Count());

            foreach(int values in pair.Values)
            {
                totalPairs += values /2;
            }
            return totalPairs;

        }
        static void Main(string[] args)
        {
            // Reading each input and seeing each input as a color (integer)
            Console.Clear();
            Console.WriteLine("Welcome to the sock sorter!\n");
            Console.WriteLine("Please enter values for the various socks that we need to find pairs for: ");
            string input = Console.ReadLine();
            string[] input_list;
            input_list = input.Split(' ');
            
            List<int> pairs = new List<int>();

            foreach (string i in input_list)
            {
                pairs.Add(Convert.ToInt32(i));
            }
            // Output of matching pairs
            int result = matching_pairs(pairs);
            Console.WriteLine("Matching pairs: {0}", result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
