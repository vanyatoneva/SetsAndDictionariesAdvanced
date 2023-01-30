using System;
using System.Collections.Generic;

namespace Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] clothes = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = clothes[0];
                clothes = clothes[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                
                foreach(string cl in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cl))
                    {
                        wardrobe[color].Add(cl, 0);
                    }
                    wardrobe[color][cl]++;
                }
            }

            string[] clothToWear = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach(var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach(var cloth in color.Value)
                {
                    if (color.Key == clothToWear[0] && cloth.Key == clothToWear[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
