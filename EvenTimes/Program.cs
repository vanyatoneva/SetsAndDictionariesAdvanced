using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> nums = new Dictionary<int, int>();
            for(int i = 0; i < n; i++)
            {
                int currNum = int.Parse((Console.ReadLine()));
                if (!nums.ContainsKey(currNum))
                {
                    nums.Add(currNum, 0);
                }
                nums[currNum]++;
            }
            Console.WriteLine(nums.Single(x=> x.Value % 2 ==0).Key);
        }
    }
}
