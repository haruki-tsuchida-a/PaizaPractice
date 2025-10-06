using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class en
    {
        static void Matin(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var n = int.Parse(firstLine[0]);
            var r = int.Parse(firstLine[1]);

            var box = new List<(int, int, int, int)>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var h = int.Parse(line[0]);
                var w = int.Parse(line[1]);
                var d = int.Parse(line[2]);
                if (2 * r <= h && 2 * r <= w && 2 * r <= d)
                {
                    box.Add((h, w, d, i));

                }
            }
            for (int i = 0; i < box.Count; i++)
            {
                Console.WriteLine(box[i].Item4 + 1);
            }

        }
    }
}
