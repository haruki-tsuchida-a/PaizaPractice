using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class rt
    {
        static void isd(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            int H = int.Parse(firstLine[0]);
            int W = int.Parse(firstLine[1]);

            var info = new List<string>();
            int sx = 0, sy = 0, gx = 0, gy = 0;
            int[,] monsters = new int[H, W];

            for (int i = 0; i < H; i++)
            {
                var row = Console.ReadLine();
                info.Add(row);
                for (int j = 0; j < W; j++)
                {
                    char c = row[j];
                    //スタート地点の設定
                    if (c == 'S')
                    {
                        sx = i;
                        sy = j;
                        monsters[i, j] = 0;
                    }
                    //ゴール地点の設定
                    else if (c == 'G')
                    {
                        gx = i;
                        gy = j;
                        monsters[i, j] = 0;
                    }
                    else
                    //モンスター数の設定
                    {
                        monsters[i, j] = c - '0';
                    }
                }
            }

            int[,] dist = new int[H, W];

            //初期化
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    dist[i, j] = int.MaxValue;
                }
            }
            //スタート地点のモンスター討伐数
            dist[sx, sy] = 0;

            var queue = new Queue<(int x, int y)>();
            queue.Enqueue((sx, sy));

            int[] dx = { 1, -1, 0, 0 };
            int[] dy = { 0, 0, 1, -1 };

            while (queue.Count > 0)
            {
                var (x, y) = queue.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = x + dx[dir];
                    int ny = y + dy[dir];
                    //マップの外に出る場合
                    if (nx < 0 || nx >= H || ny < 0 || ny >= W) continue;
                    int cost = dist[x, y] + monsters[nx, ny];
                    if (cost < dist[nx, ny])
                    {
                        dist[nx, ny] = cost;
                        queue.Enqueue((nx, ny));
                    }
                }
            }

            Console.WriteLine(dist[gx, gy]);
        }
    }
}
