using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class cei
    {
        static void ed(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var N = int.Parse(firstLine[0]);
            var c_1 = int.Parse(firstLine[1]);
            var c_2 = int.Parse(firstLine[2]);

            int profit = 0;
            int stocks = 0;

            int[] prices = new int[N];
            for (int i = 0; i < N; i++)
            {
                prices[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                int value = prices[i];
                if (value <= c_1)
                {
                    profit -= value;
                    stocks++;
                }
                else if (value >= c_2 && stocks > 0 && i != N - 1)
                {
                    profit += value * stocks;
                    stocks = 0;
                }
            }
            // N日目は必ず売る
            if (stocks > 0)
            {
                profit += prices[N - 1] * stocks;
            }

            Console.WriteLine(profit);
        }
    }
}
