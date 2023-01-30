using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for(int i = 0; i < n; i++)
            {
                string[] inputElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for(int j = 0; j < inputElements.Length; j++)
                {
                    elements.Add(inputElements[j]);
                }
            }
            foreach(string element in elements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
