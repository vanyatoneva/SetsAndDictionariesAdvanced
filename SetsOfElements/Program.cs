using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            int[] countOfNums = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            int n = countOfNums[0];
            int m = countOfNums[1];
            for(int i = 0; i < n; i++)
            {
               
                    set1.Add(int.Parse(Console.ReadLine()));
               
            }
            for(int i = n; i < m+n; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            foreach(int num in set1)
            {
                if (set2.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
