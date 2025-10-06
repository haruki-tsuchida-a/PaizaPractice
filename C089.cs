using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class ec
    {
        static void fe(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            int H = int.Parse(firstLine[0]);
            int W = int.Parse(firstLine[1]);

            string[] result = new string[H];
            for (int i = 0; i < H; i++)
            {
                result[i] = Console.ReadLine();
            }

            int[,] scores = new int[H, W];
            for (int i = 0; i < H; i++)
            {
                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < W; j++)
                {
                    scores[i, j] = int.Parse(line[j]);
                }
            }

            int total = 0;
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (result[i][j] == 'o')
                    {
                        total += scores[i, j];
                    }
                }
            }
            Console.WriteLine(total);
        }
    }
}
