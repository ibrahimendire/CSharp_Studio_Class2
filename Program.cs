using System;
using System.Collections.Generic;
namespace StudioCountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            //string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            Console.Write("Enter a sentence to count: ");
            string userInput = Console.ReadLine().ToLower();
            char[] inputArray = userInput.ToCharArray();
           

            Dictionary<char, int> Counts = new Dictionary<char, int>();
            foreach (char c in inputArray)
            {
                if (!Counts.ContainsKey(c))
                {
                    int i = Counts.GetValueOrDefault(c);
                    Counts.Add(c, 1);
                }
                else
                {
                    Counts[c]++;
                }

            }
                foreach (KeyValuePair<char, int> Count in Counts)
                {
                    Console.WriteLine(Count.Key + ":" + Count.Value);
                }
                Console.ReadLine();
            
        }
    }
}
