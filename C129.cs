using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaPractice
{
    internal class ce
    {
        static void edfd(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var N = int.Parse(firstLine[0]);
            var M = int.Parse(firstLine[1]);

            var firstList = new List<int>();
            var secondList = new List<int>();

            for (int i = 0; i < M; i++)
            {
                firstList.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < M; i++)
            {
                secondList.Add(int.Parse(Console.ReadLine()));
            }

            if (firstList.OrderBy(x => x).SequenceEqual(secondList.OrderBy(x => x)))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
