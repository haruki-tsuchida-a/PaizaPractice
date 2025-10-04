using System;
using System.Collections.Generic;
using System.Linq;

namespace PaizaPractice
{
    internal class te
    {
        static void ain(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');


            var M = int.Parse(firstLine[0]);
            var N = int.Parse(firstLine[1]);
            //カード一覧
            int[] cards = new int[M];
            for (int i = 0; i < M; i++)
            {
                cards[i] = i + 1;
            }


            int groupCount = M / 2;



            for (int i = 0; i < N; i++)
            {
                List<int> S = new List<int>();
                List<int> T = new List<int>();

                for (int j = 0; j < M; j++)
                {
                    if (j < groupCount)
                        S.Add(cards[j]);
                    else
                        T.Add(cards[j]);
                }

                int[] nextCards = new int[M];
                for (int k = 0; k < groupCount; k++)
                {
                    nextCards[2 * k] = T[k];
                    nextCards[2 * k + 1] = S[k];
                }
                cards = nextCards; // シャッフル結果を反映
            }
            Console.WriteLine(string.Join(" ", cards));

        }
    }
}
