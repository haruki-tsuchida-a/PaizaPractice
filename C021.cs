using System;
using System.Collections.Generic;

namespace e
{
    internal class Prodgram
    {
        static void e(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var xc = int.Parse(firstLine[0]);
            var yc = int.Parse(firstLine[1]);
            var r_1 = int.Parse(firstLine[2]);
            var r_2 = int.Parse(firstLine[3]);

            var n = int.Parse(Console.ReadLine());
            var nList = new List<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                int a = int.Parse(line[0]);
                int b = int.Parse(line[1]);
                nList.Add((a, b));
            }

            foreach (var person in nList)
            {
                int x = person.Item1;
                int y = person.Item2;
                double dist = Math.Sqrt(Math.Pow(x - xc, 2) + Math.Pow(y - yc, 2));
                if (dist >= r_1 && dist <= r_2)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
