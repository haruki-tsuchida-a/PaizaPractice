using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class dce
    {
        static void Macdin(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var N = int.Parse(firstLine[0]);
            var M = int.Parse(firstLine[1]);

            var lists = new List<(int, string)>();

            for (int i = 0; i < M; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var A = int.Parse(line[0]);
                var B = line[1];
                lists.Add((A, B));
            }

            for (int i = 1; i <= N; i++)
            {
                var actions = new List<string>();
                foreach (var item in lists)
                {
                    var a = item.Item1;
                    var b = item.Item2;
                    if (i % a == 0)
                    {
                        actions.Add(b);
                    }
                }
                if (actions.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", actions));
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
