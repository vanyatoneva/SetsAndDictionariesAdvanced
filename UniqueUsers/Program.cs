using System;
using System.Collections.Generic;

namespace UniqueUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                set.Add(user);
            }
            foreach(string user in set)
            {
                Console.WriteLine(user);
            }
        }
    }
}
