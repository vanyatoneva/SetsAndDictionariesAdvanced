using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToArray();
            SortedDictionary<char, int> occurences = new SortedDictionary<char, int>();
            foreach(char c in chars)
            {
                if (!occurences.ContainsKey(c))
                {
                    occurences.Add(c, 0);
                }
                occurences[c]++;
            }

            foreach(var charOcc in occurences)
            {
                Console.WriteLine($"{charOcc.Key}: {charOcc.Value} time/s");
            }
        }
    }
}
