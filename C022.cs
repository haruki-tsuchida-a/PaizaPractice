using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaPractice
{
    internal class vd
    {
        static void fgd(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lists = new List<(int, int, int, int)>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                lists.Add((int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3])));
            }
            int start = lists[0].Item1;
            int end = lists[n - 1].Item2;
            int highest = lists.OrderByDescending(x => x.Item3).First().Item3;
            int lowest = lists.OrderBy(x => x.Item4).First().Item4;
            Console.WriteLine($"{start} {end} {highest} {lowest}");
        }
    }
}
