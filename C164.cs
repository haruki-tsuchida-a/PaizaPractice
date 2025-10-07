using System;
using System.Collections.Generic;

namespace PaizaPractice
{
    internal class Proeejgram
    {
        static void dfe(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            var nums = Console.ReadLine().Split(' ');
            foreach (var num in nums)
            {
                numbers.Add(int.Parse(num));
            }

            var Q = int.Parse(Console.ReadLine());
            List<(int, int)> combination = new List<(int, int)>();

            for (int i = 0; i < Q; i++)
            {
                var input = Console.ReadLine().Split(' ');
                combination.Add((int.Parse(input[0]), int.Parse(input[1])));
            }

            // 入れ替え処理
            foreach (var item in combination)
            {
                int idx1 = item.Item1 - 1;
                int idx2 = item.Item2 - 1;
                int temp = numbers[idx1];
                numbers[idx1] = numbers[idx2];
                numbers[idx2] = temp;
            }


            bool isSorted = true;
            for (int i = 1; i < N; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    isSorted = false;
                    break;
                }
            }
            Console.WriteLine(isSorted ? "Yes" : "No");
        }
    }
}
