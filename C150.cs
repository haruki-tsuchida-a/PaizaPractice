using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class ProgTestram
    {
        static void Test(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            int N = int.Parse(firstLine[0]);
            int D = int.Parse(firstLine[1]);

            var secondLine = Console.ReadLine().Split(' ');
            int X = int.Parse(secondLine[0]);
            int Y = int.Parse(secondLine[1]);

            List<(int, int)> distance = new List<(int, int)>();

            for (int i = 0; i < N; i++)
            {
                var line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                distance.Add((x, y));
            }

            int count = 0;
            foreach (var item in distance)
            {
                int x = item.Item1;
                int y = item.Item2;

                //間違ったポイント
                //座標がマイナスの値を考慮できていなかった
                //double dist = Math.Abs(X + Y);
                //上記だと座標がマイナスの場合に計算できていない

                int dist = Math.Abs(x - X) + Math.Abs(y - Y);
                if (dist <= D)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
